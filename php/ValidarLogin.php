<?php
    require('Conexion.php');
    $data = jason_decode(file_get_contents('php://input'), true);

    $consulta="SELECT * FROM usuarios WHERE usuario = '".$data['usuario']."' and pass = '".$data['pass']."'";
    $res=mysqli_query($conexion,$consulta);
    $numfilas=mysqli_num_rows($res);

    if ($numfilas>0) {
        echo 1;
    } else {
        echo 0;
    }
?>