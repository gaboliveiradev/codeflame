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

        public void createRootFolder(string dirRootFolder, string nameProject)
        {
            this.dirRootFolder = dirRootFolder;

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
                @"App\View\Modules", @"App\View\Includes"
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
                    Console.WriteLine($"[V] Pasta [{folder}] criada com sucesso.");
                } catch (Exception)
                {
                    ct.setRed();
                    Console.WriteLine($"[X] Ocorreu um erro na criação da pasta {folder}.");                
                }
            }
        }
    }
}
