<?php

//DEBEMOS INCLUID LA CONEXION PARA PODER UTILIZAR LA VARIABLE PDO
include '../config/conexion.php';
$id_profesor = $_GET['id'];

////REALIZAMOS LA CONSULTA QUE DESEAMOS
$consulta = "SELECT id, grupo FROM grupos WHERE id_profesor= '$id_profesor'";

//OBTENEMOS LA CONSULTA
$resultado = $conexion->query($consulta);

//RECORREMOS EL SELECT PARA TRAER TODOS LOS DATOS NECESARIOS
while($fila=$resultado->fetch_array())
{
    $prueba[] = array_map('utf8_encode',$fila);
}

//LO CONVERTIMOS A FORMATO JSON
echo json_encode ($prueba);

//CERRAMOS TODA LA CONSULTA Y CONEXION
$resultado->close();

?>