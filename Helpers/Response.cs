using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeflame.Helpers
{
    abstract class ResponseError
    {
        protected void sendMessage(string prefix, string msg)
        {
            SetColor c = new SetColor();
            c.setColor("Red");

            Console.WriteLine($"{prefix} {msg}");

            c.resetColor();
        }
    }

    abstract class ResponseSuccess
    {
        protected void sendMessage(string prefix, string msg)
        {
            SetColor c = new SetColor();
            c.setColor("DarkGreen");

            Console.WriteLine($"{prefix} {msg}");

            c.resetColor();
        }
    }

    // ====================== Mensagens de Erros ======================

    internal class existingProject : ResponseError
    {
        public existingProject(string prefix, string msg)
        {
            base.sendMessage(prefix, msg);
        }
    }

    internal class createProjectFail : ResponseError
    {
        public createProjectFail(string prefix, string msg)
        {
            base.sendMessage(prefix, msg);
        }
    }

    // ====================== Mensagens de Sucesso ======================

    internal class projectCreated : ResponseSuccess
    {
        public projectCreated(string prefix, string msg)
        {
            base.sendMessage(prefix, msg);
        }
    }

    internal class fileTransferStarted : ResponseSuccess
    {
        public fileTransferStarted(string prefix, string msg)
        {
            base.sendMessage(prefix, msg);
        }
    }

    internal class copiedFile : ResponseSuccess
    {
        public copiedFile(string prefix, string msg)
        {
            base.sendMessage(prefix, msg);
        }
    }
}
