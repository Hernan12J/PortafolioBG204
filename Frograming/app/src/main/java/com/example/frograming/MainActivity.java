package com.example.frograming;

import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.google.android.material.appbar.MaterialToolbar;

public class MainActivity extends AppCompatActivity {

    ImageButton jugabilidad1_btnOpcion1,jugabilidad1_btnOpcion2,jugabilidad1_btnOpcion3,jugabilidad1_btnOpcion4;
    TextView jugabilidad1_txt_Opcion1,jugabilidad1_txt_Opcion2,jugabilidad1_txt_Opcion3,jugabilidad1_txt_Opcion4, Jugabilidad1_txt_pregunta;
    Button jugabilidad1_btn_Continuar;
    ImageView jugabilidad1_Selected_imgShape1,jugabilidad1_Selected_imgShape2,jugabilidad1_Selected_imgShape3,jugabilidad1_Selected_imgShape4,jugabilidad1_Unselected_imgShape1,jugabilidad1_Unselected_imgShape2,jugabilidad1_Unselected_imgShape3,jugabilidad1_Unselected_imgShape4;
    MaterialToolbar toolbar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        InicializarControles();
        ClickButtons();

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);
    }

    private void ClickButtons() {
        jugabilidad1_btnOpcion1.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                jugabilidad1_Selected_imgShape1.setVisibility(View.VISIBLE);
                jugabilidad1_Unselected_imgShape1.setVisibility(View.INVISIBLE);

                jugabilidad1_Selected_imgShape2.setVisibility(View.INVISIBLE);
                jugabilidad1_Selected_imgShape3.setVisibility(View.INVISIBLE);
                jugabilidad1_Selected_imgShape4.setVisibility(View.INVISIBLE);

                //String respuesta = jugabilidad1_txt_Opcion1.get

            }
        });
        jugabilidad1_btnOpcion2.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                Toast.makeText(MainActivity.this, "Selecciono boton 2", Toast.LENGTH_SHORT).show();
            }
        });
        jugabilidad1_btnOpcion3.setOnClickListener(new View.OnClickListener() {
            public void onClick(View v) {
                Toast.makeText(MainActivity.this, "Selecciono boton 3", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void InicializarControles() {
        toolbar = (MaterialToolbar) findViewById(R.id.topAppBar);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                onBackPressed();
            }
        });

        //ImageButton-imagenRespuesta
        this.jugabilidad1_btnOpcion1 = (ImageButton) findViewById(R.id.jugabilidad1_btn_opcion1);
        this.jugabilidad1_btnOpcion2 = (ImageButton) findViewById(R.id.jugabilidad1_btn_opcion2);
        this.jugabilidad1_btnOpcion3 = (ImageButton) findViewById(R.id.jugabilidad1_btn_opcion3);
        this.jugabilidad1_btnOpcion4 = (ImageButton) findViewById(R.id.jugabilidad1_btn_opcion4);
        //TextView-OpcionRespuesta
        this.jugabilidad1_txt_Opcion1=(TextView) findViewById(R.id.jugabilidad1_txt_opcion1);
        this.jugabilidad1_txt_Opcion2=(TextView) findViewById(R.id.jugabilidad1_txt_opcion2);
        this.jugabilidad1_txt_Opcion3=(TextView) findViewById(R.id.jugabilidad1_txt_opcion4);
        this.jugabilidad1_txt_Opcion4=(TextView) findViewById(R.id.jugabilidad1_txt_opcion4);
        //Button-boton_continuar
        this.jugabilidad1_btn_Continuar = (Button) findViewById(R.id.jugabilidad1_btn_continuar);

        //Textview-Pregunta
        this.Jugabilidad1_txt_pregunta =(TextView) findViewById(R.id.jugabilidad1_txt_pregunta);
        //imageView-shapes
        this.jugabilidad1_Selected_imgShape1=(ImageView) findViewById(R.id.jugabilidad1_Selected_imgShape1);
        this.jugabilidad1_Selected_imgShape2=(ImageView) findViewById(R.id.jugabilidad1_Selected_imgShape2);
        this.jugabilidad1_Selected_imgShape3=(ImageView) findViewById(R.id.jugabilidad1_Selected_imgShape3);
        this.jugabilidad1_Selected_imgShape4=(ImageView) findViewById(R.id.jugabilidad1_Selected_imgShape4);

        this.jugabilidad1_Unselected_imgShape1=(ImageView) findViewById(R.id.jugabilidad1_Unselected_imgShape1);
        this.jugabilidad1_Unselected_imgShape2=(ImageView) findViewById(R.id.jugabilidad1_Unselected_imgShape2);
        this.jugabilidad1_Unselected_imgShape3=(ImageView) findViewById(R.id.jugabilidad1_Unselected_imgShape3);
        this.jugabilidad1_Unselected_imgShape4=(ImageView) findViewById(R.id.jugabilidad1_Unselected_imgShape4);

        //restablecer-shapes >> unselected
        this.jugabilidad1_Selected_imgShape1.setVisibility(View.INVISIBLE);
        this.jugabilidad1_Selected_imgShape2.setVisibility(View.INVISIBLE);
        this.jugabilidad1_Selected_imgShape3.setVisibility(View.INVISIBLE);
        this.jugabilidad1_Selected_imgShape4.setVisibility(View.INVISIBLE);



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