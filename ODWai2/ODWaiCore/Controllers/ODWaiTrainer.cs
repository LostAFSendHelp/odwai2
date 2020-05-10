using System;
using System.IO;

namespace ODWai2.ODWaiCore.Controllers
{
    // TODO: chain start_training after generate_training_resources
    public class ODWaiTrainer
    {
        public static (int, string) generate_training_resources(string data_set_path, Action<string> update = null)
        {
            update?.Invoke("Generating CVs");
            (int xml_to_csv, string output_csv) = ScriptExecutor.python_execute(CommandBuilder.ExecutionType.util,
                                                                                "xml_to_csv.py", false, null, 5, true,
                                                                                ("path", Helper.get_path_argument(data_set_path)));
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
                (int generate_records, string output_records) = ScriptExecutor.python_execute(CommandBuilder.ExecutionType.util,
                                                                                              "generate_tf_records.py", false, null, 60, true,
                                                                                              ("path", Helper.get_path_argument(data_set_path)));
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

        public static (int, string) start_training(string data_set_path)
        {
            string pipeline_path = @"../../ODWaiCore/temp/pipeline.config";
            try
            {
                string resource_path = Path.GetFullPath(@"../../ODWaiCore/Main/training resources/");
                string config_template = File.ReadAllText(Path.Combine(resource_path, "faster_rcnn_inception_v2.config"));
                int count = Directory.GetFiles(Path.Combine(data_set_path, "test"), "*", SearchOption.TopDirectoryOnly).Length / 2;
                string config = config_template.Replace("<train_record_path>", Helper.get_path_argument(Path.Combine(data_set_path, "training resources", "train.record")))
                                               .Replace("<test_record_path>", Helper.get_path_argument(Path.Combine(data_set_path, "training resources", "test.record")))
                                               .Replace("<label_map_path>", Helper.get_path_argument(Path.Combine(resource_path, "labelmap.pbtxt")))
                                               .Replace("<finetune_checkpoint_path>", Helper.get_path_argument(Path.Combine(resource_path, "faster_rcnn_inception_v2_coco_2018_01_28", "model.ckpt")))
                                               .Replace("<test_count>", count.ToString());
                File.WriteAllText(pipeline_path, config);
            }
            catch (Exception e)
            {
                return (1, e.Message);
            }

            string train_path = @"../../ODWaiCore/temp";
            Directory.CreateDirectory(train_path);
            ScriptExecutor.python_execute(CommandBuilder.ExecutionType.main, "odwai_trainer.py", true,
                                          null, 0, false,
                                          ("logtostderr", ""),
                                          ("train_dir", Helper.get_path_argument(Path.GetFullPath(train_path))),
                                          ("pipeline_config_path", Helper.get_path_argument(Path.GetFullPath(pipeline_path))));
            return (0, null);
        }
    }
}
