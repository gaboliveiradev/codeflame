using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

            string dir_atual = Directory.GetCurrentDirectory();
            string dir_projeto = (dir_atual.Substring(dir_atual.Length - 3) == "App") ? dir_atual + @"\Controller\" : dir_atual + @"\App\Controller\";
            string arquivo = dir_projeto + nameController + ".php";
            string arquivo_temporario = baseDirectory + @"Templates\Controller\Temporary.php";

            string existControllerDefault = Path.Combine(dir_projeto, "Controller.php");

            if (Directory.Exists(dir_projeto))
            {
                if (!File.Exists(arquivo))
                {
                    if (!File.Exists(existControllerDefault))
                    {
                        File.Copy(baseDirectory + @"Templates\MVC\Controller\" + Path.GetFileName("Controller.php"), $"{dir_projeto}" + Path.GetFileName("Controller.php"), true);
                    }

                    using (StreamWriter writer = new StreamWriter(arquivo_temporario))
                    {
                        foreach (string r in changeName.controller(nameController))
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
            }
            else
            {
                Directory.CreateDirectory(dir_projeto);

                if (!File.Exists(arquivo))
                {
                    if (!File.Exists(existControllerDefault))
                    {
                        File.Copy(baseDirectory + @"Templates\MVC\Controller\" + Path.GetFileName("Controller.php"), $"{dir_projeto}" + Path.GetFileName("Controller.php"), true);
                    }

                    using (StreamWriter writer = new StreamWriter(arquivo_temporario))
                    {
                        foreach (string r in changeName.controller(nameController))
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
            }
        }

        public void createModel(string nameModel)
        {
            ChangeName changeName = new ChangeName();

            string dir_atual = Directory.GetCurrentDirectory();
            string dir_projeto = (dir_atual.Substring(dir_atual.Length - 3) == "App") ? dir_atual + @"\Model\" : dir_atual + @"\App\Model\";
            string arquivo = dir_projeto + nameModel + ".php";
            string arquivo_temporario = baseDirectory + @"Templates\Model\Temporary.php";

            string existModelDefault = Path.Combine(dir_projeto, "Model.php");

            if (Directory.Exists(dir_projeto))
            {
                if (!File.Exists(arquivo))
                {
                    if (!File.Exists(existModelDefault))
                    {
                        File.Copy(baseDirectory + @"Templates\MVC\Model\" + Path.GetFileName("Model.php"), $"{dir_projeto}" + Path.GetFileName("Model.php"), true);
                    }

                    using (StreamWriter writer = new StreamWriter(arquivo_temporario))
                    {
                        foreach (string r in changeName.model(nameModel))
                        {
                            writer.WriteLine(r);
                        }

                        writer.Close();
                    }

                    File.Copy(arquivo_temporario, arquivo, true);
                    new layersCreated(succ.prefix, succ.msg_created_layer.Replace("CODEFLAME_FILE", nameModel).Replace("CODEFLAME_DIR", arquivo));
                }
                else
                {
                    new fileNameExists(err.prefix, err.msg_file_name_exists.Replace("CODEFLAME_LAYER", "model").Replace("CODEFLAME_FILE_NAME", nameModel));
                }
            }
            else
            {
                Directory.CreateDirectory(dir_projeto);

                if (!File.Exists(arquivo))
                {
                    if (!File.Exists(existModelDefault))
                    {
                        File.Copy(baseDirectory + @"Templates\MVC\Model\" + Path.GetFileName("Model.php"), $"{dir_projeto}" + Path.GetFileName("Model.php"), true);
                    }

                    using (StreamWriter writer = new StreamWriter(arquivo_temporario))
                    {
                        foreach (string r in changeName.model(nameModel))
                        {
                            writer.WriteLine(r);
                        }

                        writer.Close();
                    }

                    File.Copy(arquivo_temporario, arquivo, true);
                    new layersCreated(succ.prefix, succ.msg_created_layer.Replace("CODEFLAME_FILE", nameModel).Replace("CODEFLAME_DIR", arquivo));
                }
                else
                {
                    new directoryNotFound(err.prefix, err.msg_directory_not_found.Replace("CODEFLAME_FOLDER", @"...\Model"));
                }
            }
        }

        public void createDAO(string nameDAO)
        {
            ChangeName changeName = new ChangeName();

            string dir_atual = Directory.GetCurrentDirectory();
            string dir_projeto = (dir_atual.Substring(dir_atual.Length - 3) == "App") ? dir_atual + @"\DAO\" : dir_atual + @"\App\DAO\";
            string arquivo = dir_projeto + nameDAO + ".php";
            string arquivo_temporario = baseDirectory + @"Templates\DAO\Temporary.php";

            string existDAODefault = Path.Combine(dir_projeto, "DAO.php");

            if (Directory.Exists(dir_projeto))
            {
                if (!File.Exists(arquivo))
                {
                    if (!File.Exists(existDAODefault))
                    {
                        File.Copy(baseDirectory + @"Templates\MVC\DAO\" + Path.GetFileName("DAO.php"), $"{dir_projeto}" + Path.GetFileName("DAO.php"), true);
                    }

                    using (StreamWriter writer = new StreamWriter(arquivo_temporario))
                    {
                        foreach (string r in changeName.dao(nameDAO))
                        {
                            writer.WriteLine(r);
                        }

                        writer.Close();
                    }

                    File.Copy(arquivo_temporario, arquivo, true);
                    new layersCreated(succ.prefix, succ.msg_created_layer.Replace("CODEFLAME_FILE", nameDAO).Replace("CODEFLAME_DIR", arquivo));
                }
                else
                {
                    new fileNameExists(err.prefix, err.msg_file_name_exists.Replace("CODEFLAME_LAYER", "dao").Replace("CODEFLAME_FILE_NAME", nameDAO));
                }
            }
            else
            {
                Directory.CreateDirectory(dir_projeto);

                if (!File.Exists(arquivo))
                {
                    if (!File.Exists(existDAODefault))
                    {
                        File.Copy(baseDirectory + @"Templates\MVC\DAO\" + Path.GetFileName("dao.php"), $"{dir_projeto}" + Path.GetFileName("DAO.php"), true);
                    }

                    using (StreamWriter writer = new StreamWriter(arquivo_temporario))
                    {
                        foreach (string r in changeName.dao(nameDAO))
                        {
                            writer.WriteLine(r);
                        }

                        writer.Close();
                    }

                    File.Copy(arquivo_temporario, arquivo, true);
                    new layersCreated(succ.prefix, succ.msg_created_layer.Replace("CODEFLAME_FILE", nameDAO).Replace("CODEFLAME_DIR", arquivo));
                }
                else
                {
                    new directoryNotFound(err.prefix, err.msg_directory_not_found.Replace("CODEFLAME_FOLDER", @"...\DAO"));
                }
            }
        }
    }
}
