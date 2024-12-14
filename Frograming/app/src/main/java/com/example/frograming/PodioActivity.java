package com.example.frograming;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import com.example.frograming.Helpers.MultimediaConcatURL;
import com.example.frograming.Modelos.RankingResponse;
import com.example.frograming.Service.ApiService;
import com.google.android.material.appbar.MaterialToolbar;

import java.net.URL;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class PodioActivity extends AppCompatActivity {


    Button BTNtop10,BTNatrasTop,BTNhome;
    List<RankingResponse> ranking;
    TextView nombre1,nombre2,nombre3;
    TextView apellido1,apellido2,apellido3;
    TextView puntos1,puntos2,puntos3;
    ImageView foto1,foto2,foto3;
    MaterialToolbar toolbar;

    @Override
    public void onBackPressed() {
        super.onBackPressed();
        overridePendingTransition(R.anim.zoom_in,R.anim.zoom_out);
    }
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_podio);

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

        InicializarControles();
        prueba();

/*
        BTNhome = (Button) findViewById(R.id.BTNhome);
        BTNhome.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(getApplicationContext(), MenuRankingActivity.class);
                startActivity(i);
            }
        });

        BTNatrasTop = (Button) findViewById(R.id.BTNatrasTop);
        BTNatrasTop.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Intent i = new Intent(getApplicationContext(), RankingActivity.class);
                startActivity(i);
            }
        });*/


        BTNtop10 = (Button) findViewById(R.id.btntop);
        BTNtop10.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                onBackPressed();
                overridePendingTransition(R.anim.zoom_in,R.anim.zoom_out);
                Intent i = new Intent(getApplicationContext(), RankingActivity.class);
                startActivity(i);
            }
        });

    }

    private void InicializarControles() {
        nombre1 = (TextView) findViewById(R.id.nombre1);
        nombre2 = (TextView) findViewById(R.id.nombre2);
        nombre3 = (TextView) findViewById(R.id.nombre3);

        puntos1 = (TextView) findViewById(R.id.puntos1);
        puntos2 = (TextView) findViewById(R.id.puntos2);
        puntos3 = (TextView) findViewById(R.id.puntos3);

        foto1 = (ImageView) findViewById(R.id.imgtop1);
        foto2 = (ImageView) findViewById(R.id.imgtop2);
        foto2 = (ImageView) findViewById(R.id.imgtop3);

        toolbar = (MaterialToolbar) findViewById(R.id.topAppBar);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                onBackPressed();
            }
        });
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

    public void prueba() {
        int numero;
        Intent intent = getIntent();
        if(intent.getIntExtra("podio", 3)==1)
        {
            numero = 1;
        }else if (intent.getIntExtra("podio", 3)==2)
        {
            numero = 2;
        }else
        {
            numero = 0;
        }

        try {
            Call<List<RankingResponse>> login = ApiService.getApiService().ObtenerRaking(numero);
            login.enqueue(new Callback<List<RankingResponse>>() {
                @Override
                public void onResponse(Call<List<RankingResponse>> call, Response<List<RankingResponse>> response) {
                    if (response.isSuccessful()) {
                        ranking = response.body();

                        if (ranking.size()==1){
                            nombre1.setText(ranking.get(0).getNombre() +" "+ ranking.get(0).getApellido()+ " pts.");
                            puntos1.setText(String.valueOf(ranking.get(0).getPuntos()));

                            try{
                                URL url = new URL(new MultimediaConcatURL().toCompleteURL(ranking.get(0).getImagen()));
                                Bitmap bmp = BitmapFactory.decodeStream(url.openConnection().getInputStream());
                                foto1.setImageBitmap(bmp);
                            }catch (Exception e){
                                Toast.makeText(getApplicationContext(),"Error url"+e, Toast.LENGTH_LONG).show();
                            }

                        }else if (ranking.size()==2){
                            nombre1.setText(ranking.get(0).getNombre() + " pts.");
                            puntos1.setText(String.valueOf(ranking.get(0).getPuntos()));
                            try{
                                URL url = new URL(new MultimediaConcatURL().toCompleteURL(ranking.get(0).getImagen()));
                                Bitmap bmp = BitmapFactory.decodeStream(url.openConnection().getInputStream());
                                foto1.setImageBitmap(bmp);
                            }catch (Exception e){
                                Toast.makeText(getApplicationContext(),"Error url"+e, Toast.LENGTH_LONG).show();
                            }

                            nombre2.setText(ranking.get(1).getNombre());
                            puntos2.setText(String.valueOf(ranking.get(1).getPuntos()));
                            try{
                                URL url = new URL(new MultimediaConcatURL().toCompleteURL(ranking.get(1).getImagen()));
                                Bitmap bmp = BitmapFactory.decodeStream(url.openConnection().getInputStream());
                                foto2.setImageBitmap(bmp);
                            }catch (Exception e){
                                Toast.makeText(getApplicationContext(),"Error url"+e, Toast.LENGTH_LONG).show();
                            }
                        }else{
                            nombre1.setText(ranking.get(0).getNombre());
                            puntos1.setText(String.valueOf(ranking.get(0).getPuntos()));
                            try{
                                URL url = new URL(new MultimediaConcatURL().toCompleteURL(ranking.get(0).getImagen()));
                                Bitmap bmp = BitmapFactory.decodeStream(url.openConnection().getInputStream());
                                foto1.setImageBitmap(bmp);
                            }catch (Exception e){
                                Toast.makeText(getApplicationContext(),"Error url"+e, Toast.LENGTH_LONG).show();
                            }

                            nombre2.setText(ranking.get(1).getNombre());
                            puntos2.setText(String.valueOf(ranking.get(1).getPuntos()));
                            try{
                                URL url = new URL(new MultimediaConcatURL().toCompleteURL(ranking.get(1).getImagen()));
                                Bitmap bmp = BitmapFactory.decodeStream(url.openConnection().getInputStream());
                                foto2.setImageBitmap(bmp);
                            }catch (Exception e){
                                Toast.makeText(getApplicationContext(),"Error url"+e, Toast.LENGTH_LONG).show();
                            }

                            nombre3.setText(ranking.get(2).getNombre());
                            puntos3.setText(String.valueOf(ranking.get(2).getPuntos()+" "));
                            try{
                                URL url = new URL(new MultimediaConcatURL().toCompleteURL(ranking.get(2).getImagen()));
                                Bitmap bmp = BitmapFactory.decodeStream(url.openConnection().getInputStream());
                                foto3.setImageBitmap(bmp);
                            }catch (Exception e){
                                Toast.makeText(getApplicationContext(),"Error url"+e, Toast.LENGTH_LONG).show();
                            }
                        }
                    }
                }
                @Override
                public void onFailure(Call<List<RankingResponse>> call, Throwable t) {

                }
            });

        } catch (Exception e) {
            Toast.makeText(this,"Error de tipo: "+e, Toast.LENGTH_LONG).show();
        }

    }

    private void ObtenerUsuarios(List<RankingResponse> rank) {

        SharedPreferences sesion = getSharedPreferences("sesion",MODE_PRIVATE);

        boolean encontrado = false;
        do{
            for (int i = 0; i < rank.size(); i++){
                int usuarioid = rank.get(i).getId();
                if(String.valueOf(usuarioid) == sesion.getString("usuario_id", "")){
                    encontrado = true;

                }else{
                    encontrado = false;
                }
            }
        }while (encontrado == false);
    }
}