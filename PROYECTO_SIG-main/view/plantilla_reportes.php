<?php
require('fpdf/fpdf.php');
date_default_timezone_set('America/El_Salvador');
class PDF extends FPDF
{

function Header()
{

}

function Footer()
{
    
}


}



$pdf = new PDF();
$pdf->AliasNbPages();

// Primera forma de hacerlo
$pdf->AddPage('P');


// Segunda forma de hacerlo
// $pdf=new FPDF('P','mm',array(100,200));
// $pdf->AddPage();

/* Añadimos el nuevo tipo de letra */
$pdf->AddFont('helveticab','','helveticab.php');
$pdf->AddFont('helvetica','','helvetica.php');
/* Declaramos que queremos usar ese tipo de letra */
$pdf->SetFont('helveticab','',12);
/* Lo imprimimos */
$pdf->Cell(200,10,'HOSPITAL PROSALUD',0,1,'C',0);

$pdf->SetFont('helvetica','',10);
$pdf->Cell(200,5,'Punta Pacifica, Panama',0,1,'C',0);
$pdf->Cell(200,5,'hospitalprosalud@gmail.com',0,1,'C',0);
$pdf->Cell(200,5,'Tel. 388-5542 ',0,1,'C',0);

$pdf->SetFont('helveticab','',12);
$pdf->Cell(200,30,'Reporte Graficas ',0,1,'C',0);


$grafico=$_POST['variable'];

$img = explode(',',$grafico,2)[1];
$pic = 'data://text/plain;base64,'. $img;
$pdf->image($pic, 0,90,250,0,'png');

$pdf->Image("../public\images\logo1.png",0,0, 50, 50);
$pdf->Image("../public\images\cantidadpacientes.PNG",25,60, 50, 20);

$pdf->Cell(0,40,'________________________________________________________________________________',0,1,'C',0);

$pdf->Output();
?>