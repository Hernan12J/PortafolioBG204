<?php

//DEBEMOS INCLUID LA CONEXION PARA PODER UTILIZAR LA VARIABLE PDO
include '../config/conexion.php';
$cedula = $_GET['cedula'];
$id_grupo = $_GET['id_grupo'];

//REALIZAMOS LA CONSULTA QUE DESEAMOS
$consulta = "SELECT estudiante.id FROM estudiante JOIN grupo_estudiante ON
estudiante.id = grupo_estudiante.id_estudiante
where grupo_estudiante.id_grupo = '$id_grupo' AND cedula='$cedula'";

//OBTENEMOS LA CONSULTA
$resultado = $conexion->query($consulta);

//RECORREMOS EL SELECT PARA TRAER TODOS LOS DATOS NECESARIOS
while($fila = $resultado->fetch_array()){
    $prueba[] = array_map('utf8_encode', $fila);
}

//LO CONVERTIMOS A FORMATO JSON
echo json_encode($prueba);

//CERRAMOS TODA LA CONSULTA Y CONEXION
$resultado->close();
?>