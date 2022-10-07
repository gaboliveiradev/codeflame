using System;
using System.Collections.Generic;
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


            switch(args[0])
            {
                case "new-project":
                    newProject np = new newProject();
                    string nameProject = args[1];

                    np.create(nameProject);
                break;
            }

            Console.ReadKey();
        }
    }
}
