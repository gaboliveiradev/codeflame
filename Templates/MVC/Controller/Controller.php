<?php
    namespace App\Controller;

    abstract class Controller {

        /*
         * isAuthenticated() é um metodo que verifica se o usuário está logado.
         * Este metodo é importante para impossibilitar usuário que não estejam autenticados,
         * a logar em páginas/áreas restritas do site.
         * 
         * A lógica é muito simples, caso o usuário não tenha a SESSION especificado, quer dizer
         * que ele não efetuou o login.
         *
         * !!! CASO QUEIRA UTILIZAR, BASTA CONFIGURAR DE ACORDO COM SUA SESSION E DESCOMENTAR O METODO.
        */
        /*protected static function isAuthenticated() {
            if(!isset($_SESSION['user']))
                header("Location: /login");
        }*/

        protected static function render($view, $model = null) {
            $arquivo = "./View/modules/$view.php";

            if(file_exists($arquivo))
                include  $arquivo;
            else 
                echo "arquivo não encontrado. Caminho: " . $arquivo;   
        }
    }