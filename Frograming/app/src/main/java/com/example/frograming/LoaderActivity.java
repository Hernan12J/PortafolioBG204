package com.example.frograming;

import android.os.Bundle;
import android.view.WindowManager;

import androidx.appcompat.app.AppCompatActivity;

import com.example.frograming.Helpers.Jugabilidad;

import java.util.Timer;
import java.util.TimerTask;

public class LoaderActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_loader);
        cambiarPregunta();

        //Hide Status bar.
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);
    }

    private void cambiarPregunta() {
        Jugabilidad jug = new Jugabilidad(getApplicationContext());

        TimerTask timertask = new TimerTask() {
            @Override
            public void run() {
                startActivity(jug.cambiarModo());
                finish();
            }
        };

        Timer time = new Timer();
        time.schedule(timertask, 1000);

    }
}