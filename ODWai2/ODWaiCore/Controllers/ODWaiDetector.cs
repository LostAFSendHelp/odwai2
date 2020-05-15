using System;
using System.IO;

namespace ODWai2.ODWaiCore.Controllers
{
    public class ODWaiDetector
    {
        private static string LABEL_MAP = Path.GetFullPath(@"../../ODWaiCore/Main/training resources/labelmap.pbtxt");
        public static (int, string) start_detection(string graph_path,
                                           string root_x,
                                           string root_y,
                                           string width,
                                           string height,
                                           Action start = null,
                                           Action completion = null)
        {
            if (!File.Exists(graph_path)) { return (79, null); }
            start?.Invoke();
            (int code, string output) = ScriptExecutor.python_execute(CommandBuilder.ExecutionType.main,
                                         "odwai_detector.py", false, completion, 60, true,
                                         ("graph_path", Helper.get_path_argument(graph_path)),
                                         ("root_x", root_x), ("root_y", root_y),
                                         ("width", width),
                                         ("height", height),
                                         ("labelmap", Helper.get_path_argument(LABEL_MAP)));
            completion?.Invoke();
            switch (code)
            {
                case 1:
                    return (71, output);
                case 0:
                case 100:
                    return (code, null);
                default:
                    return (1, output);
            }
        }
    }
}