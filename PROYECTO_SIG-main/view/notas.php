<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Notas de las Enfermeras</title>

    <link rel="stylesheet" href="public/css/notas.css">
</head>
<body>
    
    <form action="" class="notas">
        <section class="todo">
        <section class="izquier">

            <label for="nomEnfer">Nombre del/la Enfermero/a</label><br>
            <input type="text" class="datos" name="nomEnfer" id=""><br>

            <label for="descrip">Descripción General</label><br>
            <textarea name="descrip" id="" class="datos descripcion" cols="50" rows="15"></textarea><br>

        </section>
        <section class="dere">

            <label for="nomPaci">Nombre del/la Paciente</label><br>
            <input type="text" class="datos" name="nomPaci" id=""><br>

            <label for="Telef">Número de Teléfono</label><br>
            <input type="tel" class="datos" name="Telef" id=""><br>

            <label for="alerg">Alergias</label><br>
            <input type="text" class="datos" name="alerg" id=""><br>

            <label for="tratam">Tratamiento Actual</label><br>
            <input type="text" class="datos" name="tratam" id=""><br>

            <label for="fecha">Fecha de Ingreso</label><br>
            <input type="datetime-local" class="datos" name="fecha" id=""><br>

        </section>
        </section>
    </form>


</body>
</html>