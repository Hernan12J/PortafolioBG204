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
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.bumptech.glide.Glide;
import com.example.frograming.Helpers.Jugabilidad;
import com.example.frograming.Helpers.MultimediaConcatURL;
import com.example.frograming.Helpers.SharedPreferencesController;
import com.example.frograming.Modelos.PreguntasResponse;
import com.google.android.material.appbar.MaterialToolbar;

import java.io.IOException;
import java.util.List;

public class Modo1_Activity extends AppCompatActivity {

    String opcionRes[]= new String[4];
    String RetroCorrecta;
    String RetroIncorrecta;
    int correcto=0;
    int id;
    int progreso=0;
    boolean op1=false, op2=false, op3=false, op4=false;
    SharedPreferences puntos, progresoSh;


    SharedPreferencesController sp = new SharedPreferencesController();
    String respuesta; //variable global que almacena la respuesta seleccionada por el usuario para enviar a la DBint progreso=0;
    ProgressBar jugabilidad1_progProgreso;
    ImageButton jugabilidad1_imgAudio, jugabilidad1_btnOpcion1,jugabilidad1_btnOpcion2,jugabilidad1_btnOpcion3,jugabilidad1_btnOpcion4;
    TextView jugabilidad1_txt_Opcion1,jugabilidad1_txt_Opcion2,jugabilidad1_txt_Opcion3,jugabilidad1_txt_Opcion4, Jugabilidad1_txt_pregunta;
    Button jugabilidad1_btn_Continuar;
    ImageView jugabilidad1_Selected_imgShape1,jugabilidad1_Selected_imgShape2,jugabilidad1_Selected_imgShape3,jugabilidad1_Selected_imgShape4,jugabilidad1_Unselected_imgShape1,jugabilidad1_Unselected_imgShape2,jugabilidad1_Unselected_imgShape3,jugabilidad1_Unselected_imgShape4;
    private MediaPlayer mediaPlayer, mediaPlayerP;

