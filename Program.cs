﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

                    Console.WriteLine("");
                    Process.GetCurrentProcess().Kill();
                    break;

                // [Exemplo de CMD] codeflame make:model UsuarioModel
                case "make:model":
                    string nameModel = args[1];
                    makeLayer.createModel(nameModel);

                    Console.WriteLine("");
                    Process.GetCurrentProcess().Kill();
                    break;


                // [Exemplo de CMD] codeflame make:dao UsuarioDAO
                case "make:dao":
                    string nameDAO = args[1];
                    makeLayer.createDAO(nameDAO);

                    Console.WriteLine("");
                    Process.GetCurrentProcess().Kill();
                    break;
            }

            Console.ReadKey();
        }
    }
}
