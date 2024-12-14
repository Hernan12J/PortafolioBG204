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
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.ListView;
import android.widget.ProgressBar;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.example.frograming.Adaptadores.PareoListviewAdapter;
import com.example.frograming.Helpers.MultimediaConcatURL;
import com.example.frograming.Helpers.SharedPreferencesController;
import com.example.frograming.Entidades.Pareo;
import com.google.android.material.appbar.MaterialToolbar;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Timer;
import java.util.TimerTask;

public class Modo4_Activity extends AppCompatActivity {


    SharedPreferencesController spp = new SharedPreferencesController();

    private Button btn_siguiente;
    private ListView lstPareo,lstPareo2;
    private TextView lblPareo1, lblPareo2;
    private ProgressBar prgbar;
    private int avance=0,idPreguntaPareo=0;
    private String idPareo1,idPareo2;
    MaterialToolbar toolbar;
    SharedPreferences puntos, progresoSh;
    int progreso = 0;
    int correcto = 1;
    private MediaPlayer mediaPlayer;
    MultimediaConcatURL url = new MultimediaConcatURL();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_modo4);
        this.inicializarControles();

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

        btn_siguiente.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                if(mediaPlayer.isPlaying() && mediaPlayer!=null) {
                    mediaPlayer.stop();
                }

                spp.BarraProgreso(progresoSh, progreso);
                spp.ValidarPregunta(puntos, correcto, idPreguntaPareo, getApplicationContext());


                Intent i = new Intent(Modo4_Activity.this, RetroalimentacionActivity.class);
                i.putExtra("retro","Pareo Terminado!");
                i.putExtra("AoF",1+"");
                startActivity(i);
            }
        });

    }



    private void inicializarControles() {
        //data = (TextView) findViewById(R.id.jugabilidad1_modo_4);
        puntos = getSharedPreferences("puntos_total", Context.MODE_PRIVATE);
        btn_siguiente = (Button) findViewById(R.id.jugabilidad2_modo_4_btn_confirmar);
        lstPareo = (ListView)findViewById(R.id.lstPareo1);
        lstPareo2 = (ListView)findViewById(R.id.lstPareo2);
        toolbar = (MaterialToolbar) findViewById(R.id.topAppBar);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                onBackPressed();
            }
        });
        prgbar = (ProgressBar) findViewById(R.id.jugabilidad2_pgrBarP);
        progresoSh = getSharedPreferences("progreso", Context.MODE_PRIVATE);
        progreso = progresoSh.getInt("progreso", 0);
        if(progreso==0){
            prgbar.setProgress(0);
        }else{
            prgbar.setProgress(progreso);
        }
        //Jugabildad jugabildad = new Jugabildad(this);
        String ids = spp.leer(this,"preguntas_id");
        String [] aux = ids.split(",");
        idPreguntaPareo = Integer.parseInt(aux[aux.length-1]);
        CargarListView();
        CargarListView2();
        AttachEvent();
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


    private void CargarListView() {
        //#Insertar la variable idPreguntaPareo en el parametro para obtener los datos de esa pregunta
        List<Pareo> pareo = new Pareo().obtenerPareo(idPreguntaPareo,getApplicationContext());
        List<Pareo> pareosDivision = new ArrayList<>();
        //#Desordenar las posiciones opciones del listview
        for (int i= 0; i < 5; i++){
            pareosDivision.add(pareo.get(i));
        }
        Collections.shuffle(pareosDivision);
        PareoListviewAdapter adapter = new PareoListviewAdapter(getApplicationContext(),pareosDivision);
        lstPareo.setAdapter(adapter);
    }

    private void CargarListView2() {
        //#Insertar la variable idPreguntaPareo en el parametro para obtener los datos de esa pregunta
        List<Pareo> pareo = new Pareo().obtenerPareo(idPreguntaPareo,getApplicationContext());
        List<Pareo> pareosDivision = new ArrayList<>();
        //#Desordenar las posiciones, opciones del listview
        for (int i= 5; i < 10; i++){
            //#Generar las posiciones aleatoriamente con el método generarNumero y asignarlo a pareo que contiene todos los
            //#elementos del listview, luego serán asignados a la lista pareosDivision que es la que se adaptará a la pantalla
            pareosDivision.add(pareo.get(i));
        }
        Collections.shuffle(pareosDivision);
        PareoListviewAdapter adapter = new PareoListviewAdapter(getApplicationContext(),pareosDivision);
        //#Cargar adaptador al listview para mostrarlo en pantalla
        lstPareo2.setAdapter(adapter);
    }

    //#Método utilizado para adjuntar todos los eventos que se utilizarán en el Activity
    private void AttachEvent(){
        Pareo pareo = new Pareo();
        //MediaPlayer mediaPlayer = new MediaPlayer();
        //Métodos utilizados para los eventos en los listviews, para los dos listviews son idénticos
        lstPareo.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                //#Condicional que va a ser usada en el momento en se haya seleccionado por segunda vez un elemento en la misma columna
                //#Para cambiar el color del actual elemento seleccionado y quitar el color al anteriormente seleccionado
                if(lblPareo1!=null){
                    lblPareo1.setBackgroundResource(R.drawable.shape_jugabilidad2_palabra);
                }
                TextView estate =view.findViewById(R.id.jugabilidad2_lblPareoTemplatePalabra);
                if(estate.isEnabled()!=false){
                    lstPareo.getChildAt(i).setEnabled(false);
                    //#Se asignará el shape color amarillo al actual elemento seleccionado
                    view.findViewById(R.id.jugabilidad2_lblPareoTemplatePalabra).setBackgroundResource(R.drawable.shape_jugabilidad2_seleccionaropcion);
                    //#Se le asignara el valor del del textview del texto mostrado para su posterior uso en cambios de vista
                    lblPareo1=view.findViewById(R.id.jugabilidad2_lblPareoTemplatePalabra);
                    //#Tomar el enlace del audio del textview
                    TextView a = view.findViewById(R.id.jugabilidad2_lblPareoTemplateAudio);
                    //#Parsear el textview a un string para poder usarlo junto al host y puerto
                    String audio = a.getText().toString();
                    //#Método donde se ejecutará el audio asincronicamente para no afectar a la aplicación principal se le asigna la ruta del audio
                    AudioTask(audio);
                    //#Se le asignara el valor del del textview a variable textview para tomar el valor
                    TextView txt = (TextView) view.findViewById(R.id.jugabilidad2_lblPareoTemplateId);
                    //#Parsear el textview de la variable txt a un string para poder usarlo como id
                    idPareo1 = txt.getText().toString();
                    compararPreguntas(idPareo1,idPareo2);
                }
            }
        });

        lstPareo2.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                if(lblPareo2 !=null){
                    lblPareo2.setBackgroundResource(R.drawable.shape_jugabilidad2_palabra);
                }
                TextView estate =view.findViewById(R.id.jugabilidad2_lblPareoTemplatePalabra);
                if(estate.isEnabled()!=false){
                    view.findViewById(R.id.jugabilidad2_lblPareoTemplatePalabra).setBackgroundResource(R.drawable.shape_jugabilidad2_seleccionaropcion);
                    lblPareo2 =view.findViewById(R.id.jugabilidad2_lblPareoTemplatePalabra);
                    TextView a = view.findViewById(R.id.jugabilidad2_lblPareoTemplateAudio);
                    String audio = a.getText().toString();
                    AudioTask(audio);
                    TextView txt = (TextView) view.findViewById(R.id.jugabilidad2_lblPareoTemplateId);
                    idPareo2 = txt.getText().toString();
                    compararPreguntas(idPareo1,idPareo2);
                }
            }
        });
    }


    //#Método utilizado para comparar los elementos seleccionados de cada listview
    private void compararPreguntas(String p1, String p2){
        //#Condicional donde solo entra si las dos elemenentos de los listviews están seleccionados
        if(p1!=null && p2!=null){
            //#Condicional donde solo entra al tener los elementos con el mismo id, que significa que es correcto
            if(p1==p2){
                //#Al momento de entrar a la condicional se le asignara un shape verde que mostrará en pantalla como una señal de Correcto
                lblPareo1.setBackgroundResource(R.drawable.shape_jugabilidad2_correcto);
                lblPareo2.setBackgroundResource(R.drawable.shape_jugabilidad2_correcto);
                //#En las variables de las opciones seleccionadas que guardan los id's se le asigna null
                idPareo1=null;
                idPareo2=null;
                //#En la variable avance se le suma 1
                avance = avance + 1;
                //#Condicional dondo entrará solo al avance a ver respondido los 5 pares correctamente
                if(avance == 5){
                    //#Se activará el botón para seguir a la próxima pregunta
                    btn_siguiente.setEnabled(true);
                    btn_siguiente.setBackgroundResource(R.drawable.shape_general_botonprimario);
                }
                //#Se le asigno un momento para que se activará estas instrucciones
                TimerTask timerTask = new TimerTask() {
                    @Override
                    public void run() {
                        runOnUiThread(new Runnable() {
                            @Override
                            public void run() {
                                //#En las variables de los textviews guardada anteriormente al seleccionarlos, se le asigna que sean invisibles a la vista
                                lblPareo1.setEnabled(false);
                                lblPareo2.setEnabled(false);
                                //#En las variables de los textviews guardada anteriormente al seleccionarlos, se le asigna null para que no haya problemas de vista
                                lblPareo1= null;
                                lblPareo2= null;
                            }
                        });
                    }
                };
                Timer time = new Timer();
                time.schedule(timerTask, 120);
            }else{
                //#Al momento de fallar la condicional se le asignara un shape rojo que mostrará en pantalla como una señal de
                //#Incorrecto
                lblPareo2.setBackgroundResource(R.drawable.shape_jugabilidad2_incorrecto);
                lblPareo1.setBackgroundResource(R.drawable.shape_jugabilidad2_incorrecto);
                //#En las variables de las opciones seleccionadas que guardan los id's se le asigna null
                idPareo1=null;
                idPareo2=null;
                //#Se le asigno un momento para que se activará estas instrucciones
                TimerTask timerTask = new TimerTask() {
                    @Override
                    public void run() {
                        runOnUiThread(new Runnable() {
                            @Override
                            public void run() {
                                //#Al momento de fallar la condicional se le asignara un shape blanco que mostrará en pantalla como una señal de no tener nada seleccionado
                                lblPareo1.setBackgroundResource(R.drawable.shape_jugabilidad2_palabra);
                                lblPareo2.setBackgroundResource(R.drawable.shape_jugabilidad2_palabra);
                                //#En las variables de los textviews guardada anteriormente al seleccionarlos, se le asigna null para que no haya problemas de vista
                                lblPareo1= null;
                                lblPareo2= null;
                            }
                        });
                    }
                };
                Timer time = new Timer();
                time.schedule(timerTask, 120);
            }
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

    private void AudioTask (String path){

        String hostPort = url.toCompleteURL(path);
        if(mediaPlayer!=null) {
            mediaPlayer.stop();
            mediaPlayer.release();
        }
        try {
            mediaPlayer = MediaPlayer.create(getApplicationContext(), Uri.parse(hostPort));
            //mediaPlayer.prepareAsync();
            mediaPlayer.start();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

}