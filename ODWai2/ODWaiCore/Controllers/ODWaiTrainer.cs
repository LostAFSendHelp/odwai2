using System;

namespace ODWai2.ODWaiCore.Controllers
{
    public class ODWaiTrainer
    {
        public static (int, string) generate_training_resources(string data_set_path, Action<string> update = null)
        {
            if (update != null) { update.Invoke("Generating CVs"); }
            (int xml_to_csv, string output_csv) = ScriptExecutor.python_execute(CommandBuilder.ExecutionType.util, "xml_to_csv.py", false, null, 5, true, ("path", Helper.get_path_argument(data_set_path)));
            switch (xml_to_csv)
            {
                case 98:
                case 99:
                    return (xml_to_csv, output_csv);
                case 1:
                    return (91, output_csv);
                case 0:
                    return generate_tf_records();
                default:
                    return (1, output_csv);
            }

            (int, string) generate_tf_records()
            {
                if (update != null) { update.Invoke("Generating Tensorflow Records from CVs"); }
                (int generate_records, string output_records) = ScriptExecutor.python_execute(CommandBuilder.ExecutionType.util, "generate_tf_records.py", false, null, 60, true, ("path", Helper.get_path_argument(data_set_path)));
                switch (generate_records)
                {
                    case 0:
                    case 88:
                    case 89:
                        return (generate_records, null);
                    case 1:
                        return (81, output_records);
                    default:
                        return (2, output_records);
                }
            }
        }
    }
}
