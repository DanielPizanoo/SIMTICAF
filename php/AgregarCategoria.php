<?php  
    require("Conexion.php");
    $data = json_decode(file_get_contents('php://input'), true);

    $consulta="INSERT INTO `categorias`(`descripcion`) VALUES ('".$data['descripcion']."')";
    
    mysqli_query($conexion,$consulta);
    echo $consulta;
?>