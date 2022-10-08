using System;
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
            this.dirRootFolder = dirRootFolder;
            for (int i = 0; i < infoConnection.Length; i++) this.infoConnection[i] = infoConnection[i];

            if (!Directory.Exists(dirRootFolder))
            {
                Directory.CreateDirectory(dirRootFolder);

                ct.setGreen();
                Console.WriteLine($"[V] Pasta do projeto \"{nameProject}\" criada com sucesso. Diretório: \"{dirRootFolder}\".");
                Console.WriteLine();
                createSubFolders();
            }
            else
            {
                ct.setRed();
                Console.WriteLine("[X] Nome de projeto existente, porfavor escolha outro.");
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

            ct.setGray();
            Console.WriteLine("-> Criando Pastas Necessárias...");
            Console.WriteLine();
            await Task.Delay(3000);

            foreach(string folder in folders)
            {
                try
                {
                    Directory.CreateDirectory(dirRootFolder + folder);
                    ct.setGray();
                    Console.WriteLine($"[V] - Pasta [{folder}] criada com sucesso.");
                } catch (Exception)
                {
                    ct.setRed();
                    Console.WriteLine($"[X] Ocorreu um erro na criação da pasta {folder}.");                
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

            ct.setGray();
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
                }
            }
        }
    }
}
