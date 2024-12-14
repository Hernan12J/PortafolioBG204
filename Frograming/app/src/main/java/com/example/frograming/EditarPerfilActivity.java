package com.example.frograming;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
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
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.ScrollView;
import android.widget.Toast;

import com.example.frograming.Helpers.Hash;
import com.example.frograming.Helpers.MultimediaConcatURL;
import com.example.frograming.Modelos.EliminarPerfilResponse;
import com.example.frograming.Modelos.UpdatePerfilRequest;
import com.example.frograming.Modelos.UpdatePerfilResponse;
import com.example.frograming.Service.ApiService;
import com.google.android.material.appbar.MaterialToolbar;

import java.net.URL;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

import android.app.AlertDialog;
import android.content.DialogInterface;

public class EditarPerfilActivity extends AppCompatActivity {

    private String contrasena;
    private boolean validacion;
    MaterialToolbar toolbar;
    ImageView imgFoto;
    private EditText nombre, apellido, cedula, correo, contrasena1, contrasena2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_editar_perfil);
        InicializarControles();

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

    }

    private void InicializarControles() {
        nombre = (EditText)findViewById(R.id.E_txtNombre);
        apellido = (EditText)findViewById(R.id.E_txtApellido);
        correo = (EditText)findViewById(R.id.E_txtCorreo);
        contrasena1 = (EditText)findViewById(R.id.E_txtContrasena);
        contrasena2 = (EditText)findViewById(R.id.E_txtConfirmar);
        imgFoto = findViewById(R.id.imgFoto);
        toolbar = (MaterialToolbar) findViewById(R.id.topAppBar);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                onBackPressed();
            }
        });
        cargarDatos();
    }

    private void cargarDatos() {
        SharedPreferences userProfile = getSharedPreferences("userProfile", MODE_PRIVATE);
        nombre.setText(userProfile.getString("nombre", ""));
        apellido.setText(userProfile.getString("apellido", ""));
        correo.setText(userProfile.getString("correo", ""));
        try{
            URL url = new URL(new MultimediaConcatURL().toCompleteURL(userProfile.getString("urlFoto", "generales/imagenes/usuario_IMG_001.png")));
            Bitmap bmp = BitmapFactory.decodeStream(url.openConnection().getInputStream());

            imgFoto.setImageBitmap(bmp);
        }catch (Exception e){
            Toast.makeText(getApplicationContext(),"Error"+e, Toast.LENGTH_LONG).show();
        }
    }

    @Override
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

    public boolean validarContrasena(String pass1, String pass2){
        boolean validacion = false;
        if(pass1 != null && pass2 != null) {
            if (pass1.equals(pass2)) {
                validacion = true;
                contrasena=pass1;
            }
        }
        else{
            validacion = false;
        }
        return validacion;
    }


    private boolean isEmpty(EditText etText) {if (etText.getText().toString().trim().length() > 0) return true; return false; }


    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
    }

    public void guardarCambios(View v){
        SharedPreferences userProfile = getSharedPreferences("userProfile", MODE_PRIVATE);
        SharedPreferences sesion = getSharedPreferences("sesion", MODE_PRIVATE);

        if(!nombre.getText().toString().equals("") && !apellido.getText().toString().equals("") && !correo.getText().toString().equals("")){
            if(contrasena1.getText().toString().equals("")&&contrasena2.getText().toString().equals("")){
                //Envio de datos al API con la contraseña original
                UpdatePerfilRequest request = new UpdatePerfilRequest();
                request.setUsuario_id(sesion.getString("usuario_id", ""));
                request.setNombre(nombre.getText().toString());
                request.setApellido(apellido.getText().toString());
                request.setCorreo(correo.getText().toString());
                request.setContrasena(userProfile.getString("contrasena", ""));

                Call<List<UpdatePerfilResponse>> callUpPerfil = ApiService.getApiService().GuardarPerfil(request);
                callUpPerfil.enqueue(new Callback<List<UpdatePerfilResponse>>() {
                    @Override
                    public void onResponse(Call<List<UpdatePerfilResponse>> call, Response<List<UpdatePerfilResponse>> response) {
                        List<UpdatePerfilResponse> rsp = response.body();
                        if (rsp.isEmpty()){
                            print("Guardado con exito!");
                            startActivity(new Intent(getApplicationContext(), VerPerfilActivity.class));
                        } else {
                            print(rsp.get(0).getMensaje());
                        }
                    }

                    @Override
                    public void onFailure(Call<List<UpdatePerfilResponse>> call, Throwable t) {
                        print("Error: "+t);
                    }
                });
            }
            else if(validarContrasena(contrasena1.getText().toString(), contrasena2.getText().toString())){
                //Envio de los datos al API con la nueva contraseña
                UpdatePerfilRequest request = new UpdatePerfilRequest();
                request.setUsuario_id(sesion.getString("usuario_id", ""));
                request.setNombre(nombre.getText().toString());
                request.setApellido(apellido.getText().toString());
                request.setCorreo(correo.getText().toString());
                request.setContrasena(new Hash(contrasena).tomd5());

                Call<List<UpdatePerfilResponse>> callUpPerfil = ApiService.getApiService().GuardarPerfil(request);
                callUpPerfil.enqueue(new Callback<List<UpdatePerfilResponse>>() {
                    @Override
                    public void onResponse(Call<List<UpdatePerfilResponse>> call, Response<List<UpdatePerfilResponse>> response) {
                        List<UpdatePerfilResponse> rsp = response.body();
                        if (rsp.isEmpty()){
                            print("Guardado con exito!");
                            startActivity(new Intent(getApplicationContext(), VerPerfilActivity.class));
                        } else {
                            print(rsp.get(0).getMensaje());
                        }
                    }

                    @Override
                    public void onFailure(Call<List<UpdatePerfilResponse>> call, Throwable t) {
                        print("Error: "+t);
                    }

                });
            }
            else {
                Toast.makeText(this,"Las contraseñas deben ser iguales!", Toast.LENGTH_LONG).show();
            }
        }else {
            Toast.makeText(this, "No puede dejar campos en blanco!", Toast.LENGTH_LONG).show();
        }
    }

    public void eliminarPerfil(View v){
        AlertDialog dialogo = new AlertDialog
                .Builder(EditarPerfilActivity.this) // NombreDeTuActividad.this, o getActivity() si es dentro de un fragmento
                .setPositiveButton("Sí, eliminar", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        // Hicieron click en el botón positivo, así que la acción está confirmada
                        deleteConfirmed();
                    }
                })
                .setNegativeButton("Cancelar", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        // Hicieron click en el botón negativo, no confirmaron
                        // Simplemente descartamos el diálogo
                        dialog.dismiss();
                    }
                })
                .setTitle("Confirmar") // El título
                .setMessage("¿Deseas eliminar Compra de galletas?") // El mensaje
                .create();// No olvides llamar a Create, ¡pues eso crea el AlertDialog!
        dialogo.show();

    }

    private void deleteConfirmed(){
        SharedPreferences sesion = getSharedPreferences("sesion", MODE_PRIVATE);
        Call<List<EliminarPerfilResponse>> callDelPerfil = ApiService.getApiService().EliminarUsuario(sesion.getString("usuario_id", ""));

        callDelPerfil.enqueue(new Callback<List<EliminarPerfilResponse>>() {
            @Override
            public void onResponse(Call<List<EliminarPerfilResponse>> call, Response<List<EliminarPerfilResponse>> response) {
                List<EliminarPerfilResponse> rsp = response.body();
                if (rsp.isEmpty()){
                    print("Eliminado con éxito!");
                    startActivity(new Intent(getApplicationContext(), InicioSesionActivity.class));
                } else {

                    print(rsp.get(0).getMensaje());
                }
            }

            @Override
            public void onFailure(Call<List<EliminarPerfilResponse>> call, Throwable t) {
                print("Error: "+t);
            }
        });
    }

    public void print(String msg){
        Toast.makeText(this, msg, Toast.LENGTH_LONG).show();
    }
}