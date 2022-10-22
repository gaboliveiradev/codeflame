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
                    NewProject newProject = new NewProject();

                    string projectName = args[1];
                    string rootDirectory = @"C:\codeflame\projects\" + projectName + @"\";

                    newProject.createRootDirectory(projectName, rootDirectory);
                break;
            }

            Console.ReadKey();
        }
    }
}
