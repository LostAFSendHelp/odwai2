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
        private Process process;
        public ScriptExecutor()
        {
            process = new Process();
        }

        public void dummy_func()
        {
            ProcessStartInfo info = new ProcessStartInfo("C:/Users/PC/Desktop/script.bat");
            process.StartInfo = info;
            process.Start();
        }
    }
}
