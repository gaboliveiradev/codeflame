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
        string baseDirectory = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory.ToString());

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

                    createFolders();
                    copyFiles();
                }
            } catch
            {
                new createProjectFail(err.prefix, err.msg_create_project_fail.Replace("CODEFLAME_NAME_PROJECT", projectName));
            }
        }

        public void createFolders()
        {
            string[] folders = { 
                @"\Controller", @"\DAO", @"\Model", @"\View", @"\View\assets", @"\View\bootstrap",
                @"\View\bootstrap\css", @"\View\bootstrap\js", @"\View\css", @"\View\css\welcome", 
                @"\View\includes", @"\View\modules\welcome", @"\Migration", @"\Provider",
            };

            foreach(string f in folders)
            {
                if(!Directory.Exists(f))
                {
                    Directory.CreateDirectory(this.rootDirectory + f);
                }
            }
        }

        public void copyFiles()
        {
            CopyFile helper = new CopyFile();
            helper.copyFiles(this.baseDirectory, this.rootDirectory);
        }
    }
}
