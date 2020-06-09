<?php
    require('Conexion.php');

    $consulta="SELECT usuario, pass FROM usuarios";
    $res=mysqli_query($conexion,$consulta);

    $datos=array();

    foreach($res as $filas){
        array_push($datos, array(
            'usuario'=>$filas['usuario'],
            'pass'=>$filas['pass']
        ));
    }

    echo json_encode($datos,JSON_UNESCAPED_UNICODE);
?>