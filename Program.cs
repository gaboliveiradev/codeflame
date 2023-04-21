using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using codeflame.Commands;
using codeflame.Helpers;
using codeflame.Response;

namespace codeflame
{
    internal class Program
    {
        static void killProcess()
        {
            Console.WriteLine("");
            Process.GetCurrentProcess().Kill();
        }

        static void Main(string[] args)
        {
            NewProject newProject = new NewProject();
            MakeLayer makeLayer = new MakeLayer();
            Error err = new Error();

            string projectName = "";
            string rootDirectory = "";

            switch (args[0])
            {
                // [Exemplo de CMD] codeflame add/project-mvc EcommerceSite || cf add/project-mvc EcommerceSite
                // [Exemplo de CMD] codeflame add/mvc EcommerceSite || cf add/mvc EcommerceSite
                // [Exemplo de CMD] codeflame mvc EcommerceSite || cf mvc EcommerceSite
                case "add/project-mvc":
                case "add-project-mvc":
                case "add/mvc":
                case "project-mvc":
                case "project/mvc":
                case "new-project/mvc":
                case "new/mvc":
                case "mvc":
                    projectName = args[1];
                    rootDirectory = @"C:\codeflame\repos\" + projectName + @"\App";

                    newProject.createRootDirectory(projectName, rootDirectory);
                    break;

                // [Exemplo de CMD] codeflame make:controller UsuarioController
                case "make:controller":
                case "m:controller":
                case "m:c":
                    string nameController = (args[1].Length <= 10) ? args[1] + "Controller" : (args[1].Substring(args[1].Length - 10) == "Controller") ? args[1] : $"{args[1]}Controller";
                    makeLayer.createController(nameController);

                    killProcess();
                    break;

                // [Exemplo de CMD] codeflame make:model UsuarioModel
                case "make:model":
                case "m:model":
                case "m:m":
                    string nameModel = (args[1].Length <= 5) ? args[1] + "Model" : (args[1].Substring(args[1].Length - 5) == "Model") ? args[1] : $"{args[1]}Model";
                    makeLayer.createModel(nameModel);

                    killProcess();
                    break;


                // [Exemplo de CMD] codeflame make:dao UsuarioDAO
                case "make:dao":
                case "m:dao":
                case "m:d":
                    string nameDAO = (args[1].Length <= 3) ? args[1] + "DAO" : (args[1].Substring(args[1].Length - 3) == "DAO") ? args[1] : $"{args[1]}DAO";
                    makeLayer.createDAO(nameDAO);

                    killProcess();
                    break;

                case "list":
                case "cmd":
                case "commands":
                    new SetColor().setColor("Green");
                    Console.WriteLine("==========================+==========================");
                    Console.WriteLine("Acesse https://codeflame.online/commands-documentation");
                    Console.WriteLine("==========================+==========================");
                    new SetColor().resetColor();

                    killProcess();
                    break;

                case "--version":
                case "--v":
                    Console.WriteLine("v1.2.0-beta");
                    break;

                default:
                    new cmdInvalid(err.prefix, err.msg_cmd_invalid);
                    killProcess();
                    break;
            }

            Console.ReadKey();
        }
    }
}
