using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ODWai2.ODWaiCore
{
    class ScriptExecutor
    {
        private string _python_path = @"D:/coderepos/pythonrepos/tfenv/python.exe";
        private string _dummy_path = @"D:/tensorflow/models/research/object_detection/Object_detection_image.py";
        private Process process;
        public ScriptExecutor()
        {
            process = new Process();
        }

        public int commandline_execute(string script_name, params (string, string)[] arguments)
        {
            string cmd = CommandBuilder.shared().command(CommandBuilder.ExecutionType.util, script_name, arguments);
            string command = _python_path + " " + cmd;
            ProcessStartInfo info = new ProcessStartInfo("cmd", "/c " + command);
            process.StartInfo = info;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            if (process.WaitForExit(5000))
            {
                return process.ExitCode;
            }
            return 100;
        }

        public int python_execute(string script_name, params (string, string)[] arguments)
        {
            string command = CommandBuilder.shared().command(CommandBuilder.ExecutionType.util, script_name, arguments);
            ProcessStartInfo info = new ProcessStartInfo(_python_path, command);
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo = info;
            process.Start();
            if (process.WaitForExit(5000))
            {
                return process.ExitCode;
            }
            return 100;
        }
    }
}
