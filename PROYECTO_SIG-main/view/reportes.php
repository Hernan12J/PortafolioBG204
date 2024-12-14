<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Hospital ProSalud</title>
    <link rel="icon" type="image/png" sizes="16x16" href="public/images/logo3.png">
    <link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css'>
    <!-- Google Charts -->
    <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
    <!-- Script para crear el grafico -->
    <script type="text/javascript">
        google.charts.load("current", {
            packages: ["corechart"]
        });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {
            var data = google.visualization.arrayToDataTable([
                ['Task', 'Cantidad de hombres y mujeres'],
                ['Hombres', 4],
                ['Mujeres', 6]
            ]);

            var options = {
                title: 'Total de pacientes por género',
                is3D: true,
            };

            var chart = new google.visualization.PieChart(document.getElementById('grafico'));
            chart.draw(data, options);

            document.getElementById('variable').value = chart.getImageURI();
        }

    </script>
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
            <div class="container mt-5">
                <form action="view/plantilla_reportes.php" method="POST">
                    <div class="reportes">
                    <h1>Reportes de Actividad</h1>
                        <div class="card text-bg-primary mb-3" style="max-width: 18rem; max-height:10rem;">
                            <div style="font-size: 1.5rem; text-align:center;" class="card-header">Total de pacientes</div>
                            <div class="card-body total-pacientes">
                                <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-users" width="80" height="80" viewBox="0 0 24 24" stroke-width="2" stroke="#ffffff" fill="none" stroke-linecap="round" stroke-linejoin="round">
                                    <path stroke="none" d="M0 0h24v24H0z" fill="none" />
                                    <circle cx="9" cy="7" r="4" />
                                    <path d="M3 21v-2a4 4 0 0 1 4 -4h4a4 4 0 0 1 4 4v2" />
                                    <path d="M16 3.13a4 4 0 0 1 0 7.75" />
                                    <path d="M21 21v-2a4 4 0 0 0 -3 -3.85" />
                                </svg>
                                <span style="font-size: 3rem;" class="text-white">10</span>
                            </div>
                        </div>
                        
                    </div>

                    <input type="hidden" name="variable" id="variable">
                    <div class="mb-4" id="grafico" style="width: 100%; height: 400px;"></div>

                    <div class="btn-centro" style="text-align: center;">
                        <button class="btn" style="background-color: darkslategray; color:white;" type="submit">
                            <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-report-medical" width="30" height="30" viewBox="0 0 24 24" stroke-width="1.5" stroke="#ffffff" fill="none" stroke-linecap="round" stroke-linejoin="round">
                                <path stroke="none" d="M0 0h24v24H0z" fill="none" />
                                <path d="M9 5h-2a2 2 0 0 0 -2 2v12a2 2 0 0 0 2 2h10a2 2 0 0 0 2 -2v-12a2 2 0 0 0 -2 -2h-2" />
                                <rect x="9" y="3" width="6" height="4" rx="2" />
                                <line x1="10" y1="14" x2="14" y2="14" />
                                <line x1="12" y1="12" x2="12" y2="16" />
                            </svg>
                            GENERAR REPORTE
                        </button>
                    </div>
                </form>
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