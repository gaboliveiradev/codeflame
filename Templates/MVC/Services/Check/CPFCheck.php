<?php
namespace App\Services\Check;

class CPFCheck {

    public static function CPFCheck(string $cpf) {

        $cpf = str_replace(array(".", "-"), "", $cpf);
        $arr_digitos = str_split($cpf);

        if(count($arr_digitos) > 11) return false;
        
        $j = 9;
        foreach($arr_digitos as $valor) {
            if($valor == $j) return false;
            $j--;
        }

        $d1 = $arr_digitos[9];
        $d2 = $arr_digitos[10];

        $resto_d1 = 0;
        $resto_d2 = 0;

        $soma_d1 = 0;
        $soma_d2 = 0;
        
        $j = 10;
        for($i = 0; $i < 9; $i++) {
            $soma_d1 += $arr_digitos[$i] * $j; $j--;
        }

        $j = 11;
        for($i = 0; $i < 10; $i++) {
            $soma_d2 += $arr_digitos[$i] * $j; $j--;
        }

        $resto_d1 = ($soma_d1 * 10) % 11;
        $resto_d2 = ($soma_d2 * 10) % 11;

        $resto_d1 = ($resto_d1 == 10) ? 0 : $resto_d1;
        $resto_d2 = ($resto_d2 == 10) ? 0 : $resto_d2;

        if($d1 == $resto_d1 && $d2 == $resto_d2) return true;
    }
}
