﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using codeflame.Helpers;

namespace codeflame.Commands
{
    public class CreateProject
    {
        ColorText ct = new ColorText();
        public string dirRootFolder;
        public string[] infoConnection = new string[5];
        public void createRootFolder(string dirRootFolder, string nameProject, string[] infoConnection)
        {
            ct.setDarkYellow();
            string title = @"
                                                                            
                 ██████╗ ██████╗ ██████╗ ███████╗███████╗██╗      █████╗ ███╗   ███╗███████╗
                ██╔════╝██╔═══██╗██╔══██╗██╔════╝██╔════╝██║     ██╔══██╗████╗ ████║██╔════╝
                ██║     ██║   ██║██║  ██║█████╗  █████╗  ██║     ███████║██╔████╔██║█████╗  
                ██║     ██║   ██║██║  ██║██╔══╝  ██╔══╝  ██║     ██╔══██║██║╚██╔╝██║██╔══╝  
                ╚██████╗╚██████╔╝██████╔╝███████╗██║     ███████╗██║  ██║██║ ╚═╝ ██║███████╗
                 ╚═════╝ ╚═════╝ ╚═════╝ ╚══════╝╚═╝     ╚══════╝╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝
                                                                            
            ";
            Console.WriteLine(title);

            this.dirRootFolder = dirRootFolder;
            for (int i = 0; i < infoConnection.Length; i++) this.infoConnection[i] = infoConnection[i];

            if (!Directory.Exists(dirRootFolder))
            {
                Directory.CreateDirectory(dirRootFolder);

                ct.setGray();
                Console.WriteLine($"[V] - Pasta do projeto \"{nameProject}\" criada com sucesso. Diretório: \"{dirRootFolder}\".");
                Console.WriteLine();
                createSubFolders();
            }
            else
            {
                ct.setRed();
                Console.WriteLine("[X] Nome de projeto existente, porfavor escolha outro.");
                Console.WriteLine(">>> Pressione qualquer tecla para continuar...");
                Console.WriteLine();
            }
        }

        public async void createSubFolders()
        {
            string[] folders = {
                "App", "Database", 
                @"App\Model", @"App\Controller", @"App\DAO", 
                @"App\View\Modules", @"App\View\Modules\Welcome", @"App\View\Includes\Bootstrap", @"App\View\CSS", @"App\View\Assets"
            };

            ct.setBlue();
            Console.WriteLine("-> Criando Pastas Necessárias...");
            Console.WriteLine();
            await Task.Delay(3000);

            foreach(string folder in folders)
            {
                try
                {
                    Directory.CreateDirectory(dirRootFolder + folder);
                    ct.setDarkCyan();
                    Console.WriteLine($"[V] - Pasta [{folder}] criada com sucesso.");
                } catch (Exception)
                {
                    ct.setRed();
                    Console.WriteLine($"[X] Ocorreu um erro na criação da pasta {folder}.");
                    Console.WriteLine(">>> Pressione qualquer tecla para continuar...");
                }
            }

            createAndWriteFilesInSubFolders();
        }

        public async void createAndWriteFilesInSubFolders()
        {
            string[] files = {
                @"App\index.php", @"App\rotas.php", @"App\config.php", @"App\autoload.php",
                @"App\Controller\Controller.php", @"App\Controller\WelcomeController.php", @"App\Model\Model.php", @"App\DAO\DAO.php",
                @"App\View\Includes\Bootstrap\css_config.php", @"App\View\Includes\Bootstrap\js_config.php", @"App\View\Includes\header.php",
                @"App\View\Modules\Welcome\Welcome.php",
            };

            ct.setBlue();
            Console.WriteLine();
            Console.WriteLine("-> Criando Arquivos Necessários...");
            Console.WriteLine();
            await Task.Delay(3000);

            foreach (string file in files)
            {
                try
                {
                    WriteFile wf = new WriteFile();
                    wf.createAndWriteFile(dirRootFolder, file, infoConnection);
                } catch (Exception)
                {
                    ct.setRed();
                    Console.WriteLine($"[X] Ocorreu um erro na criação e build do arquivo {file}.");
                    Console.WriteLine(">>> Pressione qualquer tecla para continuar...");
                }
            }

            Console.WriteLine("");
            ct.setGreen();
            Console.WriteLine("[->] - Projeto Criado com Sucesso!");
            Console.WriteLine($"[->] - Diretório do Projeto: {dirRootFolder}");
            Console.WriteLine("");
            ct.setDarkYellow();
            Console.WriteLine("-> Dados de Conexão com o Banco de Dados <-");
            Console.WriteLine("-> Atenção: Para alterar esses dados acesse " + dirRootFolder + @"App\config.php");
            ct.setYellow();
            Console.WriteLine($"-> Host: {infoConnection[0]}");
            Console.WriteLine($"-> Port: {infoConnection[1]}");
            Console.WriteLine($"-> User: {infoConnection[2]}");
            Console.WriteLine($"-> pass: {infoConnection[3]}");
        }
    }
}
