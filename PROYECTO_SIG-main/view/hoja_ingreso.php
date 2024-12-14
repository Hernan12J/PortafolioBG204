<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">

    <title>Hoja de Ingreso</title>
  </head>
  <body>
    <br>
    <h1 class="text-center font-weight-bold mb-4">Hoja de Ingreso</h1>

    <section>
    <div class="px-lg-5 py-lg-4 p-4">
    <form method="POST" action="">
        
                        <div class="mb-3">
                          <label for="exampleInputEmail1" class="form-label font-weight-bold">Nombre</label>
                          <input Required type="Text" class="form-control bg-dark-x border-0" placeholder="Nombre del paciente" id="nombre" name="nombre" aria-describedby="nombre">                        
                        </div>

                        <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label font-weight-bold">Apellido</label>
                        <input Required type="Text" class="form-control bg-dark-x border-0" placeholder="Aapellido del paciente" id="apellido" name="apellido" aria-describedby="apellido">
                        </div>

                        <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label font-weight-bold">Edad</label>
                        <input Required type="number" class="form-control bg-dark-x border-0" placeholder="Edad del paciente" id="edad" name="edad" aria-describedby="edad">
                        </div>

                        <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label font-weight-bold">Fecha de nacimiento</label>
                        <input Required type="Date" class="form-control bg-dark-x border-0" placeholder="Fecha de nacimiento" id="fecha_Naci" name="fecha_Naci" aria-describedby="fecha_Naci">
                        </div>

                        <h2>Datos de ingreso</h2>
                        <br>

                        <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label font-weight-bold">Fecha</label>
                        <input Required type="Date" class="form-control bg-dark-x border-0" placeholder="fecha de ingreso" id="fecha_Ingreso" name="fecha_Ingres" aria-describedby="fecha_Ingres">
                        </div>

                        <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label font-weight-bold">Hora</label>
                        <input Required type="time" class="form-control bg-dark-x border-0" placeholder="Hora de ingreso" id="hora_ingreso" name="hora_ingreso" aria-describedby="hora_ingreso">
                        </div>

                        <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label font-weight-bold">Cama</label>
                        <input  type="number" class="form-control bg-dark-x border-0" placeholder="Cama de ingreso" id="cama_ingreso" name="cama_ingreso" aria-describedby="cama_ingreso">
                        </div>

                        <label for="exampleInputEmail1" class="form-label font-weight-bold">Modalidad Asistencial: </label>
                        <select Required class="form-select" aria-label="Default select example">
                        <option selected>N/A</option>
                        <option value="1">Hospitalización</option>
                        <option value="2">Hospital de Día Médico</option>
                        <option value="3">Hospital de Día Quirúrgico</option>
                        </select>

                        <label for="exampleInputEmail1" class="form-label font-weight-bold">Motivo del Ingreso:</label>
                        <select Required class="form-select" aria-label="Default select example">
                        <option selected>N/A</option>
                        <option value="1">Urgente</option>
                        <option value="2">Programado</option>
                        </select>

                        <label for="exampleInputEmail1" class="form-label font-weight-bold">Procedencia del Ingreso:</label>
                        <select Required class="form-select" aria-label="Default select example">
                        <option value="1">Consultas</option>
                        <option value="2">Urgencias </option>
                        <option value="3">Lista de Espera Quirúrgica </option>
                        <option value="4">Hospital de Día Médico </option>
                        <option value="5">Hospital de Día Quirúrgico </option>
                        <option value="6">Otra área Hospitalaria </option>
                        <option value="7">Nacidos en el Hospital </option>
                        <option value="8">Hospitalización </option>
                        <option value="9">Hospital a domicilio </option>
                        <option value="10">Orden Judicial </option>
                        </select>
                        <br>

                        <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label font-weight-bold">U.F. Solic / Responsable:</label>
                        <input Required type="text" class="form-control bg-dark-x border-0" placeholder="U.F. Solic / Responsable:" id="responsable" name="responsable" aria-describedby="responsable">
                        </div>

                        <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label font-weight-bold">Prof. Solic / Responsable:</label>
                        <input Required type="text" class="form-control bg-dark-x border-0" placeholder="Prof. Solic / Responsable:" id="responsable_1" name="responsable_1" aria-describedby="responsable_1">
                        </div>

                       
                        <button type="submit" class="btn btn-primary">Guardar datos</button>
                      </form>

</div>
    </section>

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