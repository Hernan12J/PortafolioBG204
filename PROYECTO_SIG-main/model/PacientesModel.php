<?php

class Paciente{

    private $pdo;

    public $noexpediente;
    public $nombre;
    public $apellido;
    public $cedula;
    public $sexo;
    public $fecha_nacimiento;
    public $telefono;
    public $direccion;

    public function __construct()
    {
        try {
            $this->pdo = DB::DBStart();
        } catch (Exception $e) {
            die($e->getMessage());
        }
    }

    public function ObtenerPacientes(){
        try{
            $paciente = $this->pdo->prepare("SELECT * FROM paciente");
            $paciente->execute();
            return $paciente->fetchAll(PDO::FETCH_OBJ);
        } catch (Exception $e) {
            die($e->getMessage());
        }
    }

    public function ObtenerUnPaciente($id) {
		try {
			$stm = $this->pdo
			          ->prepare("SELECT * FROM paciente WHERE noexpediente = ?");
			          

			$stm->execute(array($id));
			return $stm->fetch(PDO::FETCH_OBJ);
		} catch (Exception $e) {
			die($e->getMessage());
		}
	}

    public function EliminarUnPaciente($id) {
		try {
			$stm = $this->pdo
			          ->prepare("DELETE FROM paciente WHERE noexpediente = ?");
			          

			$stm->execute(array($id));
			return $stm->fetch(PDO::FETCH_OBJ);
		} catch (Exception $e) {
			die($e->getMessage());
		}
	}

    public function RegistrarPaciente(paciente $data){
        try{
            $sql = "INSERT INTO paciente (id_doctor, noexpediente,nombre,apellido,cedula,sexo,fecha_nacimiento,telefono,direccion)
                    VALUES (1, ?, ?, ?, ?, ?, ?, ?, ?)";

            $this->pdo->prepare($sql)
                 ->execute(
                    array(
                        $data->noexpediente,
                        $data->nombre,
                        $data->apellido,
                        $data->cedula,
                        $data->sexo,
                        $data->fecha_nacimiento,
                        $data->telefono,
                        $data->direccion
                    )
                );
        $this->msg="Su registro se ha guardado exitosamente!&t=text-success";
        } catch (Exception $e){
            die($e->getMessage());
        }
    }

    public function HistorialClinico(paciente $data){
        try{
            $sql = "INSERT INTO historial_clinico (motivo_consulta,enfermedad,ante_fam,ante_personales,estatura,peso,fr,fc,temperatura,ta,diagnostico) 
                    VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

            $this->pdo->prepare($sql)
                 ->execute(
                    array(
                        $data->motivo_consulta,
                        $data->enfermedad,
                        $data->ante_fam,
                        $data->ante_personales,
                        $data->estatura,
                        $data->peso,
                        $data->fr,
                        $data->fc,
                        $data->temperatura,
                        $data->ta,
                        $data->diagnostico
                    )
                );
        $this->msg="registro guardado exitosamente!&t=text-success";
        } catch (Exception $e){
            die($e->getMessage());
        }
    }

    public function OrdenesMedicas(paciente $data){
        try{
            $sql = "INSERT INTO ordenes_medicas (tratamiento, indicaciones)
                    VALUES (?, ?)";

            $this->pdo->prepare($sql)
                 ->execute(
                    array(
                        $data->tratamiento,
                        $data->indicaciones
                    )
                );
        $this->msg="Su registro se ha guardado exitosamente!&t=text-success";
        } catch (Exception $e){
            die($e->getMessage());
        }
    }
}

?>