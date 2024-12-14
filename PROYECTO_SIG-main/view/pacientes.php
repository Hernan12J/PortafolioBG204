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
            <p style="font-weight: bold; text-align:center;" class="<?php if (isset($_GET['t'])) echo $_GET['t']; ?>"> <?php if (isset($_GET['msg'])) echo $_GET['msg']; ?> </p>
            <div class="btns-paciente">
                <button class="btn btn-new-paciente" style="font-weight: bold;" type="button" data-bs-toggle="modal" data-bs-target="#exampleModal">
                    <img class="nuevo-paciente" src="public/images/nuevopaciente.png" alt="btn nuevo paciente">
                    Nuevo paciente
                </button>
            </div>

            <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog">
                    <div class="modal-content">
                    <div class="modal-header">
                        <h1 class="modal-title fs-5" id="exampleModalLabel">Datos del nuevo paciente</h1>
                        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                    <div class="modal-body">
                        <form class="modal-columnas" name="formulario" method="POST" action="./?op=registro" enctype="multipart/form-data">
                        <div class="mb-3">
                            <label for="noexpediente" class="col-form-label">No. Expediente:</label>
                            <input type="text" class="form-control" id="noexpediente" name="noexpediente" required>
                        
                            <label for="nombre" class="col-form-label">Nombre:</label>
                            <input type="text" class="form-control" id="nombre" name="nombre" required>
                        
                            <label for="apellido" class="col-form-label">Apellido:</label>
                            <input type="text" class="form-control" id="apellido" name="apellido" required>
                        
                            <label for="cedula" class="col-form-label">Cédula:</label>
                            <input type="text" class="form-control" id="cedula" name="cedula" required>
                        </div>
                        <div class="mb-3">
                            <label for="sexo" class="col-form-label">Sexo:</label>
                            <input type="text" class="form-control" id="sexo" name="sexo" required>
                        
                            <label for="fecha_nacimiento" class="col-form-label">Fecha de nacimiento:</label>
                            <input type="text" class="form-control" id="fecha_nacimiento" name="fecha_nacimiento" required>
                        
                            <label for="telefono" class="col-form-label">Teléfono:</label>
                            <input type="text" class="form-control" id="telefono" name="telefono" required>
                        
                            <label for="direccion" class="col-form-label">Dirección:</label>
                            <input type="text" class="form-control" id="direccion" name="direccion" required>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancelar</button>
                        <button type="submit" class="btn btn-primary">Guardar</button>
                    </div>
                    </form>
                    </div>
                </div>
            </div>

            <div class="white-box">
                <div class="d-md-flex mb-3">
                    <h2 class="box-title mb-1" style="color: #3c84fb;">Pacientes registrados</h2>
                </div>
                <div class="table-responsive">
                    <table class="table no-wrap tabla-pacientes">
                        <thead>
                            <tr>
                                <th class="border-top-0">NO. EXP.</th>
                                <th class="border-top-0">NOMBRE</th>
                                <th class="border-top-0">APELLIDO</th>
                                <th class="border-top-0">CÉDULA</th>
                                <th class="border-top-0">SEXO</th>
                                <th class="border-top-0">FECHA NAC.</th>  
                                <th></th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            <?php
                            foreach($paciente as $pacientes){
                            ?>
                                <tr>
                                    <td class="txt-oflo"><?php echo $pacientes->noexpediente; ?></td>
                                    <td class="txt-oflo"><?php echo $pacientes->nombre; ?></td>
                                    <td class="txt-oflo"><?php echo $pacientes->apellido; ?></td>
                                    <td class="txt-oflo"><?php echo $pacientes->cedula; ?></td>
                                    <td class="txt-oflo"><?php echo $pacientes->sexo; ?></td>
                                    <td class="txt-oflo"><?php echo $pacientes->fecha_nacimiento; ?></td>
                                    <td >
                                        <a class="btn-ver" href="?op=pPerfilPaciente&id=<?php echo $pacientes->noexpediente; ?>">Ver</a>
                                    </td>
                                    <td >
                                        <a class="btn-trash" href="?op=eliminarpaciente&id=<?php echo $pacientes->noexpediente; ?>">Eliminar</a>
                                    </td>
                                </tr>
                            <?php
                            }
                            ?>
                        </tbody>
                    </table>
                </div>
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