<?php
    spl_autoload_register(function ($class) {
        $arq = BASEDIR . '/' . $class . '.php';

        if(file_exists($arq)) {
            include $arq;
        } else 
            exit('Arquivo não encontrado. Arquivo: ' . $arq . "<br />");
    });