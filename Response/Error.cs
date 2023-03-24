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

        public string msg_existing_project = "Já existe um projeto com o nome [CODEFLAME_NAME_PROJECT], porfavor escolhar outro nome.";
        public string msg_create_project_fail = "Ocorreu um erro inesperado ao tentar criar o projeto [CODEFLAME_NAME_PROJECT], porfavor tente novamente.";
        public string msg_directory_not_found = "Verificamos que você não possui a pasta [CODEFLAME_FOLDER], confira se está no diretório correto da aplicação.";
        public string msg_file_name_exists = "Verificamos que você já possui um arquivo [CODEFLAME_LAYER] criado com este nome [CODEFLAME_FILE_NAME].";
        public string msg_cmd_invalid = "Este é um comando inválido, porfavor digite [codeflame list] para verificar todos os comandos válidos";
    }
}
