<?php

    if ($_SESSION["acceso"] != true) {
        header('Location: ?op=error');
    }

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Hospital ProSalud</title>
    <link rel="icon" type="image/png" sizes="16x16" href="public/images/logo3.png">
    <link rel="stylesheet" href="public/css/dev_frtv.css">
</head>
<body>

    <!-- HEADER -->
    <header class="fondo-header header-pos">
        <?php
        require_once('template/header.php');
        ?>
    </header>

    
    <!-- NAVEGACION -->
    <main class="d-flex flex-nowrap contenedor">
        <?php
        require_once('template/navegacion.php');
        ?>
        
        <div class="datos">
            <h4>Datos del paciente</h4>
            <div class="datos-paciente">
                <div class="input-group pacientes-size">
                    <select class="form-select" id="inputGroupSelect04" aria-label="Example select with button addon">
                        <option disabled selected>Selecciona el paciente</option>
                        <option value="1">One</option>
                        <option value="2">Two</option>
                        <option value="3">Three</option>
                    </select>
                    <button class="btn btn-outline-primary" type="button">Aceptar</button>
                </div>
                <form>
                    <fieldset disabled>
                        <div class="datos-des">
                            <input type="text" id="disabledTextInput" class="form-control" placeholder="Nombre" >
                            <input type="text" id="disabledTextInput" class="form-control" placeholder="Cédula">
                        </div>
                    </fieldset>
                </form>
            </div>

            <hr>

            <h4>Diagnóstico</h4>
            <input type="text" class="form-control">

            <hr>

            <h4>Orden médica</h4>
            <input type="text" class="form-control">

            <hr>

            <h4>Indicaciones</h4>
            <textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>

            <div class="d-grid gap-2 d-md-flex justify-content-md-end btns-form">
                <a href="?op=pPacientes">
                    <button class="btn btn-secondary me-md-2" type="button">Cancelar</button>
                </a>
                <button class="btn btn-primary" type="button">Finalizar</button>
            </div>

        </div>
        
    </main>
    <!-- FOOTER -->
    <div class="container">
        <footer class="py-3 my-4">
                <?php
                require_once('template/footer.php');
                ?>
        </footer>
    </div>

</body>
</html>