using System;
using System.IO;

namespace ODWai2.ODWaiCore.Controllers
{
    public class Helper
    {
        public static string LOG_PATH = @"../../Error log/";

        public static string get_path_argument(string raw_string)
        {
            return "\"" + raw_string.Replace("\\", "/") + "\"";
        }

        public static void log_error(string error)
        {
            Directory.CreateDirectory(LOG_PATH);
            File.WriteAllText(Path.GetFullPath(LOG_PATH) + "/" + DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss") + ".txt", error);
        }
    }
}
