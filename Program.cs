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
            NewProject newProject = new NewProject();
            MakeLayer makeLayer = new MakeLayer();

            switch (args[0])
            {
                case "new-project":
                    string projectName = args[1];
                    string rootDirectory = @"C:\codeflame\repos\" + projectName + @"\App";

                    newProject.createRootDirectory(projectName, rootDirectory);
                    break;

                case "make:controller":
                    string nameController = args[1];
                    makeLayer.createController(nameController);
                    break;


                case "make:model":
                    string nameModel = args[1];
                    makeLayer.createModel(nameModel);
                    break;


                case "make:dao":
                    string nameDAO = args[1];
                    makeLayer.createDAO(nameDAO);
                    break;
            }

            Console.ReadKey();
        }
    }
}
