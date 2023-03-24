using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using codeflame.Helpers;
using codeflame.Response;

namespace codeflame.Commands
{
    public class MakeLayer
    {
        string baseDirectory = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory.ToString());

        Error err = new Error();
        Success succ = new Success();

        public void createController(string nameController)
        {
            ChangeName changeName = new ChangeName();
            changeName.controller(baseDirectory, nameController);

            string dir_atual = Directory.GetCurrentDirectory();
            string dir_projeto = dir_atual + @"\Controller\"; ;
            string arquivo = dir_projeto + nameController + ".php";
            string arquivo_temporario = baseDirectory + @"Templates\Controller\Temporary.php";

            if (Directory.Exists(dir_projeto))
            {
                if (!File.Exists(arquivo))
                {
                    using (StreamWriter writer = new StreamWriter(arquivo_temporario))
                    {
                        foreach (string r in changeName.controller(baseDirectory, nameController))
                        {
                            writer.WriteLine(r);
                        }

                        writer.Close();
                    }

                    File.Copy(arquivo_temporario, arquivo, true);
                    new layersCreated(succ.prefix, succ.msg_created_layer.Replace("CODEFLAME_FILE", nameController).Replace("CODEFLAME_DIR", arquivo));
                }
                else
                {
                    new fileNameExists(err.prefix, err.msg_file_name_exists.Replace("CODEFLAME_LAYER", "controller").Replace("CODEFLAME_FILE_NAME", nameController));
                }
            } else
            {
                new directoryNotFound(err.prefix, err.msg_directory_not_found.Replace("CODEFLAME_FOLDER", @"...\Controller"));
            }
        }

        public void createModel(string nameModel)
        {

        }

        public void createDAO(string nameDAO)
        {

        }
    }
}
