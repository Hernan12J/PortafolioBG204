<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Hospital ProSalud</title>
    <link rel="icon" type="image/png" sizes="16x16" href="public/images/logo3.png">
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
        
        <!-- MAIN -->
        <div class="col-lg-8 col-xlg-9 col-md-7 perfil-admin">
            <div class="card">
                <div class="card-body">
                    <div class="perfil-doctor-size">
                        <img class="perfil-doctor" src="public/images/users/doctor.png" alt="logo_doctor">
                    </div>
                    <form name="formulario" class="form-horizontal form-material mx-2" method="POST" action="./?op=pPerfilDoctor" enctype="multipart/form-data">
                        <div class="form-group">
                            <label class="col-md-12">Nombre</label>
                            <div class="col-md-12">
                                <input type="email" placeholder=" José"
                                    class="form-control form-control-line" name="example-email"
                                    id="example-email"
                                    value="" disabled>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-md-12">Apellido</label>
                            <div class="col-md-12">
                                <input type="text" placeholder=" Pérez"
                                    class="form-control form-control-line" name="example-email"
                                    id="example-email"
                                    value="" disabled>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="example-email" class="col-md-12">Email</label>
                            <div class="col-md-12">
                                <input type="email" placeholder=" jperez@gmail.com"
                                    class="form-control form-control-line" name="example-email"
                                    id="example-email"
                                    value="" disabled>
                            </div>
                        </div>              
                        <div class="form-group">
                            <div class="col-sm-12">
                                <button class="btn btn-success text-white">Actualizar perfil</button>
                            </div>
                        </div>
                    </form>
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