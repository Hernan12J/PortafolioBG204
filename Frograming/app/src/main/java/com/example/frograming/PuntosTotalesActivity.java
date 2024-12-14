package com.example.frograming;

import android.animation.ObjectAnimator;
import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.WindowManager;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.example.frograming.Helpers.PartidaController;
import com.example.frograming.Modelos.PartidaRequest;
import com.example.frograming.Modelos.PartidaResponse;
import com.example.frograming.Service.ApiService;
import com.google.android.material.appbar.MaterialToolbar;

import java.util.HashMap;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class PuntosTotalesActivity extends AppCompatActivity {

    TextView puntosTotales;
    ImageView rana;
    MaterialToolbar toolbar;
    int pts=0;
    SharedPreferences puntos, progresoSh;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_puntos_totales);

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

        InicializarControles();
        AnimacionLuna();
    }

    private void InicializarControles() {
        puntos = getSharedPreferences("puntos_total", Context.MODE_PRIVATE);
        progresoSh = getSharedPreferences("progreso", Context.MODE_PRIVATE);


        pts = puntos.getInt("puntos_total", 0);

        this.puntosTotales = (TextView) findViewById(R.id.txt_puntos);
        rana = (ImageView) findViewById(R.id.im_rana_puntostoales);
        puntosTotales.setText(pts+"");
        toolbar = (MaterialToolbar) findViewById(R.id.topAppBar);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                onBackPressed();
            }
        });
        HashMap<String, String> preguntasRespondidas = PartidaController.leer(getApplicationContext());
        int usuario_id = Integer.parseInt(preguntasRespondidas.get("usuario_id"));
        for(String key : preguntasRespondidas.keySet()) {
            if (key.equals("usuario_id")) continue;
            enviarPartida(usuario_id, Integer.parseInt(key), Integer.parseInt(preguntasRespondidas.get(key)));
        }

        if(pts<=35){
            rana.setImageResource(R.drawable.jugabilidad_img_lunatriste);

        }else{
            rana.setImageResource(R.drawable.general_img_lunafeliz);

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


    private void AnimacionLuna() {
        ObjectAnimator animation= ObjectAnimator.ofFloat(this.rana, "translationY", -250);
        animation.setDuration(1350);
        animation.start();
    }

    public void Terminar(View v){
        PartidaController.borrarHistorial(this);
        startActivity(new Intent(getApplicationContext(), MenuPrincipalActivity.class));
        finish();
    }

    private void enviarPartida(int usuario_id, int pregunta_id, int puntos_obtenidos) {
        PartidaRequest request = new PartidaRequest();
        request.setUsuario_id(usuario_id);
        request.setPregunta_id(pregunta_id);
        request.setPuntos_obtenidos(puntos_obtenidos);

        Call<List<PartidaResponse>> callPartida = ApiService.getApiService().Partida(request);
        callPartida.enqueue(new Callback<List<PartidaResponse>>() {
            @Override
            public void onResponse(Call<List<PartidaResponse>> call, Response<List<PartidaResponse>> response) {
                System.out.println("Se ha enviado con exito!");
            }

            @Override
            public void onFailure(Call<List<PartidaResponse>> call, Throwable t) {
                System.out.println("ERROR!");
                t.printStackTrace();
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