using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using ODWai2.Misc.Classes;

namespace ODWai2.ODWaiCore
{
    class ScriptExecutor
    {
        private static string get_python_path()
        {
            string path = Configuration.get_python_path();
            if (path == null || !File.Exists(path)) { return null; }
            return path;
        }

        // DEPRICATED: janky, unstable, exit code wrongly returned
        public static int commandline_execute(string script_name, params (string, string)[] arguments)
        {
            string python_path = get_python_path();
            if (python_path == null) { return -1; }

            string cmd = CommandBuilder.command(CommandBuilder.ExecutionType.util, script_name, arguments);
            string command = python_path + " " + cmd;
            Process process = new Process();
            ProcessStartInfo info = new ProcessStartInfo("cmd", "/c " + command);
            process.StartInfo = info;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            if (process.WaitForExit(10000))
            {
                return process.ExitCode;
            }
            return 100;
        }

        // RECOMMENDED
        public static int python_execute(string script_name, int max_wait_time = 10, params (string, string)[] arguments)
        {
            string python_path = Configuration.get_python_path();
            if (python_path == null) { return -1; }

            string command = CommandBuilder.command(CommandBuilder.ExecutionType.util, script_name, arguments);
            ProcessStartInfo info = new ProcessStartInfo(python_path, command);
            Process process = new Process();
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo = info;
            process.Start();
            if (process.WaitForExit(max_wait_time * 1000))
            {
                return process.ExitCode;
            }
            return 100;
        }
    }
}
