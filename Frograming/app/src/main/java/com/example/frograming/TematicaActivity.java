package com.example.frograming;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;

import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.WindowManager;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import com.example.frograming.Adaptadores.OpcionesListViewAdapter;
import com.example.frograming.Entidades.OpcionesMenu;
import com.example.frograming.Service.ApiService;
import com.google.android.material.appbar.MaterialToolbar;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class TematicaActivity extends AppCompatActivity {

    ListView lstOpciones;
    TextView name;
    MaterialToolbar toolbar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tematica);

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

        InicializarControles();
        CargarTematicas();
    }

    private void InicializarControles() {
        lstOpciones = (ListView)findViewById(R.id.lstOpciones);
        name = (TextView) findViewById(R.id.bienvenida);
        toolbar = (MaterialToolbar) findViewById(R.id.topAppBar);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                onBackPressed();
            }
        });

        SharedPreferences sesion = getSharedPreferences("sesion",MODE_PRIVATE);
        name.setText("¡Bienvenid@, "+sesion.getString("nombre", "Usuario")+"!");
    }

    private void AttachtEvent(List<OpcionesMenu> opciones) {
        lstOpciones.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> datos, View view, int pos, long l) {
                Intent itn = new Intent(getApplicationContext(), MenuPrincipalActivity.class);
                if(opciones.get(pos).getNombre_tematica().equals("JavaScript")){
                    itn.putExtra("temaid", 2);
                    startActivity(itn);
                }
                else if(opciones.get(pos).getNombre_tematica().equals("Scrum")){
                    itn.putExtra("temaid", 1);
                    startActivity(itn);
                }
            }
        });
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.general_toolbar_menu,menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {

        switch (item.getItemId()){
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

    private void CargarListView(List<OpcionesMenu> lst) {
        OpcionesListViewAdapter adapter = new OpcionesListViewAdapter(this, lst);
        lstOpciones.setAdapter(adapter);

        AttachtEvent(lst);
    }

    public void verPerfil(View v){
        startActivity(new Intent(this, VerPerfilActivity.class));
    }

    private void CargarTematicas() {
        Call<List<OpcionesMenu>> callTemas = ApiService.getApiService().TraerTemas();

        callTemas.enqueue(new Callback<List<OpcionesMenu>>() {
            @Override
            public void onResponse(Call<List<OpcionesMenu>> call, Response<List<OpcionesMenu>> response) {
                if (response.isSuccessful()) {
                    List<OpcionesMenu> lst = response.body();
                    CargarListView(lst);
                }
            }

            @Override
            public void onFailure(Call<List<OpcionesMenu>> call, Throwable t) {
                print("Error al obtener las tematicas.");
            }
        });

    }

    private void print(String msg){
        Toast.makeText(this, msg, Toast.LENGTH_LONG).show();
    }
}