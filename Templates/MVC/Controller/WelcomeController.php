<?php
namespace App\Controller;

class WelcomeController extends Controller {

    public static function index() {
        parent::render("welcome/index.view");
    }
}