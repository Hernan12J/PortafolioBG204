package com.example.frograming;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.os.StrictMode;
import android.view.View;
import android.view.WindowManager;
import android.widget.EditText;
import android.widget.Toast;

import com.example.frograming.Helpers.Hash;
import com.example.frograming.Helpers.PasswordGenerator;
import com.example.frograming.Modelos.RecuperarRequest;
import com.example.frograming.Modelos.RecuperarResponse;
import com.example.frograming.Service.ApiService;
import com.google.android.material.appbar.MaterialToolbar;

import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

import java.util.Properties;

import javax.mail.Authenticator;
import javax.mail.Message;
import javax.mail.MessagingException;
import javax.mail.PasswordAuthentication;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeMessage;

public class RecuperarContrasenaActivity extends AppCompatActivity {

    EditText txtCorreo;
    private String clave;
    MaterialToolbar toolbar;

    private static Properties props;
    private static Session session;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_recuperar_contrasena);
        InicializarControles();

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);
    }

    private void InicializarControles() {
        txtCorreo = (EditText) findViewById(R.id.txtRecuperarCorreo);
        toolbar = (MaterialToolbar) findViewById(R.id.topAppBar);
        toolbar.setNavigationOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                onBackPressed();
            }
        });
    }


    public void Cancelar(View v){
        startActivity(new Intent(this, InicioSesionActivity.class));
    }

    public void Confirmar(View v){
        if (!txtCorreo.getText().toString().equals("")){
            clave = new PasswordGenerator().generatePass();
            RecuperarRequest request = new RecuperarRequest();
            request.setCorreo(txtCorreo.getText().toString());
            request.setContrasena(new Hash(clave).tomd5());

            Call<List<RecuperarResponse>> callRecuperar = ApiService.getApiService().ActualizarContrasena(request);

            callRecuperar.enqueue(new Callback<List<RecuperarResponse>>() {
                @Override
                public void onResponse(Call<List<RecuperarResponse>> call, Response<List<RecuperarResponse>> response) {
                    List<RecuperarResponse> rsp = response.body();
                    if (response.isSuccessful()){
                        enviarCorreo(clave, request.getCorreo());

                        print("Ingrese con el código que enviamos a su correo! Recuerde cambiar la contraseña una ves ingrese a la plataforma!");


                        startActivity(new Intent(getApplicationContext(), InicioSesionActivity.class));
                    } else {
                        print("Error al cambiar la contraseña temporal");
                    }
                }

                @Override
                public void onFailure(Call<List<RecuperarResponse>> call, Throwable t) {
                    print("Error: "+t);
                }
            });
        }else{
            print("Debe llenar el campo 'correo'!");
        }
    }

    private void enviarCorreo(String password, String email) {
        //Network on Main thread Exception
        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();

        StrictMode.setThreadPolicy(policy);

        props = new Properties();
        props.put("mail.smtp.starttls.enable", "true");
        props.put("mail.smtp.port", "587");
        props.put("mail.smtp.host", "m.outlook.com");
        props.put("mail.smtp.auth", "true");
        session = Session.getInstance(props, new Authenticator() {
            @Override
            protected PasswordAuthentication getPasswordAuthentication() {
                return new PasswordAuthentication("proyectods61ls131@outlook.com",
                        "Adm12345");
            }
        });

        try {
            // Create a default MimeMessage object.
            MimeMessage message = new MimeMessage(session);

            // Set From: header field of the header.
            message.setFrom(new InternetAddress("proyectods61ls131@outlook.com"));

            // Set To: header field of the header.
            message.addRecipient(Message.RecipientType.TO, new InternetAddress(email));

            // Set Subject: header field
            message.setSubject("Recuperación de contraseña! Frograming");

            // Now set the actual message
            message.setText("Su contraseña temporal es: "+password+"\nRecomendamos cambiar esta contraseña una ves pueda loguearse!");

            System.out.println("sending...");
            // Send message
            Transport.send(message);
            System.out.println("Sent message successfully....");
        } catch (MessagingException mex) {
            mex.printStackTrace();
        }
    }

    private void print(String msg) {
        Toast.makeText(this, msg, Toast.LENGTH_LONG).show();
    }
}