package com.example.frograming;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.view.View;
import android.view.WindowManager;
import android.widget.EditText;
import android.widget.Toast;

import com.example.frograming.Helpers.Hash;
import com.example.frograming.Modelos.LastSesionResponse;
import com.example.frograming.Modelos.LoginRequest;
import com.example.frograming.Modelos.LoginResponse;
import com.example.frograming.Modelos.SesionResponse;
import com.example.frograming.Service.ApiService;
import com.google.android.material.appbar.MaterialToolbar;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class InicioSesionActivity extends AppCompatActivity {

    EditText correo, contrasena;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        setTheme(R.style.Theme_Frograming);
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_inicio_sesion);
        InicializarControles();

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);
    }

    private void InicializarControles() {
        correo = (EditText)findViewById(R.id.txtCorreo);
        contrasena = (EditText) findViewById(R.id.txtContrasena);
    }

    public void ValidarUsuario(View v) {
        try {
            Hash md5 = new Hash(contrasena.getText().toString());
            String contrasenaHash = md5.tomd5();
            LoginRequest request = new LoginRequest();
            request.setCorreo(correo.getText().toString());
            request.setContrasena(contrasenaHash);

            Call<LoginResponse> login = ApiService.getApiService().Loguear(request);
            login.enqueue(new Callback<LoginResponse>() {
                @Override
                public void onResponse(Call<LoginResponse> call, Response<LoginResponse> response) {
                    if (response.isSuccessful()) {
                        LoginResponse loginCorrecto = response.body();

                        //Guardando SharedP. del usuario logueado
                        SharedPreferences sesion = getSharedPreferences("sesion",MODE_PRIVATE);
                        SharedPreferences.Editor editor = sesion.edit();
                        editor.putString("nombre", loginCorrecto.getNombre());
                        editor.putString("usuario_id", String.valueOf(loginCorrecto.getUsuario_id()));
                        editor.commit();
                        verificarTutorial(String.valueOf(loginCorrecto.getUsuario_id()));
                        guardarSesionDate(String.valueOf(loginCorrecto.getUsuario_id()));
                        loged();
                    }
                }

                @Override
                public void onFailure(Call<LoginResponse> call, Throwable t) {
                    notloged("Credenciales Incorrectas, Intente nuevamente!");
                }
            });
        } catch (Exception e) {
            Toast.makeText(this,"Error de tipo: "+e, Toast.LENGTH_LONG).show();
        }
    }

    private void verificarTutorial(String usuarioid) {

        Call<List<SesionResponse>> callSesion = ApiService.getApiService().TraerLastSesion(usuarioid);

        callSesion.enqueue(new Callback<List<SesionResponse>>() {
            @Override
            public void onResponse(Call<List<SesionResponse>> call, Response<List<SesionResponse>> response) {
                if (response.isSuccessful()){
                    SharedPreferences tutorial = getSharedPreferences("tutorial",MODE_PRIVATE);
                    SharedPreferences.Editor editor = tutorial.edit();
                    editor.putBoolean("visto", true);
                    List<SesionResponse> respSesion = response.body();
                    if(respSesion.isEmpty()){
                        notloged("Error al conseguir la información sobre la última sesion!");
                    }else if (respSesion.get(0).getFecha_login() == null){
                        editor.putBoolean("visto", false);
                    }
                    editor.commit();
                }
            }

            @Override
            public void onFailure(Call<List<SesionResponse>> call, Throwable t) {

            }
        });
    }

    private void guardarSesionDate(String usuarioid) {
        Call<LastSesionResponse> callSesion = ApiService.getApiService().ultimaSesion(usuarioid);

        callSesion.enqueue(new Callback<LastSesionResponse>() {
            @Override
            public void onResponse(Call<LastSesionResponse> call, Response<LastSesionResponse> response) {
                if(response.isSuccessful()){
                    //notloged("Fecha de inicio de sesion guardada!");
                }
            }

            @Override
            public void onFailure(Call<LastSesionResponse> call, Throwable t) {

            }
        });
    }

    public void loged(){
        startActivity(new Intent(this, TematicaActivity.class));
    }

    public void notloged(String msg){
        Toast.makeText(this,msg, Toast.LENGTH_LONG).show();
    }

    public void contrasenaOlvidada(View v){
        startActivity(new Intent(this, RecuperarContrasenaActivity.class));
    }

    public void sinCuenta(View v){
        startActivity(new Intent(this, RegistroActivity.class));
    }

}