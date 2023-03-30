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

            switch (args[0])
            {
                // [Exemplo de CMD] codeflame add/project-mvc EcommerceSite
                case "add/project-mvc":
                    string projectName = args[1];
                    string rootDirectory = @"C:\codeflame\repos\" + projectName + @"\App";

                    newProject.createRootDirectory(projectName, rootDirectory);
                    break;

                // [Exemplo de CMD] codeflame make:controller UsuarioController
                case "make:controller":
                    string nameController = args[1];
                    makeLayer.createController(nameController);

                    killProcess();
                    break;

                // [Exemplo de CMD] codeflame make:model UsuarioModel
                case "make:model":
                    string nameModel = args[1];
                    makeLayer.createModel(nameModel);

                    killProcess();
                    break;


                // [Exemplo de CMD] codeflame make:dao UsuarioDAO
                case "make:dao":
                    string nameDAO = args[1];
                    makeLayer.createDAO(nameDAO);

                    killProcess();
                    break;

                case "list":
                    new SetColor().setColor("DarkMagenta");
                    Console.WriteLine("   _____                                           _               \r\n  / ____|                                         | |              \r\n | |        ___    _ __ ___     __ _   _ __     __| |   ___    ___ \r\n | |       / _ \\  | '_ ` _ \\   / _` | | '_ \\   / _` |  / _ \\  / __|\r\n | |____  | (_) | | | | | | | | (_| | | | | | | (_| | | (_) | \\__ \\\r\n  \\_____|  \\___/  |_| |_| |_|  \\__,_| |_| |_|  \\__,_|  \\___/  |___/");
                    Console.WriteLine("");
                    new SetColor().setColor("Magenta");
                    Console.WriteLine("");
                    Console.WriteLine("codeflame add/project-mvc nome_projeto = Crie um projeto MVC em segundos.");
                    Console.WriteLine("codeflame make:controller nome_controller = Crie um arquivo controller com todos os metodos pre-setados.");
                    Console.WriteLine("codeflame make:model nome_model = Crie um arquivo model com todos os metodos pre-setados.");
                    Console.WriteLine("codeflame make:dao nome_dao = Crie um arquivo dao com todos os metodos pre-setados.");
                    Console.WriteLine("codeflame list = Liste todos os comandos disponíveis no codeflame.");
                    new SetColor().resetColor();

                    killProcess();
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
