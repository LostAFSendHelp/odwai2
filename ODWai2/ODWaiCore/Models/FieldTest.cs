/*
    A class for generating test cases for a field rule. The logic is a bit messy since the number of 
    aggregations is massive.
    That means this is more an experimental prototype of the functionality than an actual working model.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace ODWai2.ODWaiCore.Models
{
    public class FieldTest
    {
        private static char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private static char[] numbers = "0123456789".ToCharArray();
        private static char[] alphanumerics = letters.Concat(numbers).ToArray();
        private static Random random = new Random();

        public string field_name;
        public List<string> associated;
        public List<string> error_forces;
        public List<string> error_rejects;
        public string upper;
        public string lower;
        public (string, string) valid;

        public static FieldTest from_rule(FieldRule rule)
        {
            return new FieldTest() {
                field_name = rule.field_name,
                associated = rule.associated,
                error_forces = generate_error_forces(rule),
                error_rejects = generate_error_rejects(rule),
                upper = generate_upper(rule),
                lower = generate_lower(rule),
                valid = generate_valid_case(rule)
            };
        }

        // errors containing rejected characters
        private static List<string> generate_error_rejects(FieldRule rule)
        {
            List<char> reject = rule.must_not_have;

            /* In practice, this system does not arrow excluding all alphanumerics, 
                so at most 1 of the following cases will happen */
            if (rule.rejects_alphabets) { reject.Add('a'); }
            if (rule.rejects_numbers) { reject.Add('1'); }

            List<string> cases = new List<string>();

            // one rejected character for each case
            foreach (char rejected in reject)
            {
                cases.Add(rejected.ToString());
            }

            // fill each case with salt
            cases = cases.Select(@case =>
            {
                while (@case.Length < rule.min)
                {
                    @case += alphanumerics[random.Next(alphanumerics.Length)];
                }
                return @case;
            }).ToList();
            
            return cases;
        }

        // errors not containing forced characters
        private static List<string> generate_error_forces(FieldRule rule)
        {
            List<string> cases = new List<string>();

            // all uppercase for forced lowercase
            if (rule.forces_lowercase)
            {
                string @case = "";
                while (@case.Length < rule.min)
                {
                    @case += alphanumerics[random.Next(alphanumerics.Length)].ToString().ToUpper();
                }
                cases.Add(@case);
            }

            // all lowercase for forced uppercase
            if (rule.forces_uppercase)
            {
                string @case = "";
                while (@case.Length < rule.min)
                {
                    @case += alphanumerics[random.Next(alphanumerics.Length)].ToString().ToLower();
                }
                cases.Add(@case);
            }

            // all letters for forced numbers
            if (rule.forces_numbers)
            {
                string @case = "";
                while (@case.Length < rule.min)
                {
                    @case += letters[random.Next(letters.Length)].ToString();
                }
                cases.Add(@case);
            }

            return cases;
        }

        // valid characters but exceeds maximum length
        // missing a case for special characters that are accepted
        private static string generate_upper(FieldRule rule) // I mean upper bounds ;)
        {
            string buffer = "";

            // all numbers if no alphabets
            if (rule.rejects_alphabets == true)
            {
                while (buffer.Length <= rule.max) { buffer += numbers[random.Next(numbers.Length)]; }

                return buffer;
            }

            // all alphabets if no numbers
            if (rule.rejects_numbers == true)
            {
                while (buffer.Length <= rule.max) { buffer += letters[random.Next(letters.Length)]; }

                if (rule.forces_lowercase) { buffer = buffer.Replace(buffer[0], 'a'); }

                return buffer;
            }

            // if no rejects
            if (rule.forces_lowercase) { buffer += 'a'; }

            if (rule.forces_uppercase) { buffer += "A"; }

            if (rule.forces_numbers) { buffer += '1'; }

            while (buffer.Length <= rule.max)
            {
                buffer += alphanumerics[random.Next(alphanumerics.Length)];
                if (rule.forces_lowercase)
                {
                    buffer = buffer.Replace(buffer[0], 'a');
                }
            }

            return buffer;
        }

        // missing a case for special characters that are accepted
        private static string generate_lower(FieldRule rule) // and lower bounds ;)
        {
            string buffer = "";

            // all numbers if no alphabets
            if (rule.rejects_alphabets == true)
            {
                while (buffer.Length < rule.min - 1) { buffer += numbers[random.Next(numbers.Length)]; }

                return buffer;
            }

            // all alphabets if no numbers
            if (rule.rejects_numbers == true)
            {
                while (buffer.Length < rule.min - 1) { buffer += letters[random.Next(letters.Length)]; }

                if (rule.forces_lowercase) { buffer.Replace(buffer[0], 'a'); }

                return buffer;
            }

            // if no rejects
            while (buffer.Length < rule.min - 1)
            {
                buffer += alphanumerics[random.Next(alphanumerics.Length)];
            }

            return buffer;
        }

        // 1 case for upper bound, 1 for lower bound
        // this is missing a case for special characters that are accepted
        private static (string, string) generate_valid_case(FieldRule rule)
        {
            string buffer = "";
            string long_buffer = "";

            if (rule.rejects_alphabets)
            {
                while (buffer.Length < rule.min) { buffer += numbers[random.Next(numbers.Length)]; }

                long_buffer = buffer;

                while (long_buffer.Length < rule.max) { long_buffer += numbers[random.Next(numbers.Length)]; }

                return (buffer, long_buffer);
            }

            if (rule.rejects_numbers)
            {
                while (buffer.Length < rule.min) { buffer += letters[random.Next(letters.Length)]; }

                long_buffer = buffer;

                while (long_buffer.Length < rule.max) { long_buffer += letters[random.Next(letters.Length)]; }

                if (rule.forces_lowercase)
                {
                    buffer = buffer.Replace(buffer[0], 'a');
                    long_buffer = buffer.Replace(long_buffer[0], 'a');
                }

                return (buffer, long_buffer);
            }

            if (rule.forces_lowercase) { buffer += 'a'; }
            if (rule.forces_uppercase) { buffer += 'A'; }
            if (rule.forces_numbers) { buffer += '1'; }

            while (buffer.Length < rule.min) { buffer += alphanumerics[random.Next(alphanumerics.Length)]; }
            long_buffer = buffer;
            while (long_buffer.Length < rule.max)
            {
                long_buffer += alphanumerics[random.Next(alphanumerics.Length)];
            }

            return (buffer, long_buffer);
        }
    }
}