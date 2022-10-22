using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeflame.Helpers
{
    abstract class Response
    {
        protected void sendMessage(string prefix, string msg)
        {
            Console.WriteLine($"{prefix} {msg}");
        }
    }

    internal class existingProject : Response
    {
        public existingProject(string prefix, string msg)
        {
            base.sendMessage(prefix, msg);
        }
    }

    internal class projectCreated : Response
    {
        public projectCreated(string prefix, string msg)
        {
            base.sendMessage(prefix, msg);
        }
    }
}
