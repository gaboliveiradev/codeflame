﻿using System;
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
        public string msg_finnaly_copied_files = "Todos os arquivos foram copiados com sucesso para [CODEFLAME_ROOT_DIR] \nObrigado(a) por utilizar o Codeflame <3 \n\nPressione qualquer tecla para sair...";
        public string msg_created_layer = "O arquivo [CODEFLAME_FILE] foi criado com sucesso no diretório [CODEFLAME_DIR]!";
    }
}