    String urlBase = new MultimediaConcatURL().toCompleteURL("");
    String audioPregunta = "";
    String audioRetro="";
    String imagenesUrl[] = new String[4];
    String audiosUrl[] = new String[4];
    String audiosRetroUrl[] = new String[4];
    MaterialToolbar toolbar;



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_modo1);

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

        InicializarControles();
        obtenerInfoPregunta();//metodo encargado de traer los datos de la base de datos
        ClickButtons();//metodo que controla las opciones seleccionadas por respuesta y la respuesta seleccionada
    }


    private void ClickButtons() {

        jugabilidad1_btnOpcion1.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                try{
                    if(mediaPlayer.isPlaying() && mediaPlayer!=null) {
                        mediaPlayer.stop();
                    }
                }catch (Exception e){
                    //Toast.makeText(MainActivity.this, "Error : "+e.getMessage(), Toast.LENGTH_SHORT).show();
                }
                op1=true;
                op2=false;
                op3=false;
                op4=false;

                jugabilidad1_Selected_imgShape1.setVisibility(View.VISIBLE);
                jugabilidad1_Unselected_imgShape1.setVisibility(View.INVISIBLE);

                jugabilidad1_Selected_imgShape2.setVisibility(View.INVISIBLE);
                jugabilidad1_Selected_imgShape3.setVisibility(View.INVISIBLE);
                jugabilidad1_Selected_imgShape4.setVisibility(View.INVISIBLE);

                jugabilidad1_Unselected_imgShape2.setVisibility(View.VISIBLE);
                jugabilidad1_Unselected_imgShape3.setVisibility(View.VISIBLE);
                jugabilidad1_Unselected_imgShape4.setVisibility(View.VISIBLE);
                jugabilidad1_Selected_imgShape1.setEnabled(true);
                jugabilidad1_btn_Continuar.setEnabled(true);

                if(!audiosUrl[0].equals(""))
                    ReproducirAudio(urlBase+audiosUrl[0]);

                    audioRetro = audiosRetroUrl[0];

            }
        });
        jugabilidad1_btnOpcion2.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                try{
                    if(mediaPlayer.isPlaying() && mediaPlayer!=null) {
                        mediaPlayer.stop();
                    }
                }catch (Exception e){
                    //Toast.makeText(MainActivity.this, "Error : "+e.getMessage(), Toast.LENGTH_SHORT).show();
                }
                op1=false;
                op2=true;
                op3=false;
                op4=false;



                jugabilidad1_Selected_imgShape2.setVisibility(View.VISIBLE);
                jugabilidad1_Unselected_imgShape2.setVisibility(View.INVISIBLE);

                jugabilidad1_Selected_imgShape1.setVisibility(View.INVISIBLE);
                jugabilidad1_Selected_imgShape3.setVisibility(View.INVISIBLE);
                jugabilidad1_Selected_imgShape4.setVisibility(View.INVISIBLE);

                jugabilidad1_Unselected_imgShape1.setVisibility(View.VISIBLE);
                jugabilidad1_Unselected_imgShape3.setVisibility(View.VISIBLE);
                jugabilidad1_Unselected_imgShape4.setVisibility(View.VISIBLE);
                jugabilidad1_btn_Continuar.setEnabled(true);

                if(!audiosUrl[1].equals(""))
                    ReproducirAudio(urlBase+audiosUrl[1]);

                    audioRetro = audiosRetroUrl[1];
            }
        });
        jugabilidad1_btnOpcion3.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                try{
                    if(mediaPlayer.isPlaying() && mediaPlayer!=null) {
                        mediaPlayer.stop();
                    }
                }catch (Exception e){
                    //Toast.makeText(MainActivity.this, "Error : "+e.getMessage(), Toast.LENGTH_SHORT).show();
                }
                op1=false;
                op2=false;
                op3=true;
                op4=false;


                jugabilidad1_Selected_imgShape3.setVisibility(View.VISIBLE);
                jugabilidad1_Unselected_imgShape3.setVisibility(View.INVISIBLE);

                jugabilidad1_Selected_imgShape1.setVisibility(View.INVISIBLE);
                jugabilidad1_Selected_imgShape1.setEnabled(false);
                jugabilidad1_Selected_imgShape2.setVisibility(View.INVISIBLE);
                jugabilidad1_Selected_imgShape4.setVisibility(View.INVISIBLE);

                jugabilidad1_Unselected_imgShape1.setVisibility(View.VISIBLE);
                jugabilidad1_Unselected_imgShape2.setVisibility(View.VISIBLE);
                jugabilidad1_Unselected_imgShape4.setVisibility(View.VISIBLE);
                jugabilidad1_btn_Continuar.setEnabled(true);

                if(!audiosUrl[2].equals(""))
                    ReproducirAudio(urlBase+audiosUrl[2]);

                    audioRetro = audiosRetroUrl[2];
            }
        });
        jugabilidad1_btnOpcion4.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                try{
                    if(mediaPlayer.isPlaying() && mediaPlayer!=null) {
                        mediaPlayer.stop();
                    }
                }catch (Exception e){
                    //Toast.makeText(MainActivity.this, "Error : "+e.getMessage(), Toast.LENGTH_SHORT).show();
                }
                op1=false;
                op2=false;
                op3=false;
                op4=true;

                jugabilidad1_Selected_imgShape4.setVisibility(View.VISIBLE);
                jugabilidad1_Unselected_imgShape4.setVisibility(View.INVISIBLE);

                jugabilidad1_Selected_imgShape1.setVisibility(View.INVISIBLE);
                jugabilidad1_Selected_imgShape2.setVisibility(View.INVISIBLE);
                jugabilidad1_Selected_imgShape3.setVisibility(View.INVISIBLE);
                jugabilidad1_Selected_imgShape1.setEnabled(false);

                jugabilidad1_Unselected_imgShape1.setVisibility(View.VISIBLE);
                jugabilidad1_Unselected_imgShape2.setVisibility(View.VISIBLE);
                jugabilidad1_Unselected_imgShape3.setVisibility(View.VISIBLE);
                jugabilidad1_btn_Continuar.setEnabled(true);

                if(!audiosUrl[3].equals(""))
                    ReproducirAudio(urlBase+audiosUrl[3]);

                    audioRetro = audiosRetroUrl[3];
            }
        });
    }
    private void ReproducirAudio(String url){


        Uri myUri = Uri.parse(url);
        mediaPlayer = new MediaPlayer();
        try {
            mediaPlayer.setDataSource(Modo1_Activity.this,myUri);
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

    public void DetenerAudio(View v){
        try{
            mediaPlayer.stop();
            mediaPlayer.release();
            mediaPlayerP.stop();
            mediaPlayerP.release();
        }catch (Exception e){

        }
    }

    private void InicializarControles() {
        toolbar = (MaterialToolbar) findViewById(R.id.topAppBar);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                onBackPressed();
            }
        });

        //ImageButton-imagenRespuesta
        this.jugabilidad1_btnOpcion1 = (ImageButton) findViewById(R.id.jugabilidad1_btn_opcion1);
        this.jugabilidad1_btnOpcion2 = (ImageButton) findViewById(R.id.jugabilidad1_btn_opcion2);
        this.jugabilidad1_btnOpcion3 = (ImageButton) findViewById(R.id.jugabilidad1_btn_opcion3);
        this.jugabilidad1_btnOpcion4 = (ImageButton) findViewById(R.id.jugabilidad1_btn_opcion4);
        //TextView-OpcionRespuesta
        this.jugabilidad1_txt_Opcion1=(TextView) findViewById(R.id.jugabilidad1_txt_opcion1);
        this.jugabilidad1_txt_Opcion2=(TextView) findViewById(R.id.jugabilidad1_txt_opcion2);
        this.jugabilidad1_txt_Opcion3=(TextView) findViewById(R.id.jugabilidad1_txt_opcion3);
        this.jugabilidad1_txt_Opcion4=(TextView) findViewById(R.id.jugabilidad1_txt_opcion4);
        //Button-boton_continuar
        this.jugabilidad1_btn_Continuar = (Button) findViewById(R.id.jugabilidad1_btn_continuar);
        this.jugabilidad1_btn_Continuar.setEnabled(false);
        //Textview-Pregunta
        this.Jugabilidad1_txt_pregunta =(TextView) findViewById(R.id.jugabilidad1_txt_pregunta);
        //imageView-shapes
        this.jugabilidad1_Selected_imgShape1=(ImageView) findViewById(R.id.jugabilidad1_Selected_imgShape1);
        this.jugabilidad1_Selected_imgShape2=(ImageView) findViewById(R.id.jugabilidad1_Selected_imgShape2);
        this.jugabilidad1_Selected_imgShape3=(ImageView) findViewById(R.id.jugabilidad1_Selected_imgShape3);
        this.jugabilidad1_Selected_imgShape4=(ImageView) findViewById(R.id.jugabilidad1_Selected_imgShape4);

        this.jugabilidad1_Unselected_imgShape1=(ImageView) findViewById(R.id.jugabilidad1_Unselected_imgShape1);
        this.jugabilidad1_Unselected_imgShape2=(ImageView) findViewById(R.id.jugabilidad1_Unselected_imgShape2);
        this.jugabilidad1_Unselected_imgShape3=(ImageView) findViewById(R.id.jugabilidad1_Unselected_imgShape3);
        this.jugabilidad1_Unselected_imgShape4=(ImageView) findViewById(R.id.jugabilidad1_Unselected_imgShape4);
        //ImageView-Audio
        this.jugabilidad1_imgAudio=(ImageButton) findViewById(R.id.jugabilidad1_img_audio1);

        //restablecer-shapes >> Imagenes ---Invisible!
        this.jugabilidad1_Selected_imgShape1.setVisibility(View.INVISIBLE);
        this.jugabilidad1_Selected_imgShape2.setVisibility(View.INVISIBLE);
        this.jugabilidad1_Selected_imgShape3.setVisibility(View.INVISIBLE);
        this.jugabilidad1_Selected_imgShape4.setVisibility(View.INVISIBLE);

        //progressBar
        this.jugabilidad1_progProgreso=(ProgressBar) findViewById(R.id.progressBar);


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


    public void Continuar1(View view){

        this.DetenerAudio(view);//detener los audios q se estan reproduciendo.... isPlaying();
        if(op1){
            correcto = Integer.parseInt(opcionRes[0].substring(opcionRes[0].length()-1));
            sp.ValidarPregunta(puntos, correcto, id, getApplicationContext());
        }
        else if(op2){
            correcto = Integer.parseInt(opcionRes[1].substring(opcionRes[1].length()-1));
            sp.ValidarPregunta(puntos, correcto, id, getApplicationContext());
        }
        else if (op3){
            correcto = Integer.parseInt(opcionRes[2].substring(opcionRes[2].length()-1));
            sp.ValidarPregunta(puntos, correcto, id, getApplicationContext());
        }else if (op4){
            correcto = Integer.parseInt(opcionRes[3].substring(opcionRes[3].length()-1));
            sp.ValidarPregunta(puntos, correcto, id, getApplicationContext());
        }

        sp.BarraProgreso(progresoSh, progreso);
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

        int x=0;
        List<PreguntasResponse> preguntas = jugabilidad.getPregunta(id);

        String dataaaa = "";
        String Pregunta="";



        for(PreguntasResponse preg : preguntas) {
            Pregunta = preg.getPregunta() + "";
            audioPregunta = preg.getAudio_pregunta();
            imagenesUrl[x] = preg.getImagen_respuesta();
            audiosUrl[x] = preg.getAudio_respuesta();
            audiosRetroUrl[x] = preg.getAudio_retroalimentacion();
            System.out.println(preg.getImagen_respuesta());

            dataaaa = preg.getRespuesta()+"";
            if(dataaaa.equals("1")){
                RetroCorrecta=preg.getRetroalimentacion()+"";
            }else{
                RetroIncorrecta=preg.getRetroalimentacion()+"";
            }
            opcionRes[x] = preg.getOpcion_resp()+preg.getRespuesta()+"";

            x=x+1;
        }

        if(!audioPregunta.equals(""))
            ReproducirAudio(urlBase+audioPregunta);

            ajustartTextosRespuestas();
        ajustartTextosPregunta(Pregunta);

        Jugabilidad1_txt_pregunta.setText(Pregunta);
        jugabilidad1_txt_Opcion1.setText(opcionRes[0].substring(0, opcionRes[0].length()-1));
        jugabilidad1_txt_Opcion2.setText(opcionRes[1].substring(0, opcionRes[1].length()-1));
        jugabilidad1_txt_Opcion3.setText(opcionRes[2].substring(0, opcionRes[2].length()-1));
        jugabilidad1_txt_Opcion4.setText(opcionRes[3].substring(0, opcionRes[3].length()-1));

         //Para cargar las imagenes
        if(!imagenesUrl[0].equals("")) {
            Glide.with(this)
                    .load(urlBase+imagenesUrl[0])
                    .into(jugabilidad1_btnOpcion1);
            Glide.with(this)
                    .load(urlBase+imagenesUrl[1])
                    .into(jugabilidad1_btnOpcion2);
            Glide.with(this)
                    .load(urlBase+imagenesUrl[2])
                    .into(jugabilidad1_btnOpcion3);
            Glide.with(this)
                    .load(urlBase+imagenesUrl[3])
                    .into(jugabilidad1_btnOpcion4);
        }



        progreso = progresoSh.getInt("progreso", 0);
        if(progreso==0){
            jugabilidad1_progProgreso.setProgress(0);

        }else{
            jugabilidad1_progProgreso.setProgress(progreso);
        }
    }

    private void ajustartTextosPregunta(String pregunta) {
        if(pregunta.length()<=50){
            if(pregunta.length()<=30){
                Jugabilidad1_txt_pregunta.setTextSize(35);
            }else{
                Jugabilidad1_txt_pregunta.setTextSize(25);
            }
        }else{
            Jugabilidad1_txt_pregunta.setTextSize(13);
        }
    }
    private void ajustartTextosRespuestas() {
        if(opcionRes[0].length()<=30){
            if(opcionRes[0].length()<=20){
                jugabilidad1_txt_Opcion1.setTextSize(25);
            }
            jugabilidad1_txt_Opcion1.setTextSize(16);
        }else{
            jugabilidad1_txt_Opcion1.setTextSize(13);
        }
        if(opcionRes[1].length()<=30){
            if(opcionRes[1].length()<=20){
                jugabilidad1_txt_Opcion2.setTextSize(25);
            }
            jugabilidad1_txt_Opcion2.setTextSize(16);
        }else{
            jugabilidad1_txt_Opcion2.setTextSize(13);
        }
        if(opcionRes[2].length()<=30){
            if(opcionRes[2].length()<=20){
                jugabilidad1_txt_Opcion3.setTextSize(25);
            }
            jugabilidad1_txt_Opcion3.setTextSize(16);
        }else{
            jugabilidad1_txt_Opcion3.setTextSize(13);
        }
        if(opcionRes[3].length()<=30){
            if(opcionRes[3].length()<=20){
                jugabilidad1_txt_Opcion4.setTextSize(25);
            }
            jugabilidad1_txt_Opcion4.setTextSize(16);
        }else{
            jugabilidad1_txt_Opcion4.setTextSize(13);
        }
    }
    public void ReproducirPreguntaModo1(View view){

        try{
            if(mediaPlayerP.isPlaying() && mediaPlayerP!=null) {
                mediaPlayerP.stop();
            }
        }catch (Exception e){
            //Toast.makeText(MainActivity.this, "Error : "+e.getMessage(), Toast.LENGTH_SHORT).show();
        }
        Uri myUri = Uri.parse(urlBase + audioPregunta);
        mediaPlayerP = new MediaPlayer();
        try {
            mediaPlayerP.setDataSource(Modo1_Activity.this,myUri);
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