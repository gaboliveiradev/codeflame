using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace codeflame.Helpers
{
    public class ChangeName
    {
        public string c = "class NOME_CONTROLLER extends Controller {";

        public string[] controller(string baseDirectory, string name)
        {
            string line; var qtdRows = File.ReadLines(baseDirectory + @"Templates\Controller\Controller.php").Count();
            string[] rowsFile = new string[qtdRows]; int i = 0;

            StreamReader reader = new StreamReader(baseDirectory + @"Templates\Controller\Controller.php");

            while ((line = reader.ReadLine()) != null)
            {
                rowsFile[i] = line;
                i++;
            }

            rowsFile[3] = (rowsFile[3] == c) ? $"class {name} extends Controller {{" : "class NOME_CONTROLLER extends Controller {";

            return rowsFile;
        }

        public void model(string name) 
        {

        }

        public void dao(string name) 
        {
            
        }
    }
}
