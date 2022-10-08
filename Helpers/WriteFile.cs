using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace codeflame.Helpers
{
    public class WriteFile
    {
        public void createAndWriteFile(string dirRootFolder, string file, string[] infoConnection)
        {
            StreamWriter sw;
            ColorText ct = new ColorText();

            string host = infoConnection[0];
            string port = infoConnection[1];
            string user = infoConnection[2];
            string pass = infoConnection[3];
            string dbname = infoConnection[4];

            switch(file)
            {
                case @"App\index.php":
                    sw = File.CreateText(dirRootFolder + file);

                    sw.WriteLine("<?php");
                    sw.WriteLine("    session_start();");
                    sw.WriteLine("");
                    sw.WriteLine("    include \"./config.php\";");
                    sw.WriteLine("    include \"./autoload.php\";");
                    sw.WriteLine("    include \"./rotas.php\";");

                    sw.Close();

                    ct.setGray();
                    Console.WriteLine($"[V] - Arquivo [{file}] criado e buildado com sucesso.");
                    break;

                case @"App\config.php":
                    sw = File.CreateText(dirRootFolder + file);

                    sw.WriteLine("<?php");
                    sw.WriteLine("    define('BASEDIR', dirname(__FILE__, 2));");
                    sw.WriteLine("    define('VIEWS', BASEDIR . '/View/modules/');");
                    sw.WriteLine("");
                    sw.WriteLine($"    $_ENV['db']['host'] = \"{host}:{port}\";");
                    sw.WriteLine($"    $_ENV['db']['user'] = \"{user}\";");
                    sw.WriteLine($"    $_ENV['db']['pass'] = \"{pass}\";");
                    sw.WriteLine($"    $_ENV['db']['dbname'] = \"{dbname}\";");

                    sw.Close();

                    ct.setGray();
                    Console.WriteLine($"[V] - Arquivo [{file}] criado e buildado com sucesso.");
                    break;

                case @"App\autoload.php":
                    sw = File.CreateText(dirRootFolder + file);

                    sw.WriteLine("<?php");
                    sw.WriteLine("    spl_autoload_register(function ($class) {");
                    sw.WriteLine("        $arq = BASEDIR . '/' . $class . '.php';");
                    sw.WriteLine("");
                    sw.WriteLine("        if(file_exists($arq)) {");
                    sw.WriteLine("            include $arq;");
                    sw.WriteLine("        } else ");
                    sw.WriteLine("            exit('Arquivo não encontrado. Arquivo: ' . $arq . \"<br />\");");
                    sw.WriteLine("    });");

                    sw.Close();

                    ct.setGray();
                    Console.WriteLine($"[V] - Arquivo [{file}] criado e buildado com sucesso.");
                    break;

                case @"App\rotas.php":
                    sw = File.CreateText(dirRootFolder + file);

                    sw.WriteLine("<?php");
                    sw.WriteLine(@"use App\Controller\{");
                    sw.WriteLine("    WelcomeController,");
                    sw.WriteLine("};");
                    sw.WriteLine("");
                    sw.WriteLine("$parse_uri = parse_url($_SERVER['REQUEST_URI'], PHP_URL_PATH);");
                    sw.WriteLine("");
                    sw.WriteLine("switch($parse_uri) {");
                    sw.WriteLine("    case \"/welcome\":");
                    sw.WriteLine("        WelcomeController::index();");
                    sw.WriteLine("    break;");
                    sw.WriteLine("");
                    sw.WriteLine("    default:");
                    sw.WriteLine("        header(\"Location: /welcome\");");
                    sw.WriteLine("    break;");
                    sw.WriteLine("}");

                    sw.Close();

                    ct.setGray();
                    Console.WriteLine($"[V] - Arquivo [{file}] criado e buildado com sucesso.");
                    break;

                case @"App\Controller\Controller.php":
                    sw = File.CreateText(dirRootFolder + file);

                    sw.WriteLine("<?php");
                    sw.WriteLine(@"namespace App\Controller;");
                    sw.WriteLine("");
                    sw.WriteLine("abstract class Controller {");
                    sw.WriteLine("    protected static function render($view, $model = null) {");
                    sw.WriteLine("        $arquivo = \"./View/modules/$view.php\";");
                    sw.WriteLine("");
                    sw.WriteLine("        if(file_exists($arquivo))");
                    sw.WriteLine("            include  $arquivo;");
                    sw.WriteLine("        else");
                    sw.WriteLine("            echo \"arquivo não encontrado. Caminho: \" . $arquivo;");
                    sw.WriteLine("    }");
                    sw.WriteLine("}");
                    sw.WriteLine("");
                    sw.WriteLine("/*protected static function isAuthenticated() {");
                    sw.WriteLine("    if(!isset($_SESSION['user']))");
                    sw.WriteLine("        header(\"Location: /login\");");
                    sw.WriteLine("}*/");

                    sw.Close();

                    ct.setGray();
                    Console.WriteLine($"[V] - Arquivo [{file}] criado e buildado com sucesso.");
                    break;

                case @"App\Controller\WelcomeController.php":
                    sw = File.CreateText(dirRootFolder + file);

                    sw.WriteLine("<?php");
                    sw.WriteLine(@"namespace App\Controller;");
                    sw.WriteLine("");
                    sw.WriteLine("class WelcomeController extends Controller {");
                    sw.WriteLine("");
                    sw.WriteLine("    public static function index() {");
                    sw.WriteLine("        parent::render(\"" + @"Welcome\Welcome" +"\");");
                    sw.WriteLine("    }");
                    sw.WriteLine("}");

                    sw.Close();

                    ct.setGray();
                    Console.WriteLine($"[V] - Arquivo [{file}] criado e buildado com sucesso.");
                    break;

                case @"App\Model\Model.php":
                    sw = File.CreateText(dirRootFolder + file);

                    sw.WriteLine("<?php");
                    sw.WriteLine(@"namespace App\Model;");
                    sw.WriteLine("");
                    sw.WriteLine("abstract class Model {");
                    sw.WriteLine("");
                    sw.WriteLine("    public $rows;");
                    sw.WriteLine("");
                    sw.WriteLine("}");

                    sw.Close();

                    ct.setGray();
                    Console.WriteLine($"[V] - Arquivo [{file}] criado e buildado com sucesso.");
                    break;

                case @"App\DAO\DAO.php":
                    sw = File.CreateText(dirRootFolder + file);

                    sw.WriteLine("<?php");
                    sw.WriteLine(@"namespace App\DAO;");
                    sw.WriteLine("");
                    sw.WriteLine(@"use \PDO;");
                    sw.WriteLine("");
                    sw.WriteLine("abstract class DAO {");
                    sw.WriteLine("");
                    sw.WriteLine("    protected $conexao;");
                    sw.WriteLine("");
                    sw.WriteLine("    public function __construct() {");
                    sw.WriteLine("        $dsn = \"mysql:host=\" . $_ENV['db']['host'] . \";dbname=\" . $_ENV['db']['database'];");
                    sw.WriteLine("        $this->conexao = new PDO($dsn, $_ENV['db']['user'], $_ENV['db']['pass']);");
                    sw.WriteLine("    }");
                    sw.WriteLine("}");

                    sw.Close();

                    ct.setGray();
                    Console.WriteLine($"[V] - Arquivo [{file}] criado e buildado com sucesso.");
                    break;

                case @"App\View\Includes\Bootstrap\css_config.php":
                    sw = File.CreateText(dirRootFolder + file);

                    sw.WriteLine("<!-- Bootstrap CSS -->");
                    sw.WriteLine("<link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.1.2/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-uWxY/CJNBR+1zjPWmfnSnVxwRheevXITnMqoEIeG1LJrdI0GlVs/9cVSyPYXdcSF\" crossorigin=\"anonymous\">");

                    sw.Close();

                    ct.setGray();
                    Console.WriteLine($"[V] - Arquivo [{file}] criado e buildado com sucesso.");
                    break;

                case @"App\View\Includes\Bootstrap\js_config.php":
                    sw = File.CreateText(dirRootFolder + file);

                    sw.WriteLine("<!-- Bootstrap JS -->");
                    sw.WriteLine("<script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2\" crossorigin=\"anonymous\"></script>\r\n");

                    sw.Close();

                    ct.setGray();
                    Console.WriteLine($"[V] - Arquivo [{file}] criado e buildado com sucesso.");
                    break;

                case @"App\View\Includes\header.php":
                    sw = File.CreateText(dirRootFolder + file);

                    sw.WriteLine("//CODEFLAME");

                    sw.Close();

                    ct.setGray();
                    Console.WriteLine($"[V] - Arquivo [{file}] criado e buildado com sucesso.");
                    break;

                case @"App\View\Modules\Welcome\Welcome.php":
                    sw = File.CreateText(dirRootFolder + file);

                    sw.WriteLine("<!DOCTYPE html>");
                    sw.WriteLine("<html lang=\"pt-br\">");
                    sw.WriteLine("<head>");
                    sw.WriteLine("    <meta charset=\"UTF-8\">");
                    sw.WriteLine("    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
                    sw.WriteLine("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">");
                    sw.WriteLine("    <?php include \"./View/Includes/Bootstrap/css_config.php\" ?>");
                    sw.WriteLine("    <title>🔥 CodeFlame</title>");
                    sw.WriteLine("    <style>");
                    sw.WriteLine("        body {");
                    sw.WriteLine("            width: 100vw;");
                    sw.WriteLine("            height: 100vh;");
                    sw.WriteLine("            display: flex;");
                    sw.WriteLine("            justify-content: center;");
                    sw.WriteLine("            align-items: center;");
                    sw.WriteLine("        }");
                    sw.WriteLine("");
                    sw.WriteLine("        .jumbotron {");
                    sw.WriteLine("            width: 70vw;");
                    sw.WriteLine("        }");
                    sw.WriteLine("    </style>");
                    sw.WriteLine("</head>");
                    sw.WriteLine("<body>");
                    sw.WriteLine("    <div class=\"jumbotron\">");
                    sw.WriteLine("        <h1 class=\"display-4\">🔥 CodeFlame!</h1>");
                    sw.WriteLine("        <p class=\"lead\">Não perca tempo criando arquivos básicos! Utilize o CodeFlame e decole na produtividade de programação!</p>");
                    sw.WriteLine("        <hr class=\"my-4\">");
                    sw.WriteLine("        <p><b>CodeFlame</b> é um framework que com apenas um comando te entrega toda a estrutura do padrão de <b>Projeto MVC.</b> Não perca mais tempo criando a estrutura básica do seu projeto, desde as estruturas de pastas até a build de cada arquivo essêncial. O CodeFlame é um framework de <b>código aberto</b> que se encontra na sua versão <b>1.0.0</b>. Em breve pensamos em adicionar mais funcionalidades que <b>facilite</b> sua vida como <b>programador :)</b> <br><br> <b>Atenção:</b> Recomendamos utilizar o CodeFlame caso você já saiba e entenda sobre o padrão de projeto MVC.</p>");
                    sw.WriteLine("        <p class=\"lead\">");
                    sw.WriteLine("            <a class=\"btn btn-sucess btn-lg\" href=\"https://github.com/gaboliveiradev/codeflame\" role=\"button\">Github Repository</a>");
                    sw.WriteLine("        </p>");
                    sw.WriteLine("    </div>");
                    sw.WriteLine("<?php include \"./View/Includes/Bootstrap/js_config.php\" ?>");
                    sw.WriteLine("</body>");
                    sw.WriteLine("</html>");

                    sw.Close();

                    ct.setGray();
                    Console.WriteLine($"[V] - Arquivo [{file}] criado e buildado com sucesso.");
                    break;
            }

        }
    }
}
