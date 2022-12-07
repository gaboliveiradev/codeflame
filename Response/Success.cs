using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeflame.Response
{
    public class Success
    {
        public string prefix = "[V]";

        public string msg_project_created = "Pasta raiz do projeto criada com sucesso. Acesse [CODEFLAME_ROOT_DIR].";
        public string msg_file_transfer_started = "Iniciando a transferência dos arquivos [CODEFLAME_TYPE_FILE]";
        public string msg_copied_file = "Arquivo [CODEFLAME_FILE] copiado com sucesso para o diretório do projeto.";
    }
}
