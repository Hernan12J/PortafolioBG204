package com.example.frograming.Adaptadores;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.frograming.Entidades.OpcionesMenuPrincipal;
import com.example.frograming.R;


import java.util.ArrayList;
import java.util.List;

public class OpcionesPrincipalAdapter extends ArrayAdapter {

    private List<OpcionesMenuPrincipal> opcionesMenu = new ArrayList<>();

    public OpcionesPrincipalAdapter(Context context, List<OpcionesMenuPrincipal> datos) {
        super(context, R.layout.activity_card_view, datos);

        this.opcionesMenu = datos;
    }

    public View getView(int position, View v, ViewGroup viewGroup) {

        LayoutInflater inflater = LayoutInflater.from(getContext());
        View item = inflater.inflate(R.layout.activity_card_view, null);

        TextView tematica = (TextView) item.findViewById(R.id.txtTematica);
        tematica.setText(opcionesMenu.get(position).getOpcionNombre());

        ImageView logo = (ImageView) item.findViewById(R.id.img1);
        logo.setImageResource(opcionesMenu.get(position).getOpcionImagen());

        return item;
    }
}
