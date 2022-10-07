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
        static void Main(string[] args) // codeflame new-project name
        {
            /*switch(args[0])
            {
                case "new-project":
                    string dirProject = @"C:\codeflame\projects\" + args[1];
                    string nameProject = args[1];

                    if (!Directory.Exists(dirProject))
                    {
                        Directory.CreateDirectory(dirProject);
                        Console.WriteLine($"[✔] Pasta do projeto {nameProject} criada com sucesso no diretório \"{dirProject}\".");
                    } else
                    {
                        Console.WriteLine("[✖] Nome de projeto existente, porfavor escolha outro.");
                    }
                break;
            }*/

            Console.ReadKey();
        }
    }
}
