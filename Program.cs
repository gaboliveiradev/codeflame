using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using codeflame.Commands;

namespace codeflame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            switch (args[0])
            {
                case "new-project":
                    string dirRootFolder = @"C:\codeflame\projects\" + args[1] + @"\";
                    string nameProject = args[1];

                break;
            }

            Console.ReadKey();
        }
    }
}
