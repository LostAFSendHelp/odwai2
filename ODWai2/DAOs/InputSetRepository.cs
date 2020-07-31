using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ODWai2.ODWaiCore.Controllers;
using ODWai2.ODWaiCore.Models;

namespace ODWai2.DAOs
{
    class InputSetRepository
    {
        public InputSetRepository(ref Func<DataTable> delegated_get_input_sets,
                                  ref Func<string, string> delegated_delete_input_set,
                                  ref Func<string, (JArray, string)> delegated_get_input_set)
        {
            Directory.CreateDirectory(Helper.INPUT_SET_PATH);
            Directory.CreateDirectory(Helper.TEST_CASE_PATH);
            delegated_get_input_sets = () => { return get_input_sets(); };
            delegated_delete_input_set = (path) => { return delete_input_set(path); };
            delegated_get_input_set = (path) => { return get_input_set(path); };
        }

        public string get_name_json(ComboBox combobox)
        {
            
            DataRow selectedDataRow = ((DataRowView)combobox.SelectedItem).Row; // doc file name : a1.json
            string select = selectedDataRow["File Name"].ToString();// doc file name : a1.json

            return select;
        }
        public string get_path_json(ComboBox comboBox)
        {
            string destPath = Path.Combine(Helper.INPUT_SET_PATH, get_name_json(comboBox));
            return destPath;
        }

        public (JArray, string) get_input_set(string path)
        {
            try
            {
                string Json = File.ReadAllText(path);
                var data = JArray.Parse(Json);
                return (data, null);
            }
            catch (Exception e)
            {
                return (null, e.Message);
            }
        }

        private DataTable get_input_sets()
        {
            string[] files = Directory.GetFiles(Helper.INPUT_SET_PATH, "*.json", SearchOption.TopDirectoryOnly);
            DataTable data_table = new DataTable();
            data_table.Columns.Add("File name");
            data_table.Columns.Add("File path");
            foreach (string file in files)
            {
                FileInfo file_info = new FileInfo(file);
                data_table.Rows.Add(file_info.Name, file_info.FullName);
            }

            return data_table;
        }

        private string delete_input_set(string path)
        {
            try
            {
                string full_path = Path.GetFullPath(path);
                File.Delete(path);
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string add_input_set(string name, List<FieldRule> input_set)
        {
            try
            {
                string full_name = Path.Combine(Helper.INPUT_SET_PATH, name + ".json");
                if (File.Exists(full_name)) { return "Input set name already taken"; }

                StreamWriter writer = new StreamWriter(full_name);
                writer.Write(JsonConvert.SerializeObject(input_set, Formatting.Indented));
                writer.Close();
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public (string, bool) generate_test_cases(string from_path)
        {
            (List<FieldRule> rules, string error) = FieldRule.from_path(from_path);
            if (rules == null) { return (error, false); }

            List<FieldTest> tests = new List<FieldTest>();
            bool contains_fallback = false;
            foreach(var rule in rules)
            {
                tests.Add(FieldTest.from_rule(rule));
                if (rule.field_name.Contains("<fallback>")) { contains_fallback = true; }
            }

            try
            {
                string full_name = Helper.TEST_CASE_PATH + "testcases.json";
                if (Directory.Exists(full_name)) { return ("Input set name already taken", false); }

                StreamWriter writer = new StreamWriter(full_name);
                writer.Write(JsonConvert.SerializeObject(tests, Formatting.Indented));
                writer.Close();
                return (null, contains_fallback);
            }
            catch (Exception e)
            {
                return (e.Message, false);
            }
        }
    }
}
