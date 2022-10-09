using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeflame.Helpers
{
    public class OpenProject
    {
        ColorText ct = new ColorText();
        public async void openProject(string dirRootFolder)
        {
            string pathFolder = dirRootFolder + "App";

            ct.setRed();
            Console.WriteLine("Atenção: Caso apareça como deseja abrir, selecione \"Visual Studio Code\".");
            await Task.Delay(2000);
            ct.setYellow();
            Console.WriteLine(">>> Navegando até o diretório do seu projeto...");
            await Task.Delay(3000);
            Console.WriteLine(">>> Abrindo Visual Studio Code...");
            await Task.Delay(3000);
            Process.Start("cmd.exe", $"/C cd {pathFolder} && code .");
            Console.WriteLine(">>> Iniciando o nosso servidor localhost...");
            Process.Start("cmd.exe", $"/C cd {pathFolder} && php -S localhost:8000");
            await Task.Delay(3000);
            Console.WriteLine(">>> Abrindo o navegador padrão em [http://localhost:8000]...");
            await Task.Delay(3000);
            Process.Start("cmd.exe", $"/C start http://localhost:8000");
            ct.setDarkYellow();
            Console.WriteLine("");
            Console.WriteLine("Obrigado por utilizar CodeFlame :)");
            ct.setGray();
        }

    }
}
