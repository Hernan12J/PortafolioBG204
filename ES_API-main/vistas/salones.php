<?php

//DEBEMOS INCLUID LA CONEXION PARA PODER UTILIZAR LA VARIABLE PDO
include '../config/conexion.php';
$id_profesor = $_GET['id'];
$id_grupo = $_GET['id_grupo'];

////REALIZAMOS LA CONSULTA QUE DESEAMOS
$consulta = "SELECT DISTINCT h.id as 'id_horario', h.salon FROM horario as h
join grupos as g WHERE h.id_profesor='$id_profesor' and h.salon != '-' and h.id_grupo = '$id_grupo' group by h.dia ASC";

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