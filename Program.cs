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
        static void Main(string[] args) // codeflame create-project name
        {
            switch(args[0])
            {
                case "create-project":
                    string dirRootFolder = @"C:\codeflame\projects\" + args[1] + @"\";
                    string nameProject = args[1];

                    CreateProject cp = new CreateProject();
                    cp.createRootFolder(dirRootFolder, nameProject);
                break;
            }

            Console.ReadKey();
        }
    }
}
