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
import android.view.MotionEvent;
import android.view.View;
import android.view.ViewGroup;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.ProgressBar;
import android.widget.RelativeLayout;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;

import com.example.frograming.Helpers.Jugabilidad;
import com.example.frograming.Helpers.Modo3PalabraPersonalizada;
import com.example.frograming.Helpers.Modo3VistaPersonalizada;
import com.example.frograming.Helpers.MultimediaConcatURL;
import com.example.frograming.Helpers.SharedPreferencesController;
import com.example.frograming.Modelos.PreguntasResponse;
import com.google.android.material.appbar.MaterialToolbar;
import com.nex3z.flowlayout.FlowLayout;

import java.io.IOException;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class Modo3_Activity extends AppCompatActivity {

    SharedPreferencesController spp = new SharedPreferencesController();
    SharedPreferences puntos, progresoSh;

    RelativeLayout jugabilidad2_modo_3_mainLayout;
    TextView jugabilidad2_txtPregunta;
    Button jugabilidad2_modo_3_boton;
    FlowLayout sentenceLine;
    ProgressBar jugabilidad1_progreso3;
    MediaPlayer mp;
    MaterialToolbar toolbar;


    private Modo3PalabraPersonalizada palabraPersonalizada;
    private Modo3VistaPersonalizada vistaPersonalizada;
    MultimediaConcatURL url = new MultimediaConcatURL();


    List<String> respuestas;
    String pregunta = "";
    String opcCorrecta;
    String opcIncorrecta = "";
    String totalRespuestas;
    String retroBuena, retroMala;
    String audioComp, auRB, auRM;
    int progreso=0;
    int id;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_modo3);
        inicializarControles();
        inicializarVistaPerzonalida();
        obtenerInfoPregunta();
        AudioInicial();
        activacionBoton();
        revisarRespuesta();

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

    }



    private void inicializarControles() {
        jugabilidad2_modo_3_mainLayout = (RelativeLayout)findViewById(R.id.jugabilidad2_modo_3_main_layout);
        jugabilidad2_modo_3_boton = (Button)findViewById(R.id.jugabilidad2_modo_3_btn_confirmar);
        jugabilidad2_txtPregunta = (TextView) findViewById(R.id.jugabilidad2_txtPregunta);
        sentenceLine = (FlowLayout) findViewById(R.id.jugabilidad2_sentence_line);
        jugabilidad1_progreso3 =(ProgressBar) findViewById(R.id.jugabilidad2_pgrBar);

        toolbar = (MaterialToolbar) findViewById(R.id.topAppBar);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                onBackPressed();
            }
        });

        progresoSh = getSharedPreferences("progreso", Context.MODE_PRIVATE);
        puntos = getSharedPreferences("puntos_total", Context.MODE_PRIVATE);

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


    private class TouchListener implements View.OnTouchListener {

        @Override
        public boolean onTouch(View view, MotionEvent motionEvent) {

            if (motionEvent.getAction() == MotionEvent.ACTION_DOWN && !vistaPersonalizada.empty()) {
                //Si la Vista de la palabra es presionada. Se va al metodo goToViewGroup
                //Que dependiendo si la palabra
                // este en el grupo de palabra abajo (se ira hacia arriba a la linea de oracion) y
                // este en la linea de oracion (se ira hacia abajo al grupo de palabras)
                palabraPersonalizada = (Modo3PalabraPersonalizada) view;
                palabraPersonalizada.goToViewGroup(vistaPersonalizada, sentenceLine);

                //Metodo para validar si el boton puede ser activado o no segun Si la linea de oracion tenga elemento o no.
                activacionBoton();

                return true;
            }

            return false;
        }
    }

    private void obtenerInfoPregunta(){

        Jugabilidad jugabilidad = new Jugabilidad(this);
        String ids = spp.leer(this, "preguntas_id");
        String[] aux = ids.split(",");
        id = Integer.parseInt(aux[aux.length - 1]);
        String audioP;
        String auRetroB, auRetroM;

        //ARRAYLIST CON LOS DATOS DE LA PREGUNTA
        List<PreguntasResponse> preguntas = jugabilidad.getPregunta(id);

        pregunta = preguntas.get(0).getPregunta();
        audioP = preguntas.get(0).getAudio_pregunta();

        if (preguntas.get(0).getRespuesta() == 1) {
            opcCorrecta = preguntas.get(0).getOpcion_resp();
            retroBuena = preguntas.get(0).getRetroalimentacion();
            auRetroB = preguntas.get(0).getAudio_retroalimentacion();

            opcIncorrecta = preguntas.get(1).getOpcion_resp();
            retroMala = preguntas.get(1).getRetroalimentacion();
            auRetroM = preguntas.get(1).getAudio_retroalimentacion();
        } else {
            opcCorrecta = preguntas.get(1).getOpcion_resp();
            retroBuena = preguntas.get(1).getRetroalimentacion();
            auRetroB = preguntas.get(1).getAudio_retroalimentacion();

            opcIncorrecta = preguntas.get(0).getOpcion_resp();
            retroMala = preguntas.get(0).getRetroalimentacion();
            auRetroM = preguntas.get(0).getAudio_retroalimentacion();
        }

        totalRespuestas = opcCorrecta + " " + opcIncorrecta;

        respuestas = Arrays.asList(totalRespuestas.split(" "));

        Collections.shuffle(respuestas);

        jugabilidad2_txtPregunta.setText(pregunta);

        /////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////
        //Desabilitamos el boton de CONFIRMAR y le agregamos que este en blanco.
        jugabilidad2_modo_3_boton.setEnabled(false);
        jugabilidad2_modo_3_boton.setBackground(
                ContextCompat.getDrawable(getApplicationContext(),
                        R.drawable.shape_jugabilidad2_btn0));

        seteandoTexto(respuestas);

        progreso = progresoSh.getInt("progreso", 0);
        if(progreso==0){
            jugabilidad1_progreso3.setProgress(0);

        }else{
            jugabilidad1_progreso3.setProgress(progreso);
        }

        audioComp= url.toCompleteURL(audioP);
        auRB=url.toCompleteURL(auRetroB);
        auRM=url.toCompleteURL(auRetroM);


    }

    public void inicializarVistaPerzonalida(){
        //Instancio a mi clase VistaPersonalizada
        //A esta Vista la voy agregar en mi actividad
        vistaPersonalizada = new Modo3VistaPersonalizada(getApplicationContext());

        //Seteo la vista en el centro de la actividad
        //vistaPersonalizada.setGravity(Gravity.CENTER);

        //Le agrego parametros a la VistaPersonalizada
        RelativeLayout.LayoutParams params = new RelativeLayout.LayoutParams(
                ViewGroup.LayoutParams.WRAP_CONTENT, ViewGroup.LayoutParams.WRAP_CONTENT);

        //Parametro para que la vista quede creada por debajo de la oracion
        params.addRule(RelativeLayout.BELOW, R.id.jugabilidad2_fmlRespuestas);
        params.addRule(RelativeLayout.ABOVE, R.id.jugabilidad2_modo_3_btn_confirmar);
        params.topMargin = 15;
        params.bottomMargin = 10;

        //Finalmente agrego esa vista al activity_modo3.xml
        jugabilidad2_modo_3_mainLayout.addView(vistaPersonalizada, params);

    }

    private void activacionBoton(){
        //Hacemos validaciones para ver si el boton puede ser activado o no

        //Si la linea de oracion esta mayor a 0, osea que tiene elementos (por ejemplo una vista de palabra)
        if (sentenceLine.getChildCount() > 0) {
            //Entonces al boton se volverá de color y se podrá Tocar
            jugabilidad2_modo_3_boton.setBackground(
                    ContextCompat.getDrawable(getApplicationContext(),
                            R.drawable.shape_general_botonprimario));

            jugabilidad2_modo_3_boton.setEnabled(true);

        } else {
            //De lo contrario, el boton seguirá viendosé gris y no se podrá tocar.
            jugabilidad2_modo_3_boton.setBackground(
                    ContextCompat.getDrawable(getApplicationContext(),
                            R.drawable.shape_jugabilidad2_btn0));

            jugabilidad2_modo_3_boton.setEnabled(false);
        }
    }

    private void seteandoTexto(List<String> respuestas) {
        //Recorreremos cada palabra de la lista.

        for(String unaPalabra : respuestas){
            //A cada palabra la va enviar a PalabraPersonalizada
            Modo3PalabraPersonalizada palabraPersonalizada = new Modo3PalabraPersonalizada(getApplicationContext(),unaPalabra);
            //Se le implementa a esa vista de Palabra un metodo de Toque de Accion
            palabraPersonalizada.setOnTouchListener(new TouchListener());

            //Seteando al textView la fuente
            // Typeface typeface = ResourcesCompat.getFont(getApplicationContext(), R.font.victorpro);
            //palabraPersonalizada.setTypeface(typeface);

            //A la palabra le enviamos al metodo enviarPalabraVistaPersonalizada para meter ese vista de palabra a la Vista Personalizada
            vistaPersonalizada.enviarPalabraVistaPersonalizada(palabraPersonalizada);
        }

    }
    public void AudioInicial() {
        Uri uri = Uri.parse(audioComp);
        mp = new MediaPlayer();
        if(mp!=null) {
            mp.stop();
        }
        try {
            mp.setDataSource(Modo3_Activity.this,uri);
        } catch (IOException e) {
            e.printStackTrace();
        }
        try {
            mp.prepare();
        } catch (IOException e){
            e.printStackTrace();
        }
        mp.start();
    }

    public void AudioPregunta(View view) {
        try{
            if(mp!=null) {
                mp.stop();
            }
        }catch (Exception e){
        }
        mp = new MediaPlayer();
        Uri uri = Uri.parse(audioComp);
        try {
            mp.setDataSource(Modo3_Activity.this,uri);
        } catch (IOException e) {
            e.printStackTrace();
        }
        try {
            mp.prepare();
        } catch (IOException e) {
            e.printStackTrace();
        }
        mp.start();

    }

    public void DetenerAudio(){
        try{
            mp.stop();
            mp.release();
        }catch (Exception e){
        }
    }

    private void revisarRespuesta() {
        //Agregar metodo onClick cuando el boton sea presionado
        SharedPreferencesController controlP =new SharedPreferencesController();
        jugabilidad2_modo_3_boton.setOnClickListener(new View.OnClickListener() {

            @Override
            public void onClick(View v) {
                DetenerAudio();
                //Variable StringBuilder para que vaya almacenando cada respuesta introducida en la Linea de Oracion
                StringBuilder respuestaIntroducida = new StringBuilder();

                //Recorrer la linea de oracion para traer cada elemento (osea la vista de palabras) que haya en la linea de oracion
                for (int i = 0; i < sentenceLine.getChildCount(); i++) {

                    //palabraPersonalizada tomará el TextView de que esta en la posicion (i) que tenga la linea de oracion
                    palabraPersonalizada = (Modo3PalabraPersonalizada) sentenceLine.getChildAt(i);

                    //respuestaIntroducida irá almacenando cada texto de palabra que trae de palabraPersonalizada
                    //Ejemplo:  palabra1+" "+"palabra2"+" "+"palabra3"+" "
                    respuestaIntroducida.append(palabraPersonalizada.getText().toString() + " ");
                }


                //Si respuestaIntroducida contiene lo mismo que opcCorrecta ((palabra1 palabra2 palabra3)  == opcCorrera+" ")
                if(respuestaIntroducida.toString().equals(opcCorrecta + " ")){

                    ////Lo enviamos a la pantalla de Retroalimentacion
                    int correcto = 1;
                    Intent i = new Intent(Modo3_Activity.this, RetroalimentacionActivity.class);
                    i.putExtra("retro",""+retroBuena);
                    i.putExtra("AudioRetro", auRB+"");
                    i.putExtra("AoF",correcto+"");

                    spp.BarraProgreso(progresoSh, progreso);
                    controlP.ValidarPregunta(puntos, correcto, id, getApplicationContext());
                    startActivity(i);
                }else{

                    //Lo enviamos a la pantalla de Retroalimentacion
                    Intent i = new Intent(Modo3_Activity.this, RetroalimentacionActivity.class);
                    i.putExtra("retro",""+retroMala);
                    i.putExtra("AudioRetro", auRM+"");
                    i.putExtra("AoF",0+"");

                    spp.BarraProgreso(progresoSh, progreso);
                    controlP.ValidarPregunta(puntos, 0, id, getApplicationContext());
                    startActivity(i);
                }
            }
        });

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