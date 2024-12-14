<?php

include '../config/conexion.php';

    $id_profesor = $_REQUEST['id_profesor'];
    $id_estudiante = $_REQUEST['id_estudiante'];
    $id_horario = $_REQUEST['id_horario'];
    $id_grupo = $_REQUEST['id_grupo'];
    $asistencia = $_REQUEST['asistencia'];
    $porcentaje = $_REQUEST['porcentaje'];
        
    $consulta = "INSERT INTO lista_asist (id_profesor, id_estudiante, asistencia, porcentaje, id_grupo, id_horario)
        VALUES ('".$id_profesor."','".$id_estudiante."','".$asistencia."',
                '".$porcentaje."','".$id_grupo."','".$id_horario."')";
                
    mysqli_query($conexion,$consulta) or die ($mysql->mysqli_error());
    mysqli_close($conexion);
 
?>