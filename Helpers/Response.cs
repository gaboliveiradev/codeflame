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
        protected void sendMessage(string prefix, string msg, string color = "Red")
        {
            SetColor c = new SetColor();
            c.setColor(color);

            Console.WriteLine($"{prefix} {msg}");

            c.resetColor();
        }
    }

    abstract class ResponseSuccess
    {
        protected void sendMessage(string prefix, string msg, string color = "DarkGreen")
        {
            SetColor c = new SetColor();
            c.setColor(color);

            Console.WriteLine($"{prefix} {msg}");

            c.resetColor();
        }
    }

    // ====================== Mensagens de Erros ======================

    internal class existingProject : ResponseError
    {
        public existingProject(string prefix, string msg, string color = "Red")
        {
            base.sendMessage(prefix, msg, color);
        }
    }

    internal class createProjectFail : ResponseError
    {
        public createProjectFail(string prefix, string msg, string color = "Red")
        {
            base.sendMessage(prefix, msg, color);
        }
    }

    internal class directoryNotFound : ResponseError
    {
        public directoryNotFound(string prefix, string msg, string color = "Red")
        {
            base.sendMessage(prefix, msg, color);
        }
    }

    internal class fileNameExists : ResponseError
    {
        public fileNameExists(string prefix, string msg, string color = "Red")
        {
            base.sendMessage(prefix, msg, color);
        }
    }

    // ====================== Mensagens de Sucesso ======================

    internal class projectCreated : ResponseSuccess
    {
        public projectCreated(string prefix, string msg, string color = "DarkGreen")
        {
            base.sendMessage(prefix, msg, color);
        }
    }

    internal class finnalyCopiedFiles : ResponseSuccess
    {
        public finnalyCopiedFiles(string prefix, string msg, string color = "DarkGreen")
        {
            base.sendMessage(prefix, msg, color);
        }
    }

    internal class fileTransferStarted : ResponseSuccess
    {
        public fileTransferStarted(string prefix, string msg, string color = "DarkGreen")
        {
            base.sendMessage(prefix, msg, color);
        }
    }

    internal class copiedFile : ResponseSuccess
    {
        public copiedFile(string prefix, string msg, string color = "DarkGreen")
        {
            base.sendMessage(prefix, msg, color);
        }
    }

    internal class layersCreated : ResponseSuccess
    {
        public layersCreated(string prefix, string msg, string color = "DarkGreen")
        {
            base.sendMessage(prefix, msg, color);
        }
    }
}
