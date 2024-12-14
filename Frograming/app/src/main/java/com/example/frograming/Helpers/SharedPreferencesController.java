package com.example.frograming.Helpers;

import static android.content.Context.MODE_PRIVATE;

import android.content.Context;
import android.content.SharedPreferences;

public class SharedPreferencesController {

    public static final String globalVariable = "data.preguntas.respondidas";

    public void guardar(Context context, String token, String id){
        SharedPreferences.Editor editor = context.getSharedPreferences(globalVariable,MODE_PRIVATE).edit();
        editor.putString(token,id);
        editor.commit();
    }

    public String leer(Context context, String token){
        SharedPreferences sharedPref = context.getSharedPreferences(globalVariable, Context.MODE_PRIVATE);
        String dato = sharedPref.getString(token,"");
        return dato;
    }

    public void BarraProgreso(SharedPreferences progresoSh, int progreso){

        SharedPreferences.Editor elemento=progresoSh.edit();
        elemento.putInt("progreso", progreso+10);
        elemento.commit();
    }

    public void ValidarPregunta(SharedPreferences puntos, int correcto, int id, Context context){
        SharedPreferences.Editor elemento=puntos.edit();
        if(puntos==null){
            elemento.putInt("puntos_total", 0);
        }else{

            if(correcto==1){
                PartidaController.agregar(context, Integer.toString(id), "5");
                elemento.putInt("puntos_total", puntos.getInt("puntos_total", 0)+5);

            }else{
                PartidaController.agregar(context, Integer.toString(id), "0");
                elemento.putInt("puntos_total", puntos.getInt("puntos_total", 0)+0);
            }
        }
        elemento.commit();
    }



}
