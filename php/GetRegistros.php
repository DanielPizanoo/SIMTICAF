<?php
    require ('Conexion.php');

    $consulta="SELECT * FROM registros";
    $res=mysqli_query($conexion,$consulta);

    $datos=array();

    foreach($res as $filas) {
        array_push($datos, array (
            'id_registro'=>$filas['id_registro'],
            'cantidad'=>$filas['cantidad'],
            'preciou'=>$filas['preciou'],
            'creacion'=>$filas['creacion'],
            'id_categoria'=>$filas['id_categoria'],
            'descripcion'=>$filas['descripcion']
        ));
    }

    echo json_encode($datos,JSON_UNESCAPED_UNICODE);
?>