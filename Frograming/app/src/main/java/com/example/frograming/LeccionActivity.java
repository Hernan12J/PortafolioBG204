package com.example.frograming;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.WindowManager;
import android.widget.MediaController;
import android.widget.TextView;
import android.widget.VideoView;

import com.example.frograming.Helpers.MultimediaConcatURL;
import com.example.frograming.Modelos.LeccionResponse;
import com.example.frograming.Service.ApiService;
import com.google.android.material.appbar.MaterialToolbar;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class LeccionActivity extends AppCompatActivity {

    VideoView video;
    TextView lblTextoLectura;
    MaterialToolbar toolbar;
    int temaid = 1; // Atributo que recibe el bundle con la temáticaid

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_leccion);

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

        temaid = getIntent().getExtras().getInt("temaid");

        InitializeControls();
        ObtenerData();
    }

    private void ObtenerData()
    {
        Call<LeccionResponse> callLeccion = ApiService.getApiService().TraerLeccion(String.valueOf(temaid));

        callLeccion.enqueue(new Callback<LeccionResponse>() {
            @Override
            public void onResponse(Call<LeccionResponse> call, Response<LeccionResponse> response)
            {
                LeccionResponse leccion = response.body();
                lblTextoLectura.setText(leccion.getContenido());
                video.setVideoPath(new MultimediaConcatURL().toCompleteURL(leccion.getVideo()));
                MediaController mediaController = new MediaController(LeccionActivity.this);
                mediaController.setAnchorView(video);
                video.setMediaController(mediaController);
            }

            @Override
            public void onFailure(Call<LeccionResponse> call, Throwable t) {

            }
        });
    }

    private void InitializeControls()
    {
        video = (VideoView)findViewById(R.id.video);
        lblTextoLectura = (TextView) findViewById(R.id.lblTextoLectura);
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

    public void Continuar(View view)
    {
        Intent itn = new Intent(this, MenuPrincipalActivity.class);
        itn.putExtra("temaid", temaid);
        startActivity(itn);
    }
}