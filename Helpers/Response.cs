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
        protected void sendMessage(string prefix, string msg, bool b)
        {
            string color = (b) ? "DarkGreen" : "DarkRed";
            SetColor c = new SetColor();
            c.setColor(color);

            Console.WriteLine($"{prefix} {msg}");

            c.resetColor();
        }
    }

    internal class existingProject : Response
    {
        public existingProject(string prefix, string msg, bool b)
        {
            base.sendMessage(prefix, msg, b);
        }
    }

    internal class projectCreated : Response
    {
        public projectCreated(string prefix, string msg, bool b)
        {
            base.sendMessage(prefix, msg, b);
        }
    }
}
