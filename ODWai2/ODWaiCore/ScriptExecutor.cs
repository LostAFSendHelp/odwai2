using System;
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
        public static (int, string) python_execute(CommandBuilder.ExecutionType exe_type,
                                        string script_name,
                                        bool show_console,
                                        Action completion,
                                        int max_wait_time,
                                        bool redirect_error,
                                        params (string, string)[] arguments)
        {
            string python_path = Configuration.get_python_path();
            if (python_path == null) { return (-1, "Invalid python path"); }
            string command = CommandBuilder.command(exe_type, script_name, arguments);

            ProcessStartInfo info = new ProcessStartInfo(python_path, command);
            info.CreateNoWindow = !show_console;
            info.WindowStyle = show_console ? ProcessWindowStyle.Normal : ProcessWindowStyle.Hidden;
            info.RedirectStandardError = redirect_error;
            info.UseShellExecute = !redirect_error;

            Process process = new Process();
            process.StartInfo = info;
            process.StartInfo.Verb = "runas";
            process.Start();

            string output = redirect_error ? process.StandardError.ReadToEnd() : null;

            if (max_wait_time != 0)
            {
                if (process.WaitForExit(max_wait_time * 1000))
                {
                    return (process.ExitCode, output);
                }
            }
            else
            {
                process.WaitForExit();
                return (process.ExitCode, output);
            }
            
            return (100, null);
        }
    }
}
