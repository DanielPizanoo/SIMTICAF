<?php
    require("Conexion.php");
    $data = json_decode(file_get_contents('php://input'), true);

    $consulta="INSERT INTO `registros` (`id_registro`, `cantidad`, `preciou`, `creacion`, `id_categoria`, `descripcion`) 
    VALUES ('".$data['preciou']."','".$data['cantidad']."','".$data['categoria']."','".$data['descripcion']."')";

    mysqli_query($conexion,$consulta);
    echo $consulta;
?>