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
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import com.example.frograming.Helpers.MultimediaConcatURL;
import com.example.frograming.Modelos.PerfilResponse;
import com.example.frograming.Service.ApiService;
import com.google.android.material.appbar.MaterialToolbar;

import java.net.URL;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class VerPerfilActivity extends AppCompatActivity {

    TextView nombreCompleto ,cedula,correo ,facultad,carrera,grupo;
    ImageView imagenPerfil;
    MaterialToolbar toolbar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ver_perfil);

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

        inicializarControladore();
        AsignacionValores();
    }


    private void inicializarControladore() {
        cedula = (TextView) findViewById(R.id.v_txtCedula);
        correo  = (TextView) findViewById(R.id.v_txtCorreo);
        facultad = (TextView) findViewById(R.id.v_txtFacultad);
        carrera = (TextView) findViewById(R.id.v_txtCarrera);
        grupo = (TextView) findViewById(R.id.v_txtGrupo);
        nombreCompleto = (TextView) findViewById(R.id.v_txtBienvenida);
        imagenPerfil = (ImageView) findViewById(R.id.v_imgFoto);
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


    private void AsignacionValores() {
        SharedPreferences sesion = getSharedPreferences("sesion",MODE_PRIVATE);
        Call<PerfilResponse> callPerfil = ApiService.getApiService().TraerPerfil(sesion.getString("usuario_id", ""));

        callPerfil.enqueue(new Callback<PerfilResponse>() {
            @Override
            public void onResponse(Call<PerfilResponse> call, Response<PerfilResponse> response) {
                PerfilResponse perfil = response.body();

                //Asignando los valores a los TextView
                nombreCompleto.setText("Bienvenido  "+perfil.getNombre()+" "+perfil.getApellido());
                cedula.setText(perfil.getCedula());
                correo.setText(perfil.getCorreo());
                facultad.setText(perfil.getFacultad());
                carrera.setText(perfil.getCarrera());
                grupo.setText(perfil.getGrupo());
                try{
                    URL url = new URL(new MultimediaConcatURL().toCompleteURL(perfil.getImagen()));
                    Bitmap bmp = BitmapFactory.decodeStream(url.openConnection().getInputStream());

                    imagenPerfil.setImageBitmap(bmp);
                }catch (Exception e){
                    Toast.makeText(getApplicationContext(),"Error"+e, Toast.LENGTH_LONG).show();
                }

                //Asignando los valores a un sharedPreference para utilizarlo en la edición del perfil.
                SharedPreferences userProfile = getSharedPreferences("userProfile", MODE_PRIVATE);
                SharedPreferences.Editor editor = userProfile.edit();
                editor.putString("nombre", perfil.getNombre());
                editor.putString("apellido", perfil.getApellido());
                editor.putString("correo", perfil.getCorreo());
                editor.putString("contrasena", perfil.getContrasena());
                editor.putString("urlFoto", perfil.getImagen());
                editor.commit();
            }

            @Override
            public void onFailure(Call<PerfilResponse> call, Throwable t) {
                print("Error al traer el Perfil");
            }
        });
    }

    public void Editar(View v){
        startActivity(new Intent(this,EditarPerfilActivity.class));

    }

    public void print(String msg){
        Toast.makeText(this, msg, Toast.LENGTH_LONG).show();
    }
}