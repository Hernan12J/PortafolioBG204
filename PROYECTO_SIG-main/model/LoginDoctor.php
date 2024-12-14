<?php

include 'model/db.php';

class Doctor{

    public $pdo;

    public $correo;
    public $contrasena;
    public $nombre;
    public $apellido;

    public function __construct() {
        try {
            $this->pdo = DB::DBStart();
        } catch (Exception $e) {
            die($e->getMessage());
        }
    }

    public function ValidarDoctor(doctor $data) {
        try {
            $sql = "SELECT * FROM credenciales WHERE correo=? AND contrasena=?";
            $stm = $this->pdo->prepare($sql);
            $stm->execute(array(
                $data->correo,
                $data->contrasena
            ));

            return $stm->fetch(PDO::FETCH_OBJ);
        } catch (Exception $e) {
            die($e->getMessage());
        }
    }

    public function Obtener($id)
    {
        try {
            $sql = "SELECT * FROM doctor WHERE id=?";
            $stm = $this->pdo->prepare($sql);
            $stm->execute(array(
                $id
            ));

            return $stm->fetch(PDO::FETCH_OBJ);
        } catch (Exception $e) {
            die($e->getMessage());
        }
    }

    public function PerfilDoctor(doctor $data){
        try{
            $sql = "SELECT * FROM doctor";

            $this->pdo->prepare($sql)
                 ->execute(
                    array(
                        $data->nombre,
                        $data->apellido
                    )
                );
        $this->msg="Su registro se ha Actualizado exitosamente!&t=text-success";
        } catch (Exception $e){
            die($e->getMessage());
        }
    }
}

?>