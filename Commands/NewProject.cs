using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using codeflame.Helpers;
using codeflame.Response;

namespace codeflame.Commands
{
    public class NewProject
    {
        Error err = new Error();
        Success succ = new Success();
        public string rootDirectory, projectName;

        public void createRootDirectory(string projectName, string rootDirectory)
        {
            this.rootDirectory = rootDirectory;
            this.projectName = projectName;

            try
            {
                if (Directory.Exists(rootDirectory))
                {
                    new existingProject(err.prefix, err.msg_existing_project.Replace("CODEFLAME_NAME_PROJECT", projectName));
                }
                else
                {
                    Directory.CreateDirectory($"{rootDirectory}");
                    new projectCreated(succ.prefix, succ.msg_project_created.Replace("CODEFLAME_ROOT_DIR", rootDirectory));
                    
                    copyRootFiles();
                }
            } catch
            {
                new createProjectFail(err.prefix, err.msg_create_project_fail.Replace("CODEFLAME_NAME_PROJECT", projectName));
            }
        }

        public void copyRootFiles()
        {
            try
            {
                string[] rootFiles = { "autoload.php", "config.php", "index.php", "rotas.php" };
                string baseDirectory = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory.ToString());

                new fileTransferStarted(succ.prefix, succ.msg_file_transfer_started);
                Console.WriteLine("");

                foreach (string f in rootFiles)
                {
                    File.Copy(baseDirectory + @"Templates\MVC\" + f, $"{this.rootDirectory}" + @"\" + f, true);
                    new copiedFile(succ.prefix, succ.msg_copied_file.Replace("CODEFLAME_FILE", f));

                }
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
