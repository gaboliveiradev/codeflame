using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeflame.Response
{
    public class Error
    {
        public string prefix = "[X]";

        public string msg_existing_project = "Já existe um projeto com o nome \"CODEFLAME_NAME_PROJECT\", porfavor escolhar outro nome.";
        public string msg_create_project = "Ocorreu um erro inesperado ao tentar criar o projeto \"CODEFLAME_NAME_PROJECT\", porfavor tente novamente.";
    }
}
