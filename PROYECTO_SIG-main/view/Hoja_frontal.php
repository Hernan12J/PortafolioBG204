<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <link rel="stylesheet" href="view/style.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Source+Serif+Pro&display=swap" rel="stylesheet">

    <title>Hoja Frontal</title>
  </head>
  <body class="bg-white">
  
    <h1  style="text-align:center">Hoja Frontal</h1>
    <br>
    <section>
    <label for="nombre" class="form-label">Nombre: </label>
        <input type="text" id="nombre" name="nombre" class="col-md-6" required>

        <br>

        <label for="seguro_paciente" class="form-label">Numero de seguro: </label>
        <input type="text" id="seguro_paciente" name="seguro_paciente" class="col-md-6"required>

        <br>

        <label for="edad_paciente" class="form-label">Edad: </label>
        <input type="number" id="edad_paciente" name="edad_paciente" class="col-md-6"required>

        <br>

        <label for="cama_paciente" class="form-label">Cama: </label>
        <input type="number" id="cama_paciente" name="cama_paciente" class="col-md-6"required>

        <br>

        <label for="diagnóstico_paciente" class="form-label">Diagnóstico: </label>
        <input type="text" id="diagnóstico_paciente" name="diagnóstico_paciente" class="col-md-6"required>

        <br>

        <label for="servicio_paciente" class="form-label">Servicio: </label>
        <input type="text" id="servicio_paciente" name="servicio_paciente" class="col-md-6"required>

        <br>

        <label for="medico_paciente" class="form-label">Médico: </label>
        <input type="text" id="medico_paciente" name="medico_paciente" class="col-md-6"required>

        <br>

        <label for="fecha_paciente" class="form-label">Fecha de ingreso: </label>
        <input type="date" id="fecha_paciente" name="fecha_paciente" class="col-md-6"required>
    </section>

    <button type="submit" class="btn-style">Guardar Datos</button>
       

    <footer>
        <h5 class="text-center">Hernán Hernández 1LS-131</h5>
    </footer>

    <!-- Optional JavaScript; choose one of the two! -->

    <!-- Option 1: Bootstrap Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>

    <!-- Option 2: Separate Popper and Bootstrap JS -->
    <!--
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js" integrity="sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF" crossorigin="anonymous"></script>
    -->
  </body>
</html>