using System;
using System.IO;
using System.Linq;

namespace ODWai2.ODWaiCore.Controllers
{

    // TODO: chain start_training after generate_training_resources
    public class ODWaiTrainer
    {
        private static string BASE_TEMP_PATH = @"../../ODWaiCore/temp";
        private static string BASE_PIPELINE_PATH = @"../../ODWaiCore/temp/pipeline.config";
        private static string BASE_SLIM_PATH = @"../../ODWaiCore/Main/slim";

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
                File.WriteAllText(BASE_PIPELINE_PATH, config);
            }
            catch (Exception e)
            {
                return (1, e.Message);
            }

            try
            {
                string temp_path = Helper.get_path_argument(Path.GetFullPath(BASE_TEMP_PATH));
                string slim_path = Helper.get_path_argument(Path.GetFullPath(BASE_SLIM_PATH));
                data_set_path = Helper.get_path_argument(Path.GetFullPath(data_set_path));
                pipeline_path = Helper.get_path_argument(Path.GetFullPath(BASE_PIPELINE_PATH));
                Directory.CreateDirectory(BASE_TEMP_PATH);

                (int code, string output) = ScriptExecutor.python_execute(CommandBuilder.ExecutionType.main, "odwai_trainer.py",
                                                                          true, null, 0, false,
                                                                          ("logtostderr", ""),
                                                                          ("train_dir", temp_path),
                                                                          ("pipeline_config_path", pipeline_path),
                                                                          ("slim_path", slim_path));

                return (code, "Training process terminated, exit code: " + code);
            }
            catch (Exception e)
            {
                return (1, e.Message);
            }
        }

        public static (int, string) export_graph(string data_set_path, Action<string> update = null)
        {
            Directory.CreateDirectory(BASE_TEMP_PATH);
            string prefix = get_checkpoint_prefix();
            if (!Directory.Exists(Path.Combine(data_set_path, "graph"))) { return (1, "Data set path not found"); }
            if (!File.Exists(BASE_PIPELINE_PATH)) { return (1, "Pipeline config not found"); }
            if (!Directory.Exists(BASE_SLIM_PATH)) { return (1, "Slim path not found"); }
            if (prefix == null) { return (1, "Training checkpoints not found"); }

            update?.Invoke("Generating frozen inference graph from checkpoint: " + prefix.ToUpper());

            string slim_path = Helper.get_path_argument(Path.GetFullPath(BASE_SLIM_PATH));
            string pipeline_path = Helper.get_path_argument(Path.GetFullPath(BASE_PIPELINE_PATH));
            string prefix_path = Helper.get_path_argument(Path.Combine(Path.GetFullPath(BASE_TEMP_PATH), prefix));
            data_set_path = Helper.get_path_argument(Path.Combine(data_set_path, "graph"));

            return ScriptExecutor.python_execute(CommandBuilder.ExecutionType.main, "export_inference_graph.py",
                                                                      false, null, 60, true,
                                                                      ("pipeline_config_path", pipeline_path),
                                                                      ("trained_checkpoint_prefix", prefix_path),
                                                                      ("slim_path", slim_path),
                                                                      ("output_directory", data_set_path),
                                                                      ("input_type", "image_tensor"));
        }

        // TODO: to private
        public static string get_checkpoint_prefix()
        {
            if (!Directory.Exists(BASE_TEMP_PATH)) { return null; }

            string[] files = Directory.GetFiles(BASE_TEMP_PATH, "*.meta", SearchOption.TopDirectoryOnly);
            int[] step_info = files.Select(name => int.Parse(Path.GetFileName(name).Remove(0, 11).Replace(".meta", ""))).ToArray();
            if (step_info.Length <= 0) { return null; }
            return "model.ckpt-" + step_info.Max().ToString();
        }
    }
}
