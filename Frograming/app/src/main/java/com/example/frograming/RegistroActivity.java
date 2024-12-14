package com.example.frograming;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.WindowManager;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.Toast;

import com.example.frograming.Entidades.Usuarios;
import com.example.frograming.Helpers.Hash;
import com.example.frograming.Modelos.LoginRequest;
import com.example.frograming.Modelos.LoginResponse;
import com.example.frograming.Modelos.RegistroRequest;
import com.example.frograming.Service.ApiService;
import com.google.android.material.appbar.MaterialToolbar;

import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class RegistroActivity extends AppCompatActivity {

    private EditText nombre, apellido, cedula, correo, contrasena1, contrasena2;
    private Spinner facultad, carrera, grupo;
    private boolean validacion, visible;
    private String contrasena;
    MaterialToolbar toolbar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_registro);

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

        InicializarControles();
        AttachEvents();
    }

    private void InicializarControles() {
        nombre = (EditText)findViewById(R.id.txtNombre);
        apellido = (EditText)findViewById(R.id.txtApellido);
        cedula = (EditText)findViewById(R.id.txtCedula);
        correo = (EditText)findViewById(R.id.txtCorreo);
        contrasena1 = (EditText)findViewById(R.id.txtContrasena); //decifrar contrasena y comparar
        contrasena2 = (EditText)findViewById(R.id.txtConfirmar);
        facultad = (Spinner) findViewById(R.id.spnFacultad);
        carrera = (Spinner) findViewById(R.id.spnCarrera);
        grupo = (Spinner) findViewById(R.id.spnGrupo);
        carrera.setEnabled(false);
        grupo.setEnabled(false);
        toolbar = (MaterialToolbar) findViewById(R.id.topAppBar);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                onBackPressed();
            }
        });
    }

    private void AttachEvents() {
        facultad.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
                //obtener valor de spinner
                String facu = facultad.getItemAtPosition(position).toString();

                if (facu.equals("Facultad de Ciencias y Tecnología")) {
                    ArrayAdapter adapterCarrera = ArrayAdapter
                            .createFromResource(RegistroActivity.this,R.array.FCyT, androidx.appcompat.R.layout.support_simple_spinner_dropdown_item);
                    ArrayAdapter adapterGrupo = ArrayAdapter
                            .createFromResource(RegistroActivity.this,R.array.Grupo1, androidx.appcompat.R.layout.support_simple_spinner_dropdown_item);
                    carrera.setAdapter(adapterCarrera);
                    grupo.setAdapter(adapterGrupo);
                    carrera.setEnabled(true);
                    grupo.setEnabled(true);
                } else if (facu.equals("Facultad de Ingeniería Civil")) {
                    ArrayAdapter adapterCarrera = ArrayAdapter
                            .createFromResource(RegistroActivity.this, R.array.FIC, androidx.appcompat.R.layout.support_simple_spinner_dropdown_item);
                    ArrayAdapter adapterGrupo = ArrayAdapter
                            .createFromResource(RegistroActivity.this,R.array.Grupo2, androidx.appcompat.R.layout.support_simple_spinner_dropdown_item);
                    carrera.setAdapter(adapterCarrera);
                    grupo.setAdapter(adapterGrupo);
                    carrera.setEnabled(true);
                    grupo.setEnabled(true);
                } else if (facu.equals("Facultad de Ingeniería Eléctrica")) {
                    ArrayAdapter adapterCarrera = ArrayAdapter
                            .createFromResource(RegistroActivity.this, R.array.FIE, androidx.appcompat.R.layout.support_simple_spinner_dropdown_item);
                    ArrayAdapter adapterGrupo = ArrayAdapter
                            .createFromResource(RegistroActivity.this,R.array.Grupo3, androidx.appcompat.R.layout.support_simple_spinner_dropdown_item);
                    carrera.setAdapter(adapterCarrera);
                    grupo.setAdapter(adapterGrupo);
                    carrera.setEnabled(true);
                    grupo.setEnabled(true);
                } else if (facu.equals("Facultad de Ingeniería Industrial")) {
                    ArrayAdapter adapterCarrera = ArrayAdapter
                            .createFromResource(RegistroActivity.this, R.array.FII, androidx.appcompat.R.layout.support_simple_spinner_dropdown_item);
                    ArrayAdapter adapterGrupo = ArrayAdapter
                            .createFromResource(RegistroActivity.this,R.array.Grupo4, androidx.appcompat.R.layout.support_simple_spinner_dropdown_item);
                    carrera.setAdapter(adapterCarrera);
                    grupo.setAdapter(adapterGrupo);                    carrera.setEnabled(true);
                    grupo.setEnabled(true);
                } else if (facu.equals("Facultad de Ingeniería Mecánica")) {
                    ArrayAdapter adapterCarrera = ArrayAdapter
                            .createFromResource(RegistroActivity.this, R.array.FIM, androidx.appcompat.R.layout.support_simple_spinner_dropdown_item);
                    ArrayAdapter adapterGrupo = ArrayAdapter
                            .createFromResource(RegistroActivity.this,R.array.Grupo5, androidx.appcompat.R.layout.support_simple_spinner_dropdown_item);
                    carrera.setAdapter(adapterCarrera);
                    grupo.setAdapter(adapterGrupo);
                    carrera.setEnabled(true);
                    grupo.setEnabled(true);
                } else if (facu.equals("Facultad de Ingeniería de Sistemas Computacionales")) {
                    ArrayAdapter adapterCarrera = ArrayAdapter
                            .createFromResource(RegistroActivity.this, R.array.FISC, androidx.appcompat.R.layout.support_simple_spinner_dropdown_item);
                    ArrayAdapter adapterGrupo = ArrayAdapter
                            .createFromResource(RegistroActivity.this,R.array.Grupo6, androidx.appcompat.R.layout.support_simple_spinner_dropdown_item);
                    carrera.setAdapter(adapterCarrera);
                    grupo.setAdapter(adapterGrupo);
                    carrera.setEnabled(true);
                    grupo.setEnabled(true);
                } else{
                    carrera.setEnabled(false);
                    grupo.setEnabled(false);
                }
            }
            @Override
            public void onNothingSelected(AdapterView<?> parent) {

            }
        });
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

    public String md5(String s) {
        try {
            // Create MD5 Hash
            MessageDigest digest = java.security.MessageDigest.getInstance("MD5");
            digest.update(s.getBytes());
            byte messageDigest[] = digest.digest();

            // Create Hex String
            StringBuffer hexString = new StringBuffer();
            for (int i=0; i<messageDigest.length; i++)
                hexString.append(Integer.toHexString(0xFF & messageDigest[i]));

            return hexString.toString();
        }catch (NoSuchAlgorithmException e) {
            e.printStackTrace();
        }
        return "";
    }

    public void ver(View v){

        try {
            validacion=validarContrasena(contrasena1.getText().toString(), contrasena2.getText().toString());
            String contra;
            contra=new Hash(contrasena1.getText().toString()).tomd5();
            if (validacion == true) {
                RegistroRequest request = new RegistroRequest();
                request.setNombre(nombre.getText().toString());
                request.setApellido(apellido.getText().toString());
                request.setCorreo(correo.getText().toString());
                request.setContrasena(contra);
                request.setGrupo(grupo.getSelectedItem().toString());
                request.setCedula(cedula.getText().toString());
                String numero = String.valueOf((int)(Math.random()*2+1));
                request.setFoto("generales/imagenes/usuario_IMG_00"+numero+".png");
                request.setCarrera(carrera.getSelectedItem().toString());
                request.setFacultad(facultad.getSelectedItem().toString());

                Call<List<Usuarios>> callRegistro = ApiService.getApiService().Registrar(request);

                callRegistro.enqueue(new Callback<List<Usuarios>>() {

                    @Override
                    public void onResponse(Call<List<Usuarios>> call, Response<List<Usuarios>> response) {
                        if(response.body().isEmpty()){
                            print("Usuario registrado exitosamente");
                            startActivity(new Intent(getApplicationContext(),InicioSesionActivity.class));
                        }else {
                            print("Error al insertar usuario");
                        }

                    }

                    @Override
                    public void onFailure(Call<List<Usuarios>> call, Throwable t) {
                        print("Error al registrar usuario");
                    }
                });
            }
            else
                Toast.makeText(this, "Error, su cuenta no ha podido ser registrada", Toast.LENGTH_LONG).show();


        }catch(Exception e){
            Toast.makeText(this, "Error :" + e.getMessage(), Toast.LENGTH_LONG).show();
        }
    }

    public void conCuenta(View v){
        startActivity(new Intent(this, InicioSesionActivity.class));
    }

    public void print (String msg){
        Toast.makeText(this, msg, Toast.LENGTH_LONG).show();
    }
}