package com.example.frograming;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
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
import android.widget.ScrollView;

import com.example.frograming.Adaptadores.CuentoListViewAdapter;
import com.example.frograming.Entidades.Cuento;
import com.example.frograming.Helpers.MultimediaConcatURL;
import com.example.frograming.Modelos.CuentoResponse;
import com.example.frograming.Service.ApiService;
import com.google.android.material.appbar.MaterialToolbar;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import pl.droidsonroids.gif.GifImageView;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class CuentoActivity extends AppCompatActivity {

    ListView bubbles;
    Button btnContinuar;
    List<CuentoResponse> cuento;
    CuentoListViewAdapter adapter;
    GifImageView izq, der;

    //ScrollView scrlView;
    int pos = 0;
    int temaid; //Aquí está el atributo que almacena el id del tema
    Intent intent;
    MaterialToolbar toolbar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cuento);

        //Aquí recibe el bundle que tendrá el tema id

        temaid = getIntent().getExtras().getInt("temaid");
        InitializeControls();
        OrdenAvatares();
        GetElementsToListViewTemplate();
        AttachtEvent();

    }


    private void InitializeControls()
    {
        bubbles = (ListView) findViewById(R.id.lstBubbles);
        btnContinuar = (Button) findViewById(R.id.btnContinuar);
        izq = (GifImageView)findViewById(R.id.gifIzq);
        der = (GifImageView)findViewById(R.id.gifDer);
        toolbar = (MaterialToolbar) findViewById(R.id.topAppBar);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                onBackPressed();
            }
        });
        //scrlView = (ScrollView) findViewById(R.id.scrlView);
    }

    private void OrdenAvatares()
    {
        if(temaid == 1)
        {
            izq.setImageResource(R.drawable.leccion_img_apolo);
            der.setImageResource(R.drawable.leccion_img_amelie);
        }
        else
        {
            izq.setImageResource(R.drawable.leccion_img_andromeda);
            der.setImageResource(R.drawable.leccion_img_ceres);
        }

    }

    private void GetElementsToListViewTemplate()
    {
        cuento = new ArrayList<CuentoResponse>();
        Call<List<CuentoResponse>> callCuento = ApiService.getApiService().TraerCuento(String.valueOf(temaid));

        callCuento.enqueue(new Callback<List<CuentoResponse>>() {
            @Override
            public void onResponse(Call<List<CuentoResponse>> call, Response<List<CuentoResponse>> response) {
                if(response.isSuccessful())
                {
                    cuento = response.body();
                    List<CuentoResponse> cuentoP = AgregarDialogo(pos, cuento);
                    LoadListViewTemplate(cuentoP);
                    ReproducirAudio(cuento.get(pos));
                }

            }

            @Override
            public void onFailure(Call<List<CuentoResponse>> call, Throwable t) {
                String error = "error";
            }
        });
    }

    private void AttachtEvent()
    {
        bubbles.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                ReproducirAudio(cuento.get(pos));
            }
        });
    }

    public void Continuar(View view)
    {
        intent = new Intent(this, LeccionActivity.class);
        intent.putExtra("temaid", temaid);

        if(pos < (cuento.size()-1))
        {
            pos++;
            List<CuentoResponse> cuentoResponses = AgregarDialogo(pos, cuento);
            LoadListViewTemplate(cuentoResponses);
            ReproducirAudio(cuento.get(pos));
        }
        else
        {
            startActivity(intent);
        }
    }

    private void ReproducirAudio(CuentoResponse mensaje)
    {
        String url = new MultimediaConcatURL().toCompleteURL(mensaje.getAudio());
        Uri myUri = Uri.parse(url);
        MediaPlayer mediaPlayer = new MediaPlayer();
        mediaPlayer.pause();
        try
        {
            mediaPlayer.setDataSource(CuentoActivity.this, myUri);
            mediaPlayer.prepare();
            mediaPlayer.start();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private List<CuentoResponse> AgregarDialogo(int pos, List<CuentoResponse> dale) {
        List<CuentoResponse> filas = new ArrayList<>();
        for(int i = 0; i <= pos; i++)
        {
            filas.add(dale.get(i));
        }

        return filas;
    }

    private void LoadListViewTemplate(List<CuentoResponse> cuentoP)
    {
        adapter = new CuentoListViewAdapter(this,cuentoP);

        bubbles.setAdapter(adapter);

        /*scrlView.post(new Runnable() {
            @Override
            public void run() {
                scrlView.fullScroll(ScrollView.FOCUS_DOWN);
            }
        });*/
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

}