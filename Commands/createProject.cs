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

        public void createRootFolder(string dirRootFolder, string nameProject)
        {
            if (!Directory.Exists(dirRootFolder))
            {
                Directory.CreateDirectory(dirRootFolder);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[V] Pasta do projeto {nameProject} criada com sucesso no diretório \"{dirRootFolder}\".");
            }
            else
            {
                Console.WriteLine("[X] Nome de projeto existente, porfavor escolha outro.");
            }
        }
    }
}
