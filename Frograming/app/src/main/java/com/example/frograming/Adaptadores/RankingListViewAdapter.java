package com.example.frograming.Adaptadores;

import android.content.Context;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.example.frograming.Helpers.MultimediaConcatURL;
import com.example.frograming.R;
import com.example.frograming.Modelos.RankingResponse;

import java.net.URL;
import java.util.List;

public class RankingListViewAdapter extends ArrayAdapter {

    List<RankingResponse> opciones;

    public RankingListViewAdapter(@NonNull Context context, @NonNull List<RankingResponse> list) {
        super(context, R.layout.listview_jugadores_template, list);
        opciones = list;
    }


    @NonNull
    @Override
    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {
        LayoutInflater layoutInflater = LayoutInflater.from(getContext());

        View item = layoutInflater.inflate(R.layout.listview_jugadores_template, null);

        TextView nombre = (TextView) item.findViewById(R.id.txtNombreUsuario);
        nombre.setText(opciones.get(position).getNombre() + " " + opciones.get(position).getApellido());

        TextView puntos = (TextView) item.findViewById(R.id.txtPuntos);
        puntos.setText(String.valueOf(opciones.get(position).getPuntos()) + " pts");

        TextView posicion = (TextView) item.findViewById(R.id.txtPosicion);
        posicion.setText(String.valueOf(opciones.get(position).getPosicion()));

        ImageView imgMedalla = (ImageView) item.findViewById(R.id.imgMedalla);

        if (String.valueOf(opciones.get(position).getPosicion()).equals("1")){
            imgMedalla.setImageResource(R.drawable.ranking_img_oromedalla);
        }
        if (String.valueOf(opciones.get(position).getPosicion()).equals("2")){
            imgMedalla.setImageResource(R.drawable.ranking_img_platamedalla);
        }
        if (String.valueOf(opciones.get(position).getPosicion()).equals("3")){
            imgMedalla.setImageResource(R.drawable.ranking_img_broncemedalla);
        }

        ImageView img  = (ImageView) item.findViewById(R.id.imgPerfil);
        try{
            URL url = new URL(new MultimediaConcatURL().toCompleteURL(opciones.get(position).getImagen()));
            Bitmap bmp = BitmapFactory.decodeStream(url.openConnection().getInputStream());
            img.setImageBitmap(bmp);
        }catch (Exception e){
            Toast.makeText(getContext(),"Error adapter"+e, Toast.LENGTH_LONG).show();
        }

        return item;
    }
}
