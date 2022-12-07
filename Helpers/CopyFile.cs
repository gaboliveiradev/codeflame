using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using codeflame.Response;

namespace codeflame.Helpers
{
    public class CopyFile
    {
        Error err = new Error();
        Success succ = new Success();

        public void copyFiles(string baseDirectory, string rootDirectory, string colorTitle = "DarkGreen", string colorMsg = "Green")
        {
            try
            {
                string[] rootFiles = Directory.GetFiles(baseDirectory + @"Templates\MVC\");
                string[] bootstrapCssFiles = Directory.GetFiles(baseDirectory + @"Templates\MVC\View\bootstrap\css");
                string[] bootstrapJsFiles = Directory.GetFiles(baseDirectory + @"Templates\MVC\View\bootstrap\js");
                string[] moduleWelcomeFiles = Directory.GetFiles(baseDirectory + @"Templates\MVC\View\modules\welcome"); ;
                string[] cssWelcomeFiles = Directory.GetFiles(baseDirectory + @"Templates\MVC\View\css\welcome");
                string[] includesFiles = Directory.GetFiles(baseDirectory + @"Templates\MVC\View\includes");
                string[] controllerFiles = Directory.GetFiles(baseDirectory + @"Templates\MVC\Controller");
                string[] modelFiles = Directory.GetFiles(baseDirectory + @"Templates\MVC\Model");
                string[] daoFiles = Directory.GetFiles(baseDirectory + @"Templates\MVC\DAO");

                Console.WriteLine("");
                new fileTransferStarted(succ.prefix, succ.msg_file_transfer_started.Replace("CODEFLAME_TYPE_FILE", "RAIZ"), colorTitle);
                foreach (string f in rootFiles)
                {
                    File.Copy(baseDirectory + @"Templates\MVC\" + Path.GetFileName(f), $"{rootDirectory}" + @"\" + Path.GetFileName(f), true);
                    new copiedFile(succ.prefix, succ.msg_copied_file.Replace("CODEFLAME_FILE", Path.GetFileName(f)), colorMsg);
                }

                Console.WriteLine("");
                new fileTransferStarted(succ.prefix, succ.msg_file_transfer_started.Replace("CODEFLAME_TYPE_FILE", "BOOTSTRAP CSS/JS"), colorTitle);
                foreach (string f in bootstrapCssFiles)
                {
                    File.Copy(baseDirectory + @"Templates\MVC\View\bootstrap\css\" + Path.GetFileName(f), $"{rootDirectory}" + @"\View\bootstrap\css\" + Path.GetFileName(f), true);
                    new copiedFile(succ.prefix, succ.msg_copied_file.Replace("CODEFLAME_FILE", Path.GetFileName(f)), colorMsg);
                }

                foreach (string f in bootstrapJsFiles)
                {
                    File.Copy(baseDirectory + @"Templates\MVC\View\bootstrap\js\" + Path.GetFileName(f), $"{rootDirectory}" + @"\View\bootstrap\js\" + Path.GetFileName(f), true);
                    new copiedFile(succ.prefix, succ.msg_copied_file.Replace("CODEFLAME_FILE", Path.GetFileName(f)), colorMsg);
                }

                Console.WriteLine("");
                new fileTransferStarted(succ.prefix, succ.msg_file_transfer_started.Replace("CODEFLAME_TYPE_FILE", "WELCOME PAGE"), colorTitle);
                foreach (string f in moduleWelcomeFiles)
                {
                    File.Copy(baseDirectory + @"Templates\MVC\View\modules\welcome\" + Path.GetFileName(f), $"{rootDirectory}" + @"\View\modules\welcome\" + Path.GetFileName(f), true); ;
                    new copiedFile(succ.prefix, succ.msg_copied_file.Replace("CODEFLAME_FILE", Path.GetFileName(f)), colorMsg);
                }

                foreach (string f in cssWelcomeFiles)
                {
                    File.Copy(baseDirectory + @"Templates\MVC\View\css\welcome\" + Path.GetFileName(f), $"{rootDirectory}" + @"\View\css\welcome\" + Path.GetFileName(f), true); ;
                    new copiedFile(succ.prefix, succ.msg_copied_file.Replace("CODEFLAME_FILE", Path.GetFileName(f)), colorMsg);
                }

                Console.WriteLine("");
                new fileTransferStarted(succ.prefix, succ.msg_file_transfer_started.Replace("CODEFLAME_TYPE_FILE", "INCLUDES CSS/JS"), colorTitle);
                foreach (string f in includesFiles)
                {
                    File.Copy(baseDirectory + @"Templates\MVC\View\includes\" + Path.GetFileName(f), $"{rootDirectory}" + @"\View\includes\" + Path.GetFileName(f), true);
                    new copiedFile(succ.prefix, succ.msg_copied_file.Replace("CODEFLAME_FILE", Path.GetFileName(f)), colorMsg);
                }

                Console.WriteLine("");
                new fileTransferStarted(succ.prefix, succ.msg_file_transfer_started.Replace("CODEFLAME_TYPE_FILE", "CONTROLLER"), colorTitle);
                foreach (string f in controllerFiles)
                {
                    File.Copy(baseDirectory + @"Templates\MVC\Controller\" + Path.GetFileName(f), $"{rootDirectory}" + @"\Controller\" + Path.GetFileName(f), true);
                    new copiedFile(succ.prefix, succ.msg_copied_file.Replace("CODEFLAME_FILE", Path.GetFileName(f)), colorMsg);
                }

                Console.WriteLine("");
                new fileTransferStarted(succ.prefix, succ.msg_file_transfer_started.Replace("CODEFLAME_TYPE_FILE", "MODEL"), colorTitle);
                foreach (string f in modelFiles)
                {
                    File.Copy(baseDirectory + @"Templates\MVC\Model\" + Path.GetFileName(f), $"{rootDirectory}" + @"\Model\" + Path.GetFileName(f), true);
                    new copiedFile(succ.prefix, succ.msg_copied_file.Replace("CODEFLAME_FILE", Path.GetFileName(f)), colorMsg);
                }

                Console.WriteLine("");
                new fileTransferStarted(succ.prefix, succ.msg_file_transfer_started.Replace("CODEFLAME_TYPE_FILE", "DAO"), colorTitle);
                foreach (string f in daoFiles)
                {
                    File.Copy(baseDirectory + @"Templates\MVC\DAO\" + Path.GetFileName(f), $"{rootDirectory}" + @"\DAO\" + Path.GetFileName(f), true);
                    new copiedFile(succ.prefix, succ.msg_copied_file.Replace("CODEFLAME_FILE", Path.GetFileName(f)), colorMsg);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
