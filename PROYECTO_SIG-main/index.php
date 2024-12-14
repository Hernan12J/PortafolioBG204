<?php

require('./controller/controller.php');

$controller = new Controller;

if(isset($_GET['op'])){
    $opcion = $_GET['op'];

    if($opcion == "pPerfil"){
        $controller->Perfil();

    }else if ($opcion == "pLogin"){
        $controller->Login();

    }else if ($opcion == "acceder"){
        $controller->ValidarDoctor();
    
    }else if ($opcion == "pOrdenesMedicas"){
        $controller->OrdenesMedicas();

    }else if ($opcion == "pPacientes"){
        $controller->Pacientes();

    }else if ($opcion == "eliminarpaciente"){
        $controller->EliminarPaciente();
    
    }else if ($opcion == "pPerfilPaciente"){
        $controller->PerfilPacientes();

    }else if ($opcion == "registro"){
        $controller->Guardar();

    }else if ($opcion == "registroHistorialC"){
        $controller->GuardarHistorialC();

    }else if ($opcion == "registroOrdenesM"){
        $controller->GuardarOrdenesM();

    }else if ($opcion == "pSalir"){
        $controller->CerrarSesion();

    }else if ($opcion == "pReportes"){
        $controller->Reportes();
    }
    
}else{
    $controller->Index();
}