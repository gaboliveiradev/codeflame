using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace codeflame.Helpers
{
    public class WriteFile
    {

        public void createAndWriteFile(string dirRootFolder, string file)
        {
            StreamWriter sw;
            ColorText ct = new ColorText();

            switch(file)
            {
                case @"App\index.php":
                    sw = File.CreateText(dirRootFolder + file);

                    sw.WriteLine("<?php");
                    sw.WriteLine("    session_start();");
                    sw.WriteLine("");
                    sw.WriteLine("    include \"./config.php\";");
                    sw.WriteLine("    include \"./autoload.php\";");
                    sw.WriteLine("    include \"./rotas.php\";");

                    sw.Close();

                    ct.setGray();
                    Console.WriteLine($"[V] - Arquivo [{file}] criado e buildado com sucesso.");
                    break;

                case @"App\config.php":


                    break;
            }

        }
    }
}
