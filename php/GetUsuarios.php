<?php
    require('Conexion.php');

    $consulta="SELECT * FROM usuarios";
    $res=mysqli_query($conexion,$consulta);

    $datos=array();

    foreach($res as $filas){
        array_push($datos, array(
            'id_control'=>$filas['id_control'],
            'nombre'=>$filas['nombre'],
            'apellido1'=>$filas['apellido1'],
            'apellido2'=>$filas['apellido2'],
            'telefono'=>$filas['telefono'],
            'correo'=>$filas['correo'],
            'usuario'=>$filas['usuario'],
            'pass'=>$filas['pass']
        ));
    }

    echo json_encode($datos,JSON_UNESCAPED_UNICODE);
?>
