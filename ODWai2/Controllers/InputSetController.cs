﻿using System;
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
                                  ref Func<string, (JArray, string)> delegated_get_input_set)
        {
            _input_set_repo = new InputSetRepository(ref delegated_get_input_sets,
                                                     ref delegated_delete_input_set,
                                                     ref delegated_get_input_set);
        }

        public void Delete(List<InputGroup> input_groups)
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

        public string Save(string name, List<InputGroup> input_groups)
        {
            List<FieldRule> fields = new List<FieldRule>();
            foreach (var group in input_groups)
            {
                FieldRule rule = FieldRule.new_field(group.field_.Text, group.associated_.Text, group.length_.Text, group.must_have_.Text, group.must_not_have_.Text);
                if (rule == null) return "Input set entries invalid";
                fields.Add(rule);
            }
            return _input_set_repo.add_input_set(name, fields);
        }
    }
}
