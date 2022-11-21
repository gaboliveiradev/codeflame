<?php
use App\Controller\{
    WelcomeController
};

$parse_uri = parse_url($_SERVER['REQUEST_URI'], PHP_URL_PATH);

switch($parse_uri) {

    
    case "/welcome":
        WelcomeController::index();
    break;

    default:
        header("Location: /welcome");
    break;
}