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
        static void Main(string[] args)
        {
            //codeflame create-project name --host=192.168.0.0.1 --port=3306 --user=postgres --pass=postgrespw --dbname=EtecDB
            switch (args[0])
            {
                case "create-project":
                    string dirRootFolder = @"C:\codeflame\projects\" + args[1] + @"\";
                    string nameProject = args[1];

                    string host = (args.Length > 2) ? args[2].Substring(7, args[2].Length - 7) : "localhost";
                    string port = (args.Length > 3) ? args[3].Substring(7, args[3].Length - 7) : "3306";
                    string user = (args.Length > 4) ? args[4].Substring(7, args[4].Length - 7) : "codeflame";
                    string pass = (args.Length > 5) ? args[5].Substring(7, args[5].Length - 7) : "codeflamepw";
                    string dbname = (args.Length > 6) ? args[6].Substring(9, args[6].Length - 9) : "codeflamedb";

                    CreateProject cp = new CreateProject();
                    cp.createRootFolder(dirRootFolder, nameProject);
                break;
            }

            Console.ReadKey();
        }
    }
}
