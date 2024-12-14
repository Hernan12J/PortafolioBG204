<?php
session_start();

//Librería para enviar email
use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\SMTP;
use PHPMailer\PHPMailer\Exception;

require 'public/phpmailer/src/Exception.php';
require 'public/phpmailer/src/PHPMailer.php';
require 'public/phpmailer/src/SMTP.php';

include 'model/LoginDoctor.php';
include 'model/PacientesModel.php';

class Controller{

    private $pdo;
    private $resp;
    private $LoginDoctor;
    private $pacientesModel;

    public function __construct() {
        $this->LoginDoctor = new Doctor();
        $this->pacientesModel = new Paciente();
    }

    public function Index(){
        require('view/login.php');
    }

    public function Login()
    {
        require('view/login.php');
    }

    public function Perfil(){
        require('view/perfil.php');
    }

    public function Reportes(){
        require('view/reportes.php');
    }

    public function PerfilPacientes(){
        $paciente = new Paciente();
        $paciente = $this->pacientesModel->ObtenerUnPaciente($_GET['id']);
        require('view/perfil_paciente.php');
    }

    public function EliminarPaciente(){
        $paciente = new Paciente();
        $this->resp = $this->pacientesModel->EliminarUnPaciente($_GET['id']);
        header('Location: ?op=pPacientes'.$this->resp);
    }

    public function OrdenesMedicas(){
        require('view/ordenes_medicas.php');
    }

    public function Pacientes(){

        if ($_SESSION['acceso'] != true) {
            require('view/login.php');
        }else{
            $paciente = new Paciente();
            $paciente = $this->pacientesModel->ObtenerPacientes();
            require('view/pacientes.php');
        }
    }

    public function Guardar(){
        $paciente = new Paciente();

        $paciente->noexpediente = $_REQUEST['noexpediente'];
        $paciente->nombre = $_REQUEST['nombre'];
        $paciente->apellido = $_REQUEST['apellido'];
        $paciente->cedula = $_REQUEST['cedula'];
        $paciente->sexo = $_REQUEST['sexo'];
        $paciente->fecha_nacimiento = $_REQUEST['fecha_nacimiento'];
        $paciente->telefono = $_REQUEST['telefono'];
        $paciente->direccion = $_REQUEST['direccion'];

        $this->resp = $this->pacientesModel->RegistrarPaciente($paciente);

        header('Location: ?op=pPacientes'.$this->resp);
    }

    public function GuardarHistorialC(){
        $paciente = new Paciente();

        $paciente->motivo_consulta = $_REQUEST['motivo_consulta'];
        $paciente->enfermedad = $_REQUEST['enfermedad'];
        $paciente->ante_fam = $_REQUEST['ante_fam'];
        $paciente->ante_personales = $_REQUEST['ante_personales'];
        $paciente->estatura = $_REQUEST['estatura'];
        $paciente->peso = $_REQUEST['peso'];
        $paciente->fr = $_REQUEST['fr'];
        $paciente->fc = $_REQUEST['fc'];
        $paciente->temperatura = $_REQUEST['temperatura'];
        $paciente->ta = $_REQUEST['ta'];
        $paciente->diagnostico = $_REQUEST['diagnostico'];

        $this->resp = $this->pacientesModel->HistorialClinico($paciente);

        header('Location: ?op=pPacientes&msg=Historial clinico registrado&t=text-success');
    }

    public function GuardarOrdenesM(){
        $paciente = new Paciente();

        $paciente->tratamiento = $_REQUEST['tratamiento'];
        $paciente->indicaciones = $_REQUEST['indicaciones'];
        
        $this->resp = $this->pacientesModel->OrdenesMedicas($paciente);
        
        header('Location: ?op=pPacientes&msg=Tratamiento medico enviado con exito&t=text-success'.$this->resp);


        // ENVIAR EMAIL
        if(isset($_POST['tratamiento']) && isset($_POST['indicaciones']))

        $paciente->tratamiento = $_POST['tratamiento'];
        $paciente->indicaciones = $_POST['indicaciones'];

        $mail = new PHPMailer(true);

        try {
            //Server settings
            $mail->SMTPDebug = SMTP::DEBUG_SERVER;                      //Enable verbose debug output
            $mail->isSMTP();                                            //Send using SMTP
            $mail->Host       = 'smtp.gmail.com';                     //Set the SMTP server to send through
            $mail->SMTPAuth   = true;                                   //Enable SMTP authentication
            $mail->Username   = 'fernando.trejos10g@gmail.com';                     //SMTP username
            $mail->Password   = 'pfppvsgzfpzypimt';                               //SMTP password
            $mail->SMTPSecure = PHPMailer::ENCRYPTION_SMTPS;            //Enable implicit TLS encryption
            $mail->Port       = 465;                                    //TCP port to connect to; use 587 if you have set `SMTPSecure = PHPMailer::ENCRYPTION_STARTTLS`

            //Recipients
            $mail->setFrom('fernando.trejos10g@gmail.com', 'Hospital ProSalud');
            $mail->addAddress('fernando.trejos@utp.ac.pa', 'Mailer');     //Add a recipient

            $mensajeHTML='
                <h2 align="left"><b>A continuaci&oacute;n est&aacute;n las indicaciones de su doctor: </b> <br></h2>
                <p align="left"><b>Tratamiento:</b> '.$paciente->tratamiento.'<br> <b>Indicaciones:</b> '.$paciente->indicaciones.'</p>';


            $mail->isHTML(true);                                  //Set email format to HTML
            $mail->Subject = 'TRATAMIENTO MEDICO';
            $mail->Body    = $mensajeHTML;
            // $mail->AltBody = 'This is the body in plain text for non-HTML mail clients';

            $mail->send();
            echo 'Mensaje enviado con exito';
        } catch (Exception $e) {
            echo "Message could not be sent. Mailer Error: {$mail->ErrorInfo}";
        }
    }

    public function ValidarDoctor() {
        $LoginData = new Doctor();

        $LoginData->correo = $_REQUEST['correo'];
        $LoginData->contrasena = $_REQUEST['contrasena'];

        if ($resp = $this->LoginDoctor->ValidarDoctor($LoginData)) {
            $_SESSION['user_id'] = $resp->id_doctor;

            $datos = $this->LoginDoctor->Obtener($_SESSION['user_id']);

            $_SESSION['acceso'] = true;
            $_SESSION['user_name'] = $datos->nombre . " " . $datos->apellido;
            header('Location: ?op=pPacientes');
        } else {
            header('Location: ?op=pLogin&msg=Correo ó contraseña incorrectos&t=text-danger');
        }
    }

    
    public function CerrarSesion() {
        @session_destroy();
        require('view/login.php');
    }

}

?>