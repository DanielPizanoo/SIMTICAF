<?php
    require("Conexion.php");
    $data = json_decode(file_get_contents('php://input'), true);

    $consulta="INSERT INTO `registros`(`id_registro`, `cantidad`, `preciou`, `categoria`, `descripcion`) 
    VALUES ('".$data['id_registro']."','".$data['cantidad']."','".$data['preciou']."', '".$data['categoria']."', '".$data['descripcion']."')";

    mysqli_query($conexion,$consulta);
    echo $consulta;
?>