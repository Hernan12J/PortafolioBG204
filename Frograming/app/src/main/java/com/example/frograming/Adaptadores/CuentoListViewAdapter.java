package com.example.frograming.Adaptadores;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import com.example.frograming.Modelos.CuentoResponse;
import com.example.frograming.R;

import java.util.ArrayList;
import java.util.List;

public class CuentoListViewAdapter extends ArrayAdapter<CuentoResponse> {
    private List<CuentoResponse> cuentosbubbles = new ArrayList<>();

    public CuentoListViewAdapter(Context context, List<CuentoResponse> data)
    {
        super(context, R.layout.cuentoderlistview_template, data);
        cuentosbubbles = data;
    }

    public View getView(int position, View convertView, ViewGroup parent)
    {
        LayoutInflater inflater = LayoutInflater.from(getContext());
        View item = inflater.inflate(R.layout.cuentoderlistview_template, null);

        if (position%2 != 1)
        {
            item = inflater.inflate(R.layout.cuentoizqlistview_template, null);
        }

        TextView lblTexto = (TextView) item.findViewById(R.id.lblTexto);
        lblTexto.setText(cuentosbubbles.get(position).getTexto());

        return(item);
    }
}
