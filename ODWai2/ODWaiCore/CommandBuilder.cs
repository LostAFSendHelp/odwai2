using System.IO;

namespace ODWai2.ODWaiCore
{
    public class CommandBuilder
    {
        public enum ExecutionType
        {
            main = 0,
            util = 1
        }

        private static string _base_path = Path.GetFullPath("../../ODWaiCore/");

        public static string command(ExecutionType type, string script_name, params (string, string)[] arguments)
        {
            string script_path = _base_path.Replace("\\", "/") + sub_path(type) + script_name;
            if (!File.Exists(script_path)) return null;

            string command = script_path;
            foreach ((string key, string value) pair in arguments)
            {
                if (pair.key.Length > 0)
                {
                    command += (" --" + pair.key + " " + pair.value);
                }
            }

            return command;
        }

        private static string sub_path(ExecutionType type)
        {
            switch (type)
            {
                case ExecutionType.main:
                    return "Main/";
                case ExecutionType.util:
                    return "Utilities/";
                default:
                    return "";
            }
        }
    }
}
