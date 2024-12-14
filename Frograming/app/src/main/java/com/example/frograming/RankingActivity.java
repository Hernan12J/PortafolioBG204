package com.example.frograming;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import com.example.frograming.Adaptadores.RankingListViewAdapter;
import com.example.frograming.Entidades.UsuariosRank;
import com.example.frograming.Modelos.RankingResponse;
import com.example.frograming.Service.ApiService;
import com.google.android.material.appbar.MaterialToolbar;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class RankingActivity extends AppCompatActivity {

    Button BTNatrasTop, BTNpodio, BTNhome;
    LinearLayoutManager layoutManager;
    ListView lstRanking;
    List<RankingResponse> ranking;
    List<UsuariosRank> usuariosRankList;
    int numero;
    TextView txtNombreUsuario, txtPts, topUsuario;
    ImageView imgPerfil;
    MaterialToolbar toolbar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ranking);

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

        prueba();
     /*   BTNatrasTop = (Button) findViewById(R.id.BTNatrasTop);
        BTNatrasTop.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(RankingActivity.this, MenuRankingActivity.class);
                startActivity(i);
            }
        }); */

        BTNpodio = (Button) findViewById(R.id.btnpodio);
        BTNpodio.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(RankingActivity.this, PodioActivity.class));
                overridePendingTransition(R.anim.zoom_in,R.anim.zoom_out);
                Intent i = new Intent(RankingActivity.this, PodioActivity.class);
                i.putExtra("podio", numero);
                startActivity(i);
            }
        });

        layoutManager = new LinearLayoutManager(this);
        // EN ESTA LÍNEA VA EL LLAMADO A LA BD
        InicializarControles();

        layoutManager.setReverseLayout(true); // ORDENA DE Z-A
        layoutManager.setStackFromEnd(true); // EMPIEZA DESDE ARRIBA SIN TENER DESLIZ
        usuariosRankList = new ArrayList<>();

     /*   BTNhome = (Button) findViewById(R.id.BTNhome);
        BTNhome.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(RankingActivity.this, MenuRankingActivity.class);
                startActivity(i);
            }
        });*/
    }

    private void InicializarControles() {
        lstRanking = (ListView) findViewById(R.id.lstRanking);
        txtNombreUsuario = (TextView) findViewById(R.id.txtNombreUsuario);
        txtPts = (TextView) findViewById(R.id.txtPts);
        topUsuario = (TextView) findViewById(R.id.topUsuario);
        imgPerfil = (ImageView) findViewById(R.id.imgPerfil);
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


    private void ObtenerUsuarios(List<RankingResponse> rank) {
        SharedPreferences sesion = getSharedPreferences("sesion", MODE_PRIVATE);

        String id_usuario = sesion.getString("usuario_id", "");
        String nombre_usuario = sesion.getString("nombre", "");

        for (int i = 0; i < rank.size(); i++) {
            if (String.valueOf(rank.get(i).getId()).equals(id_usuario)) { /*La validacion se hace mediante el shared preferences*/
                txtNombreUsuario.setText(rank.get(i).getNombre() + " " + rank.get(i).getApellido());
                txtPts.setText(String.valueOf(rank.get(i).getPuntos()));
                topUsuario.setText(String.valueOf(rank.get(i).getPosicion()));
                imgPerfil.setImageResource(R.drawable.general_img_perfil);
            }
            else{
                txtNombreUsuario.setText(nombre_usuario);
            }
        }
    }

    public void prueba() {
        Intent intent = getIntent();
        if (intent.getIntExtra("numero", 3) == 1) {
            numero = 1;
        } else if (intent.getIntExtra("numero", 3) == 2) {
            numero = 2;
        } else {
            numero = 0;
        }

        try {
            Call<List<RankingResponse>> login = ApiService.getApiService().ObtenerRaking(numero);
            login.enqueue(new Callback<List<RankingResponse>>() {
                @Override
                public void onResponse(Call<List<RankingResponse>> call, Response<List<RankingResponse>> response) {
                    if (response.isSuccessful()) {
                        ranking = response.body();

                        if (ranking.size() >= 10) {
                            RankingListViewAdapter jugador = new RankingListViewAdapter(getApplicationContext(), ranking.subList(0, 10));
                            lstRanking.setAdapter(jugador);
                        } else {
                            RankingListViewAdapter jugador = new RankingListViewAdapter(getApplicationContext(), ranking);
                            lstRanking.setAdapter(jugador);
                        }
                        //seteando el jugador logueado en el ranking
                        ObtenerUsuarios(ranking);
                    }
                }

                @Override
                public void onFailure(Call<List<RankingResponse>> call, Throwable t) {
                    int x = 1;

                }
            });

        } catch (Exception e) {
            Toast.makeText(this, "Error de tipo: " + e, Toast.LENGTH_LONG).show();
        }

    }
}