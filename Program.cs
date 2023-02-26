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
                // [Exemplo de CMD] codeflame add/project --name=EcommerceSite
                case "add/project":
                    string projectName = args[1].Remove(0, 7);
                    string rootDirectory = @"C:\codeflame\repos\" + projectName + @"\App";

                    newProject.createRootDirectory(projectName, rootDirectory);
                    break;

                // [Exemplo de CMD] codeflame make:controller --controller=UsuarioController
                case "make:controller":
                    string nameController = args[1].Remove(0, 13);
                    makeLayer.createController(nameController);
                    break;

                // [Exemplo de CMD] codeflame make:model --model=UsuarioModel
                case "make:model":
                    string nameModel = args[1];
                    makeLayer.createModel(nameModel);
                    break;


                // [Exemplo de CMD] codeflame make:dao --dao=UsuarioDAO
                case "make:dao":
                    string nameDAO = args[1];
                    makeLayer.createDAO(nameDAO);
                    break;
            }

            Console.ReadKey();
        }
    }
}
