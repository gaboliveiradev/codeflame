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
        public void response(string prefix, string msg)
        {
            Console.WriteLine($"{prefix} {msg}");
        }

    }
}
