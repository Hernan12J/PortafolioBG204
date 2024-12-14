<!DOCTYPE html>
<html lang="en">
    
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Hospital ProSalud</title>
    <link rel="icon" type="image/png" sizes="16x16" href="public/images/logo3.png">
    <link href="https://fonts.googleapis.com/css?family=Lato:300,400,700&display=swap" rel="stylesheet">
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="public/css/style.css">
    <link rel="stylesheet" href="public/css/dev_frtv.css">
</head>

<body>
    <section class="ftco-section">
		<div class="container">
            <div class="row justify-content-center">
				<div class="col-md-6 text-center mb-5">
                    <img class="logologin" src="public/images/logologin1.png" alt="logo login">
				</div>
			</div>
			<div class="row justify-content-center">
				<div class="col-md-12 col-lg-10">
				    <div class="wrap d-md-flex">
						<div class="img" style="background-image: url(public/images/articulo.png);">
			        </div>
					<div class="login-wrap p-4 p-md-5">
			      	    <div class="d-flex">
			      		    <div class="w-100">
			      			    <h3 class="mb-4" style="font-weight: bold;">Iniciar Sesión</h3>
			      		    </div>	
			      	    </div>
                          <p class="<?php if (isset($_GET['t'])) echo $_GET['t']; ?>"> <?php if (isset($_GET['msg'])) echo $_GET['msg']; ?> </p>
						<form class="signin-form" method="POST" action="./?op=acceder">
                            <div class="form-group mb-3">
                                <label class="label" for="name">Email</label>
                                <input type="email" class="form-control" placeholder="Email" id="correo" name="correo" required>
                            </div>

                            <div class="form-group mb-3">
                                <label class="label" for="password">Contraseña</label>
                                <input type="password" class="form-control" placeholder="Contraseña" id="contrasena" name="contrasena" required>
                            </div>

                            <div class="form-group">
                                <button type="submit" class="form-control btn btn-primary rounded submit px-3">Ingresar</button>
                            </div>
                            <div class="form-group d-md-flex">
                                <div class="w-50 text-left">
                                    <label class="checkbox-wrap checkbox-primary mb-0">Recuérdame
                                        <input type="checkbox" value="remember-me" checked>
                                        <span class="checkmark"></span>
                                    </label>
                                </div>             
                            </div>
		                </form>
		            </div>
		        </div>
				</div>
			</div>
		</div>
	</section>

    <!-- FOOTER -->
    <div class="container">
        <footer class="py-3 my-4">
                <?php
                require_once('template/footer.php');
                ?>
        </footer>
    </div>





    <script src="public/js/bootstrap.bundle.min.js"></script>
    <script src="public/js/sidebars.js"></script>
</body>



</html>