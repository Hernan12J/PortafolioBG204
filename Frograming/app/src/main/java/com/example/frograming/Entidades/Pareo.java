package com.example.frograming.Entidades;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.widget.Toast;

import com.example.frograming.Helpers.DbHelper;
import com.example.frograming.Modelos.PareoResponse;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Pareo {

    private int pregunta_id;
    private int tematica_id;
    private int orden_pareo;
    private String texto;
    private String audio;

    public Pareo(int pregunta_id, int tematica_id, int orden_pareo, String texto, String audio) {
        this.pregunta_id = pregunta_id;
        this.tematica_id = tematica_id;
        this.orden_pareo = orden_pareo;
        this.texto = texto;
        this.audio = audio;
    }

    public Pareo(String texto, String audio, int orden_pareo) {
        this.texto = texto;
        this.audio = audio;
        this.orden_pareo = orden_pareo;
    }

    public Pareo() {}

    public int getPregunta_id() {return pregunta_id;}

    public void setPregunta_id(int pregunta_id) {
        this.pregunta_id = pregunta_id;
    }

    public int getTematica_id() {
        return tematica_id;
    }

    public void setTematica_id(int tematica_id) {
        this.tematica_id = tematica_id;
    }

    public int getOrden_pareo() {
        return orden_pareo;
    }

    public void setOrden_pareo(int orden_pareo) {
        this.orden_pareo = orden_pareo;
    }

    public String getTexto() {
        return texto;
    }

    public void setTexto(String texto) {
        this.texto = texto;
    }

    public String getAudio() {
        return audio;
    }

    public void setAudio(String audio) {
        this.audio = audio;
    }

    public void pareoInsert(Context context){
        try{
            DbHelper dbHelper = new DbHelper(context,"proyecto_ds6");
            SQLiteDatabase db = dbHelper.getWritableDatabase();
            if(db!= null){
                ContentValues contentValues = new ContentValues();
                contentValues.put("pregunta_id",this.getPregunta_id());
                contentValues.put("tematica_id",this.getTematica_id());
                contentValues.put("orden_pareo",this.getOrden_pareo());
                contentValues.put("texto",this.getTexto());
                contentValues.put("audio",this.getAudio());
                db.insert("pareo",null,contentValues);
            }
            db.close();
        }catch (Exception e){
            Toast.makeText(context,"Error en insercion =>"+e.getMessage(),Toast.LENGTH_LONG).show();
        }
    }
    //#Método encargado de obtener todos las filas del pareo, según el id de pregunta que este asignada al parametro
    public List<Pareo> obtenerPareo(int pregunta, Context context){
        List<Pareo> pareo = new ArrayList<>();
        try{
            DbHelper dbHelper = new DbHelper(context,"proyecto_ds6");
            SQLiteDatabase db = dbHelper.getReadableDatabase();
            if(db!=null){
                //Consulta que obtiene el texto y audio en la tabla pareo, según el id de pregunta del parametro
                String[] campos = new String[]{"texto","audio","orden_pareo"};
                Cursor cursor = db.query("pareo",campos,"pregunta_id= "+pregunta,null,null,null,null,"10");
                if(cursor.moveToFirst()){
                    db.close();
                    do {
                        //#Asignar texto y audio al constructor de la clase Pareo(Entidad)
                        Pareo pareoo = new Pareo(
                                cursor.getString(0),
                                cursor.getString(1),
                                Integer.parseInt(cursor.getString(2))
                        );
                        //#agregar datos cargados en el constructor de Pareo(Entidad) a la lista de tipo pareo
                        pareo.add(pareoo);
                    }while (cursor.moveToNext());
                }
            }
        }catch (Exception e){
            Toast.makeText(context,"Error en obtener datos de pareo =>"+e.getMessage(),Toast.LENGTH_LONG).show();
        }
        //#Retornar lista cargada a la clase PareoActivity
        return pareo;
    }

    public static List<PareoResponse> reordenarPareo(List<PareoResponse> pareo) {
        Collections.shuffle(pareo);
        return pareo;
    }

    public static void actualizarPareo(Context context) {
        DbHelper dbHelper = new DbHelper(context, "proyecto_ds6");
        SQLiteDatabase db = dbHelper.getWritableDatabase();
        String tabla = "pareo";
        try {
            db.delete(tabla, null, null);
            db.close();
        } catch (Exception e) {}
    }

}
