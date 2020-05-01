/*
    Class for parsing text input to Fields, which are then used to generate Rules, and subsequently Testcases
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace ODWai2.ODWaiCore.Models
{
    public class FieldRule
    {
        public string field_name;
        public List<string> associated;
        public int min;
        public int max;
        public List<char> must_not_have; // invalid chars, also determines rejects_alphabet
        public bool forces_uppercase;
        public bool forces_lowercase;
        public bool forces_numbers; // must not contradict rejects_number
        public bool rejects_alphabets; // must not contradict forces_uppercase || forces_lowercase
        public bool rejects_numbers;

        public static FieldRule new_field(string _name, string _associated, string _length, string _must_have, string _must_not_have)
        {
            bool __rejects_alphabets = false, __rejects_numbers = false,
                __forces_lowercase = false, __forces_uppercase = false, __forces_numbers = false;
            // TODO: Check for associated
            List<string> __associated = _associated.Split(',').Select(text => text.Trim()).ToList();
            // TODO: Check for min max
            List<int> __length = _length.Split(',').Select(text => { return int.Parse(text.Trim()); }).ToList();
            int __min = __length[0], __max = __length[1];

            // check for boolean contradictions, boolean - length contradiction

            /*  MUST NOT:
                a letter means no alphabet
                a number means no number
                a non-alphanumeric is added specifically
            */
            List<char> __excluded = new List<char>();
            foreach (char character in _must_not_have)
            {
                if (Char.IsLetter(character)) { __rejects_alphabets = true; continue; }
                if (Char.IsNumber(character)) { __rejects_numbers = true; continue; }
                __excluded.Add(character);
            }

            /* MUST: 
                an upper(lower)cased means at least 1 upper(lower)case
                a number means at least 1 number
            */
            foreach (char character in _must_have)
            {
                if (Char.IsUpper(character)) { __forces_uppercase = true; continue; }
                if (Char.IsLower(character)) { __forces_lowercase = true; continue; }
                if (Char.IsNumber(character)) { __forces_numbers = true; }
            }

            // check for rule conflicts
            if (__forces_numbers && __rejects_numbers) { return null; }
            if ((__forces_lowercase || __forces_uppercase) && __rejects_alphabets) { return null; }
            if (__rejects_numbers && __rejects_alphabets) { return null; }

            // check for length conflict
            int required = 0;
            if (__forces_lowercase) { ++required; }
            if (__forces_uppercase) { ++required; }
            if (__forces_numbers) { ++required; }
            if (required > __min) { return null; }

            return new FieldRule() {
                field_name = _name,
                associated = __associated,
                min = __min,
                max = __max,
                must_not_have = __excluded,
                forces_uppercase = __forces_uppercase,
                forces_lowercase = __forces_lowercase,
                forces_numbers = __forces_numbers,
                rejects_alphabets = __rejects_alphabets,
                rejects_numbers = __rejects_numbers
            };
        }

        public static (List<FieldRule>, string) from_path(string path)
        {
            if (!File.Exists(path)) { return (null, "Input set not found"); }
            string raw_json = File.ReadAllText(path);
            List<FieldRule> rules = JsonConvert.DeserializeObject<List<FieldRule>>(raw_json);
            rules = rules.Where(rule => rule.check_conflicts()).ToList();
            if (rules.Count <= 0) { return (null, "Error parsing inputset"); }
            return (rules, null);
        }

        private bool check_conflicts()
        {
            if (forces_numbers && rejects_numbers) { return false; }
            if ((forces_lowercase || forces_uppercase) && rejects_alphabets) { return false; }
            if (rejects_numbers && rejects_alphabets) { return false; }
            return true;
        } 
    }
}
