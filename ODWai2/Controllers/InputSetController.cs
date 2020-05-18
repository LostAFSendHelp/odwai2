/*
    Class for handling Field Rules and Field Tests, collectively known as input sets
*/

using System;
using System.Data;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using ODWai2.DAOs;
using ODWai2.Misc.Views;
using ODWai2.ODWaiCore.Models;
using ODWai2.Misc.Classes;

namespace ODWai2.Controllers
{
    public class InputSetController
    {
        private InputSetRepository _input_set_repo;

        public InputSetController(NewInputSetView newInputSetView,
                                  ref Func<DataTable> delegated_get_input_sets,
                                  ref Func<string, string> delegated_delete_input_set,
                                  ref Func<string, (JArray, string)> delegated_get_input_set,
                                  ref Func<string, string> delegated_generate_test_cases)
        {
            _input_set_repo = new InputSetRepository(ref delegated_get_input_sets,
                                                     ref delegated_delete_input_set,
                                                     ref delegated_get_input_set);
            delegated_generate_test_cases = (path) => { return _input_set_repo.generate_test_cases(path); };
        }

        public void delete_field_rules(List<InputGroup> input_groups)
        {
            foreach (var group in input_groups)
            {
                if (group.crr_.Checked == true)
                {
                    group.arr_.Dispose();
                    input_groups.Remove(group);
                }
            }
        }

        public string save_field_rules(string name, List<InputGroup> input_groups)
        {
            List<FieldRule> fields = new List<FieldRule>();
            bool can_fallback = true;
            foreach (var group in input_groups)
            {
                FieldRule rule = FieldRule.new_field(group.field_.Text, group.associated_.Text, group.length_.Text, group.must_have_.Text, group.must_not_have_.Text, ref can_fallback);
                if (rule == null) return "Input set entries invalid. Please check your rules.\n"
                                           + "The error can be due to a logical conflict or there being "
                                           + "more than 1 fallback field (field with no associated texts)";
                fields.Add(rule);
            }
            return _input_set_repo.add_input_set(name, fields);
        }
    }
}
