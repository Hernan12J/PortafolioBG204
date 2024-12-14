package com.example.frograming;

import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.media.MediaPlayer;
import android.net.Uri;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.ProgressBar;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.example.frograming.Helpers.Jugabilidad;
import com.example.frograming.Helpers.MultimediaConcatURL;
import com.example.frograming.Helpers.SharedPreferencesController;
import com.example.frograming.Modelos.PreguntasResponse;
import com.google.android.material.appbar.MaterialToolbar;

import java.io.IOException;
import java.util.List;
public class Modo2_Activity extends AppCompatActivity {



    String opcionRes[]= new String[4];
    String RetroCorrecta;
    String RetroIncorrecta;
    int correcto=0;
    int id;
    SharedPreferencesController controlP = new SharedPreferencesController();
    SharedPreferences puntos, progresoSh;

    String urlBase = new MultimediaConcatURL().toCompleteURL("");
    String audioPregunta = "";
    String audioRetro="";
    String audiosUrl[] = new String[4];
    String audiosRetroUrl[] = new String[4];

    // decalarando las variable globales
    int progreso=0;
    MaterialToolbar toolbar;
    RadioButton jugabilidad1_tipo2_opcion1, jugabilidad1_tipo2_opcion2, jugabilidad1_tipo2_opcion3, jugabilidad1_tipo2_opcion4;
    ImageView jugabilidad1_Luna, jugabilidad1_audio, jugabilidad1_home;
    TextView jugabilidad1_pregunta;
    ImageButton jugabilidad1_img_audio;
    Button btn_continuar;
    RadioGroup grupo_opciones;
    ProgressBar jugabilidad1_progreso2;
    SharedPreferencesController sp = new SharedPreferencesController();
    private MediaPlayer mediaPlayer, mediaPlayerP;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_modo2);

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

        this.InicializarControle();
        this.ClickButton();
        this.obtenerInfoPregunta();
    }


    // Inicializacion de controles
    private void InicializarControle(){
        toolbar = (MaterialToolbar) findViewById(R.id.topAppBar);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                onBackPressed();
            }
        });

        //RadioButton-respuestas
        jugabilidad1_tipo2_opcion1 = (RadioButton) findViewById(R.id.txtopcion1);
        jugabilidad1_tipo2_opcion2 = (RadioButton) findViewById(R.id.txtopcion2);
        jugabilidad1_tipo2_opcion3 = (RadioButton) findViewById(R.id.txtopcion3);
        jugabilidad1_tipo2_opcion4 = (RadioButton) findViewById(R.id.txtopcion4);
        grupo_opciones = (RadioGroup)findViewById(R.id.opciones);
        //ImageView

        jugabilidad1_Luna = (ImageView) findViewById(R.id.Luna);
        // ImageButton
        jugabilidad1_img_audio = (ImageButton) findViewById(R.id.jugabilidad1_img_audio);

        // TextView- Pregunta
        jugabilidad1_pregunta = (TextView) findViewById(R.id.txtpregunta);
        // aqui se carga la pregunta la pantalla
        btn_continuar = (Button) findViewById(R.id.jugabilidad1_tipo2_btn_continuar);
        this.jugabilidad1_progreso2 =(ProgressBar) findViewById(R.id.Jugabilidad1_ProgresBar2);
        puntos = getSharedPreferences("puntos_total", Context.MODE_PRIVATE);
        progresoSh = getSharedPreferences("progreso", Context.MODE_PRIVATE);
    }

    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.general_toolbar_menu,menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {

        switch (item.getItemId()){
            case R.id.botonHome:
                startActivity(new Intent(this,MenuPrincipalActivity.class));
                break;
            case R.id.verPerfil:
                startActivity(new Intent(this,VerPerfilActivity.class));
                break;
            case R.id.botonSalir:
                startActivity(new Intent(this,InicioSesionActivity.class));
                break;
            default:
                break;
        }
        return true;
    }

    // logica para que al precionar una de las opciones suene el audio
    public void  ClickButton(){


        jugabilidad1_tipo2_opcion1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                try{
                    if(mediaPlayer.isPlaying() && mediaPlayer!=null) {
                        mediaPlayer.stop();
                    }
                }catch (Exception e){
                    //Toast.makeText(MainActivity.this, "Error : "+e.getMessage(), Toast.LENGTH_SHORT).show();
                }
                if(!audiosUrl[0].equals("")) {
                    ReproducirAudio(urlBase+audiosUrl[0]);
                }
                audioRetro = audiosRetroUrl[0];
            }
        } );

        jugabilidad1_tipo2_opcion2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                try{
                    if(mediaPlayer.isPlaying() && mediaPlayer!=null) {
                        mediaPlayer.stop();
                    }
                }catch (Exception e){
                    //Toast.makeText(MainActivity.this, "Error : "+e.getMessage(), Toast.LENGTH_SHORT).show();
                }
                if(!audiosUrl[1].equals("")) {
                    ReproducirAudio(urlBase+audiosUrl[1]);
                }
                audioRetro = audiosRetroUrl[1];
            }
        } );


        jugabilidad1_tipo2_opcion3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                try{
                    if(mediaPlayer.isPlaying() && mediaPlayer!=null) {
                        mediaPlayer.stop();
                    }
                }catch (Exception e){
                    //Toast.makeText(MainActivity.this, "Error : "+e.getMessage(), Toast.LENGTH_SHORT).show();
                }
                if(!audiosUrl[2].equals("")) {
                    ReproducirAudio(urlBase+audiosUrl[2]);
                }
                audioRetro = audiosRetroUrl[2];
            }
        } );

        jugabilidad1_tipo2_opcion4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                try{
                    if(mediaPlayer.isPlaying() && mediaPlayer!=null) {
                        mediaPlayer.stop();
                    }
                }catch (Exception e){
                    //Toast.makeText(MainActivity.this, "Error : "+e.getMessage(), Toast.LENGTH_SHORT).show();
                }
                if(!audiosUrl[3].equals("")) {
                    ReproducirAudio(urlBase+audiosUrl[3]);
                }
                audioRetro = audiosRetroUrl[3];
            }
        } );
    }
    private void ReproducirAudio(String url){
        Uri myUri = Uri.parse(url);
        mediaPlayer = new MediaPlayer();
        try {
            mediaPlayer.setDataSource(Modo2_Activity.this ,myUri);
        } catch (IOException e) {
            e.printStackTrace();
        }
        try {
            mediaPlayer.prepare();
        } catch (IOException e) {
            e.printStackTrace();
        }
        mediaPlayer.start();

    }
    public void ReproducirPreguntaModo2(View view){

       try{
            if(mediaPlayerP.isPlaying() && mediaPlayerP!=null) {
                mediaPlayerP.stop();
            }
        }catch (Exception e){
            //Toast.makeText(MainActivity.this, "Error : "+e.getMessage(), Toast.LENGTH_SHORT).show();
        }

        Uri myUri = Uri.parse(urlBase+audioPregunta);
        mediaPlayerP = new MediaPlayer();
        try {
            mediaPlayerP.setDataSource(Modo2_Activity.this,myUri);
        } catch (IOException e) {
            e.printStackTrace();
        }
        try {
            mediaPlayerP.prepare();
        } catch (IOException e) {
            e.printStackTrace();
        }
        mediaPlayerP.start();

    }

    public void DetenerAudio(View v){
        try{
            mediaPlayer.stop();
            mediaPlayer.release();
            mediaPlayerP.stop();
            mediaPlayerP.release();
        }catch (Exception e){
        }


    }
    public void Continuar2(View v){
        this.DetenerAudio(v);

        if(jugabilidad1_tipo2_opcion1.isChecked()){
            correcto = Integer.parseInt(opcionRes[0].substring(opcionRes[0].length()-1));
            controlP.ValidarPregunta(puntos, correcto, id, getApplicationContext());
        }
        else if(jugabilidad1_tipo2_opcion2.isChecked()){
            correcto = Integer.parseInt(opcionRes[1].substring(opcionRes[1].length()-1));
            controlP.ValidarPregunta(puntos, correcto, id, getApplicationContext());
        }
        else if(jugabilidad1_tipo2_opcion3.isChecked()){
            correcto = Integer.parseInt(opcionRes[2].substring(opcionRes[2].length()-1));
            controlP.ValidarPregunta(puntos, correcto, id, getApplicationContext());

        }
        else if(jugabilidad1_tipo2_opcion4.isChecked()){
            correcto = Integer.parseInt(opcionRes[3].substring(opcionRes[3].length()-1));
            controlP.ValidarPregunta(puntos, correcto, id, getApplicationContext());
        }
        controlP.BarraProgreso(progresoSh, progreso);

        Intent i = new Intent(this, RetroalimentacionActivity.class);

        if(correcto==1){
            i.putExtra("retro",RetroCorrecta+"");
            i.putExtra("AoF",correcto+"");
            i.putExtra("AudioRetro", urlBase+audioRetro+"");
        }else{
            i.putExtra("retro",RetroIncorrecta+"");
            i.putExtra("AoF",correcto+"");
            i.putExtra("AudioRetro", urlBase+audioRetro+"");
        }
        startActivity(i);


        transicionIzquierdaHaciaDerecha();

    }
    public void transicionIzquierdaHaciaDerecha(){
        overridePendingTransition(R.anim.slide_from_left, R.anim.slide_to_right);
    }
    private void obtenerInfoPregunta() {
        Jugabilidad jugabilidad = new Jugabilidad(this);
        String ids = sp.leer(this,"preguntas_id");
        String [] aux = ids.split(",");
        id = Integer.parseInt(aux[aux.length-1]);
        List<PreguntasResponse> preguntas = jugabilidad.getPregunta(id);

        String dataaaa = "";
        String Pregunta="";

        int x=0;
        for(PreguntasResponse  preg : preguntas) {

            Pregunta = preg.getPregunta() + "";
            audioPregunta = preg.getAudio_pregunta();
            audiosUrl[x] = preg.getAudio_respuesta();
            audiosRetroUrl[x] = preg.getAudio_retroalimentacion();

            dataaaa = preg.getRespuesta()+"";
            if(dataaaa.equals("1")){
                RetroCorrecta=preg.getRetroalimentacion()+"";
            }else{
                RetroIncorrecta=preg.getRetroalimentacion()+"";
            }
            opcionRes[x] = preg.getOpcion_resp()+preg.getRespuesta()+"";
            x=x+1;
        }

        if(!audioPregunta.equals("")) {
            ReproducirAudio(urlBase+audioPregunta);
        }

        ajustartTextosRespuestas();
        ajustartTextosPregunta(Pregunta);

        jugabilidad1_pregunta.setText(Pregunta);
        jugabilidad1_tipo2_opcion1.setText(opcionRes[0].substring(0, opcionRes[0].length()-1));
        jugabilidad1_tipo2_opcion2.setText(opcionRes[1].substring(0, opcionRes[1].length()-1));
        jugabilidad1_tipo2_opcion3.setText(opcionRes[2].substring(0, opcionRes[2].length()-1));
        jugabilidad1_tipo2_opcion4.setText(opcionRes[3].substring(0, opcionRes[3].length()-1));

        progreso = progresoSh.getInt("progreso", 0);
        if(progreso==0){
            jugabilidad1_progreso2.setProgress(0);

        }else{
            jugabilidad1_progreso2.setProgress(progreso);
        }

    }
    private void ajustartTextosPregunta(String pregunta) {
        if(pregunta.length()<=50){
            if(pregunta.length()<=30){
                jugabilidad1_pregunta.setTextSize(35);
            }
            jugabilidad1_pregunta.setTextSize(25);
        }else{
            jugabilidad1_pregunta.setTextSize(13);
        }
    }
    private void ajustartTextosRespuestas() {

        if(opcionRes[0].length()<=30){
            if(opcionRes[0].length()<=20){
                jugabilidad1_tipo2_opcion1.setTextSize(25);
            }
            jugabilidad1_tipo2_opcion1.setTextSize(16);
        }else{
            jugabilidad1_tipo2_opcion1.setTextSize(13);
        }
        if(opcionRes[1].length()<=30){
            if(opcionRes[1].length()<=20){
                jugabilidad1_tipo2_opcion2.setTextSize(25);
            }
            jugabilidad1_tipo2_opcion2.setTextSize(16);
        }else{
            jugabilidad1_tipo2_opcion2.setTextSize(13);
        }
        if(opcionRes[2].length()<=30){
            if(opcionRes[2].length()<=20){
                jugabilidad1_tipo2_opcion3.setTextSize(25);
            }
            jugabilidad1_tipo2_opcion3.setTextSize(16);
        }else{
            jugabilidad1_tipo2_opcion3.setTextSize(13);
        }
        if(opcionRes[3].length()<=30){
            if(opcionRes[3].length()<=20){
                jugabilidad1_tipo2_opcion4.setTextSize(25);
            }
            jugabilidad1_tipo2_opcion4.setTextSize(16);
        }else{
            jugabilidad1_tipo2_opcion4.setTextSize(13);
        }
    }



    @Override
    public void onBackPressed() {
        new AlertDialog.Builder(this)
                .setTitle("Salir del Juego")
                .setMessage("¿Desea salir de la partida? Perderas todo tu progreso")
                .setNegativeButton(android.R.string.no, null)
                .setPositiveButton(android.R.string.yes, new DialogInterface.OnClickListener() {

                    public void onClick(DialogInterface arg0, int arg1) {
                        startActivity(new Intent(getApplicationContext(), MenuPrincipalActivity.class));
                    }
                }).create().show();
    }

}