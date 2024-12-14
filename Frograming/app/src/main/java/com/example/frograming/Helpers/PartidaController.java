package com.example.frograming.Helpers;

import android.content.Context;
import android.content.SharedPreferences;

import java.util.HashMap;
import java.util.Map;

public class PartidaController {

    public static HashMap<String, String> leer(Context context) {
        SharedPreferences partida = context.getSharedPreferences("partida", Context.MODE_PRIVATE);
        String partidaStr = partida.getString("partida", "");
        if (partidaStr.equals("")) {
            return new HashMap<String, String>();
        } else {
            HashMap<String, String> partidasMap = stringToHash(partidaStr);
            return partidasMap;
        }
    }

    public static void agregar(Context context, String key, String value) {
        HashMap<String,String> partidasMap = PartidaController.leer(context);
        SharedPreferences.Editor editor = context.getSharedPreferences("partida", Context.MODE_PRIVATE).edit();

        partidasMap.put(key, value);

        editor.putString("partida", hashToString(partidasMap));
        editor.commit();
    }

    public static void comenzarPartida(Context context) {
        SharedPreferences.Editor editor = context.getSharedPreferences("partida", Context.MODE_PRIVATE).edit();
        editor.putString("partida", "");
        editor.commit();
    }

    public static void borrarHistorial(Context context) {
        SharedPreferences.Editor puntos = context.getSharedPreferences("puntos_total", Context.MODE_PRIVATE).edit();
        SharedPreferences.Editor progreso = context.getSharedPreferences("progreso", Context.MODE_PRIVATE).edit();
        puntos.putInt("puntos_total", 0);
        progreso.putInt("progreso", 0);
        puntos.commit();
        progreso.commit();
    }

    public static HashMap<String, String> stringToHash(String str) {
        HashMap<String, String> hm = new HashMap<>();
        for (String kvStr : str.split(",")) {
            String[] kv = kvStr.split(":");
            hm.put(kv[0], kv[1]);
        }
        return hm;
    }

    public static String hashToString(HashMap<String, String> hm) {
        String res = "";
        for (Map.Entry<String, String> entry : hm.entrySet()) {
            String k = entry.getKey();
            String v = entry.getValue();
            res += k + ":" + v + ",";
        }
        return res.replaceAll(".$", "");
    }


}
