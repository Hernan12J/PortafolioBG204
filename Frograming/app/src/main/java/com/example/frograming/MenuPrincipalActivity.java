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
import android.widget.Toast;

import com.example.frograming.Adaptadores.OpcionesPrincipalAdapter;
import com.example.frograming.Entidades.OpcionesMenuPrincipal;
import com.example.frograming.Helpers.Jugabilidad;
import com.example.frograming.Helpers.PartidaController;
import com.google.android.material.appbar.MaterialToolbar;

import java.util.ArrayList;
import java.util.List;
import java.util.Timer;
import java.util.TimerTask;

public class MenuPrincipalActivity extends AppCompatActivity {

    ListView lstOpciones;
    List<OpcionesMenuPrincipal> templist = new ArrayList<>();
    int temaid=1;
    MaterialToolbar toolbar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu_principal);

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

        goTutorial();

        if(!(getIntent().getExtras() == null)){
            temaid = getIntent().getExtras().getInt("temaid");
        }
        InicializarControles();
        AttachtEvent();
    }

    private void goTutorial() {
        SharedPreferences tutorial = getSharedPreferences("tutorial",MODE_PRIVATE);
        if(!tutorial.getBoolean("visto",true)){
            startActivity(new Intent(this, TutorialActivity.class));
        }
    }

    private void print(String s) {
    }

    private void InicializarControles() {
        lstOpciones = (ListView)findViewById(R.id.lstOpciones);
        toolbar = (MaterialToolbar) findViewById(R.id.topAppBar);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                startActivity(new Intent(getApplicationContext(), TematicaActivity.class));
                //onBackPressed();
            }
        });
        CargarListView();
    }



    private void AttachtEvent() {
        lstOpciones.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> datos, View view, int pos, long l) {
                List<OpcionesMenuPrincipal> opciones = templist;
                int opcion;
                if(opciones.get(pos).getOpcionNombre().equals("Lección")){
                    opcion=0;
                    tematicaSeleccionada(opcion);
                    Toast.makeText(getApplicationContext() , "Has seleccionado la opcion " +opciones.get(pos).getOpcionNombre(),Toast.LENGTH_LONG).show();
                }
                else if(opciones.get(pos).getOpcionNombre().equals("Jugar")){
                    opcion=1;
                    tematicaSeleccionada(opcion);
                    Toast.makeText(getApplicationContext() , "Has seleccionado la opcion "  +opciones.get(pos).getOpcionNombre(),Toast.LENGTH_LONG).show();
                }
                else if(opciones.get(pos).getOpcionNombre().equals("Ranking")){
                    opcion=2;
                    tematicaSeleccionada(opcion);
                    Toast.makeText(getApplicationContext() , "Has seleccionado la opcion "  +opciones.get(pos).getOpcionNombre(),Toast.LENGTH_LONG).show();
                }
                Toast.makeText(getApplicationContext() , "Has seleccionado la opcion "+opciones.get(pos).getOpcionNombre() ,Toast.LENGTH_LONG).show();
                OpcionesPrincipalAdapter adapterActualizado = new OpcionesPrincipalAdapter(getApplicationContext(),opciones);
                lstOpciones.setAdapter(adapterActualizado);
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

    public boolean tematicaSeleccionada(int opcion){
        switch (opcion){
            case 0:
                Intent itn = new Intent(this, CuentoActivity.class);
                itn.putExtra("temaid", temaid);
                startActivity(itn);
                break;
            case 1:
                Jugabilidad jug = new Jugabilidad(getApplicationContext());
                jug.borrarDatosPreferences();
                jug.obtenerDatosJugabilidad(temaid);
                jug.obtenerDatosPareo(temaid);
                PartidaController.comenzarPartida(getApplicationContext());
                PartidaController.borrarHistorial(getApplicationContext());

                //Aqui va el id del usuario
                SharedPreferences sesion = getSharedPreferences("sesion", MODE_PRIVATE);
                PartidaController.agregar(getApplicationContext(), "usuario_id", sesion.getString("usuario_id", ""));

                TimerTask timertask = new TimerTask() {
                    @Override
                    public void run() {
                        startActivity(jug.cambiarModo());
                        finish();
                    }
                };

                Timer time = new Timer();
                time.schedule(timertask, 1000);
                break;
            case 2:
                startActivity(new Intent(this, MenuRankingActivity.class));
                break;
            default:
                return true;
        }
        return true;
    }

    private void CargarListView() {
        List<OpcionesMenuPrincipal> optMenu = this.ObtenerOpciones();
        templist = optMenu;
        OpcionesPrincipalAdapter adapter = new OpcionesPrincipalAdapter(this, optMenu);
        lstOpciones.setAdapter(adapter);
    }

    private List<OpcionesMenuPrincipal> ObtenerOpciones() {
        List<OpcionesMenuPrincipal> optMenu = new ArrayList<OpcionesMenuPrincipal>();
        optMenu.add(new OpcionesMenuPrincipal("Lección", R.drawable.autenticacion_img_leccion));
        optMenu.add(new OpcionesMenuPrincipal("Jugar", R.drawable.autenticacion_img_jugar));
        optMenu.add(new OpcionesMenuPrincipal("Ranking", R.drawable.autenticacion_img_ranking));
        return optMenu;
    }


}