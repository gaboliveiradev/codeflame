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
        string baseDirectory = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory.ToString());
        public string c = "class NOME_CONTROLLER extends Controller {";
        public string m = "class NOME_MODEL extends Model {";
        public string d = "class NOME_DAO extends DAO {";

        public string[] controller(string name)
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

        public string[] model(string name, string[] arr_props = null) 
        {
            string line; var qtdRows = File.ReadLines(baseDirectory + @"Templates\Model\Model.php").Count();
            string[] rowsFile = new string[qtdRows]; int i = 0;

            StreamReader reader = new StreamReader(baseDirectory + @"Templates\Model\Model.php");

            while ((line = reader.ReadLine()) != null)
            {
                rowsFile[i] = line;
                i++;
            }

            if (arr_props != null)
            {
                string conj_props = "";

                foreach (string p in arr_props)
                {
                    conj_props += $", ${p}";
                }

                rowsFile[4] = $"    public $id{conj_props};";
            }

            rowsFile[3] = (rowsFile[3] == m) ? $"class {name} extends Model {{" : "class NOME_MODEL extends Model {";

            return rowsFile;
        }

        public string[] dao(string name) 
        {
            string line; var qtdRows = File.ReadLines(baseDirectory + @"Templates\DAO\DAO.php").Count();
            string[] rowsFile = new string[qtdRows]; int i = 0;

            StreamReader reader = new StreamReader(baseDirectory + @"Templates\DAO\DAO.php");

            while ((line = reader.ReadLine()) != null)
            {
                rowsFile[i] = line;
                i++;
            }

            rowsFile[5] = (rowsFile[5] == d) ? $"class {name} extends DAO {{" : "class NOME_DAO extends DAO {";

            return rowsFile;
        }
    }
}
