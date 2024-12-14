package com.example.frograming.Helpers;

import android.content.Context;
import android.view.View;
import android.widget.LinearLayout;

import com.example.frograming.R;
import com.nex3z.flowlayout.FlowLayout;

import java.util.ArrayList;
import java.util.List;


public class Modo3VistaPersonalizada extends FlowLayout {

    Modo3PalabraPersonalizada palabraPersonalizada;
    private List<View> palabras = new ArrayList<>();

    public Modo3VistaPersonalizada(Context context) {
        super(context);
    }

    //Metodo para agregar la palabra a la Vista.
    public void enviarPalabraVistaPersonalizada(View palabra) {
        palabras.add(palabra);
        addView(palabra);
    }

    //Metodo para remover la palabra de la Vista Personalizada
    public void removerDeLaVista(View view){
        palabraPersonalizada = new Modo3PalabraPersonalizada(getContext(), "");

        palabraPersonalizada.setBackgroundColor(getResources().getColor(R.color.trans));

        LinearLayout.LayoutParams params = new LinearLayout.LayoutParams(view.getWidth(), view.getHeight());
        params.setMargins(15, 5,15, 0);
        palabraPersonalizada.setLayoutParams(params);

        removeView(view);
        addView(palabraPersonalizada, palabras.indexOf(view));
    }

    //Metodo para agregar la palabra a la Vista personalizada
    public void agregarALaVista(View view) {

        if (getChildAt(palabras.indexOf(view)) != null) {
            removeViewAt(palabras.indexOf(view));
            addView(view, palabras.indexOf(view));
        } else {
            addView(view, getChildCount());
        }
    }

    //Verificar que mi Vista Perzonalida este vacía o no
    public boolean empty() {
        return palabras.isEmpty();
    }


}
