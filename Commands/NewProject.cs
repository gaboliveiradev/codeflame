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
        public string rootDirectory, projectName;

        public void createRootDirectory(string projectName, string rootDirectory)
        {
            this.rootDirectory = rootDirectory;
            this.projectName = projectName;

            try
            {
                if (Directory.Exists(rootDirectory))
                {
                    Error err = new Error();
                    new existingProject(err.prefix, err.msg_existing_project.Replace("CODEFLAME_NAME_PROJECT", projectName));
                }
                else
                {
                    Directory.CreateDirectory($"{rootDirectory}");

                    Success succ = new Success();
                    new projectCreated(succ.prefix, succ.msg_project_created.Replace("CODEFLAME_ROOT_DIR", rootDirectory));
                }
            } catch
            {
                Error err = new Error();
                new createProjectFail(err.prefix, err.msg_create_project_fail.Replace("CODEFLAME_NAME_PROJECT", projectName));
            }
        }
    }
}
