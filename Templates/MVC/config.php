<?php
    define('BASEDIR', dirname(__FILE__, 2));
    define('VIEWS', BASEDIR . '/View/modules/');

    $_ENV['db']['host'] = "192.168.1.1";
    $_ENV['db']['user'] = "codeflame";
    $_ENV['db']['pass'] = "codeflamepw";
    $_ENV['db']['dbname'] = "codeflamedb";