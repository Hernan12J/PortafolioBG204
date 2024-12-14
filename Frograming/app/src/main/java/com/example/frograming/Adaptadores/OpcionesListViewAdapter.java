package com.example.frograming.Adaptadores;


import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.StrictMode;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import com.example.frograming.Entidades.OpcionesMenu;
import com.example.frograming.Helpers.MultimediaConcatURL;
import com.example.frograming.R;


import java.net.URL;
import java.util.List;

public class OpcionesListViewAdapter extends ArrayAdapter {

    private List<OpcionesMenu> opcionesMenu;

    public OpcionesListViewAdapter(Context context, List<OpcionesMenu> datos) {
        super(context, R.layout.activity_card_view, datos);

        this.opcionesMenu = datos;
    }

    public View getView(int position, View v, ViewGroup viewGroup) {
        //Para evitar “android.os.Network On Main Thread Exception error”
        StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
        StrictMode.setThreadPolicy(policy);

        LayoutInflater inflater = LayoutInflater.from(getContext());
        View item = inflater.inflate(R.layout.activity_card_view, null);

        TextView tematica = (TextView) item.findViewById(R.id.txtTematica);
        tematica.setText(opcionesMenu.get(position).getNombre_tematica());

        try{
            URL url = new URL(new MultimediaConcatURL().toCompleteURL(opcionesMenu.get(position).getImagen()));
            Bitmap bmp = BitmapFactory.decodeStream(url.openConnection().getInputStream());

            ImageView logo = (ImageView) item.findViewById(R.id.img1);
            logo.setImageBitmap(bmp);
        }catch (Exception e){
            Toast.makeText(getContext(),"Error"+e, Toast.LENGTH_LONG).show();
        }
        return item;
    }
}
