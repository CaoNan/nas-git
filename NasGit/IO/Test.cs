using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NasGit.IO {
    class Test {
        public Test(){
            IO_Git.Git.OutputDataReceived += new IO_Git.OutputDelegate(OutputReceivedHandeler);
        }

        private void OutputReceivedHandeler(object sender, System.Diagnostics.DataReceivedEventArgs e) {
            Console.Write(e.Data);
        }
    }
}
