package com.example.frograming;

import android.animation.ObjectAnimator;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.media.MediaPlayer;
import android.net.Uri;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.google.android.material.appbar.MaterialToolbar;

import java.io.IOException;

public class RetroalimentacionActivity extends AppCompatActivity {

    Button btn_continuar;
    TextView Retroalimentacion;
    ImageView Rana, check;
    MediaPlayer mediaPlayer = new MediaPlayer();
    MaterialToolbar toolbar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_retroalimentacion);

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

        inicializarControles();
        AnimacionLuna();

        btn_continuar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                // DetenerAudio(); para detener el audio reproduciendose a la hora de cambiar de Activity
                Intent pantallaCarga = new Intent(getApplicationContext(), LoaderActivity.class);
                startActivity(pantallaCarga);
            }
        });

    }

    private void AnimacionLuna() {
        ObjectAnimator animation= ObjectAnimator.ofFloat(this.Rana, "translationY", -350);
        animation.setDuration(1350);
        animation.start();
    }

    private void inicializarControles() {
        btn_continuar = (Button) findViewById(R.id.btn_continuar);
        Retroalimentacion=(TextView)findViewById(R.id.txt_descripcion_retroalimentacion);
        Rana=(ImageView) findViewById(R.id.imgLogo);
        check=(ImageView) findViewById(R.id.imgcheck);
        toolbar = (MaterialToolbar) findViewById(R.id.topAppBar);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                onBackPressed();
            }
        });
        Intent i = getIntent();
        String retroalimentacion = i.getStringExtra("retro");
        int resp = Integer.parseInt(i.getStringExtra("AoF"));

        String Ruta = i.getStringExtra("AudioRetro");    /////Descomentar esto para reproducir
        if(Ruta != null) {
            ReproducirAudio(Ruta);                            //// el audio de la retroalimentacion
        }

        if(retroalimentacion.length()>=70){
            Retroalimentacion.setTextSize(10);
        }else if(retroalimentacion.length()>=20 &&  retroalimentacion.length() <=69){
            Retroalimentacion.setTextSize(18);
        }
        else if(retroalimentacion.length()>=10 && retroalimentacion.length()<=19){
            Retroalimentacion.setTextSize(35);
        }



        if(retroalimentacion == null){
            Retroalimentacion.setText("HAZ ABANDONADO EL JUEGO");
        }else{
            if(resp==1){
                Retroalimentacion.setText(retroalimentacion);
                Rana.setImageResource(R.drawable.general_img_lunafeliz);
                check.setImageResource(R.drawable.jugabilidad_img_correcto);
            }else{
                Retroalimentacion.setText(retroalimentacion);
            }
        }
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



    private void ReproducirAudio(String url){

        Uri myUri = Uri.parse(url);
        mediaPlayer = new MediaPlayer();
        try {
            mediaPlayer.setDataSource(RetroalimentacionActivity.this,myUri);
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

    public void DetenerAudio(){
        try{
            mediaPlayer.stop();
            mediaPlayer.release();

        }catch (Exception e){

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