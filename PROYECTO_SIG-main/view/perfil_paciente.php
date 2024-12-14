<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Hospital ProSalud</title>
    <link rel="icon" type="image/png" sizes="16x16" href="public/images/logo3.png">
    <link rel="stylesheet" href="public/css/dev_frtv.css">
    <link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css'>
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
            <div class="row">
                <div class="col-12">
                    <div class="card">
                        <div class="card-body">
                            <h6>Datos del paciente</h6>
                            <form action="./?op=pPerfilPaciente" method="POST">
                                <input type="text" name="nombre" value="<?php echo $paciente->nombre; ?> <?php echo $paciente->apellido; ?>" disabled>
                                <input type="text" name="cedula" value="<?php echo $paciente->cedula; ?>" disabled>
                                <input type="text" name="fecha_nacimiento" value="<?php echo $paciente->fecha_nacimiento; ?>" disabled>
                                <input type="text" name="telefono" value="<?php echo $paciente->telefono; ?>" disabled>
                                <input type="text" name="direccion" value="<?php echo $paciente->direccion; ?>" disabled>
                            </form>
                            
                        </div>
                    </div>
                </div>
            </div>

            <ul class="nav nav-tabs">
                <li class="nav-item" role="presentation">
                    <a class="nav-link active" id="pills-company-tab" data-toggle="pill" href="#pills-company" role="tab" aria-controls="pills-company" aria-selected="true">Historial clínico</a>
                </li>
                <li class="nav-item" role="presentation">
                    <a class="nav-link" id="pills-product-tab" data-toggle="pill" href="#pills-product" role="tab" aria-controls="pills-product" aria-selected="false">Orden médica</a>
                </li>
            </ul>

            <div class="tab-content" id="pills-tabContent">
                <div class="tab-pane fade show active" id="pills-company" role="tabpanel" aria-labelledby="pills-company-tab">
                    <div class="container-fluid">
                        <form action="./?op=registroHistorialC" method="POST" enctype="multipart/form-data">
                            <br>
                            <h4 style="color: #3c84fb;">Motivo de la consulta</h4>
                            <input type="text" class="form-control" id="motivo_consulta" name="motivo_consulta" required>
                            <br>
                            <h4 style="color: #3c84fb;">Enfermedades y antecedentes</h4>
                            <label style="font-weight: bold;" for="enfermedad" >Enfermedad actual:</label>
                            <input type="text" class="form-control" id="enfermedad" name="enfermedad" required>
                            <div class="modal-columnas">
                                <div class="div">
                                    <label style="font-weight: bold;" for="ante_fam" >Antecedentes familiares:</label>
                                    <input type="text" class="form-control" id="ante_fam" name="ante_fam" required>
                                </div>
                                <div class="div">
                                    <label style="font-weight: bold;" for="ante_personales" >Antecedentes personales:</label>
                                    <input type="text" class="form-control" id="ante_personales" name="ante_personales" required>
                                </div>
                            </div>
                            <br>
                            <h4 style="color: #3c84fb;">Examen Físico</h4>
                            <div class="todo-horizontal">
                                <div class="div">
                                    <label style="font-weight: bold;" for="estatura" >Estatura:</label>
                                    <input type="text" class="form-control size-control" id="estatura" name="estatura" placeholder="mts" required>
                                </div>
                                <div class="div">
                                    <label style="font-weight: bold;" for="peso" >Peso:</label>
                                    <input type="text" class="form-control size-control" id="peso" name="peso" placeholder="lbs" required>
                                </div>
                                <div class="div">
                                    <label style="font-weight: bold;" for="fr" >FR:</label>
                                    <input type="text" class="form-control size-control" id="fr" name="fr" required>
                                </div>
                                <div class="div">
                                    <label style="font-weight: bold;" for="fc" >FC:</label>
                                    <input type="text" class="form-control size-control" id="fc" name="fc" required>
                                </div>
                                <div class="div">
                                    <label style="font-weight: bold;" for="temperatura" >Temp:</label>
                                    <input type="text" class="form-control size-control" id="temperatura" name="temperatura" required>
                                </div>
                                <div class="div">
                                    <label style="font-weight: bold;" for="ta" >TA:</label>
                                    <input type="text" class="form-control size-control" id="ta" name="ta" required>
                                </div>
                            </div>
                            <br>
                            <h4 style="color: #3c84fb;">Diagnóstico</h4>
                            <input type="text" class="form-control" id="diagnostico" name="diagnostico" required>
                            <br>
                            <div class="d-md-flex justify-content-md-center">
                                <button type="submit" class="btn btn-primary">REGISTRAR</button>
                            </div>
                        </form>
                    </div>
                </div>
                <div class="tab-pane fade" id="pills-product" role="tabpanel" aria-labelledby="pills-product-tab">
                    <div class="container-fluid">
                        <form name="formulario" method="POST" action="./?op=registroOrdenesM" enctype="multipart/form-data">
                            <br>
                            
                            <h5>Tratamiento</h5>
                            <input type="text" class="form-control" id="tratamiento" name="tratamiento">

                            <br>

                            <h5>Indicaciones</h5>
                            <textarea class="form-control" id="indicaciones" name="indicaciones" rows="3"></textarea>

                            <div class="d-grid gap-2 d-md-flex justify-content-md-end btns-form">
                                <a href="?op=pPacientes">
                                    <button class="btn btn-secondary me-md-2" type="button">Cancelar</button>
                                </a>
                                <button class="btn btn-primary" type="submit">Enviar correo</button>
                            </div>
                        </form>
                    </div>
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
    <script src='https://code.jquery.com/jquery-3.5.1.slim.min.js'></script>
    <script src='https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js'></script>
</body>
</html>