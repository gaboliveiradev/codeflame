using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace codeflame.Helpers
{
    public class WriteFiles
    {
        ColorText ct = new ColorText();

        public void writeFiles(string host, string port, string user, string pass, string dbname)
        {
            ct.setGray();
            Console.WriteLine();
            Console.WriteLine("-> Buildando o arquivo [index.php]...");
            Console.WriteLine();
        }
    }
}
