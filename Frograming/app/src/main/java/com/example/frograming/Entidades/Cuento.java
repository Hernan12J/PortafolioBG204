package com.example.frograming.Entidades;

public class Cuento
{
    private int id;
    private int leccion_id;
    private int orden_id;
    private String texto;
    private String imagen;
    private String audio;

    public Cuento(int id, int leccion_id, int orden_id, String texto, String imagen, String audio)
    {
        this.id = id;
        this.leccion_id = leccion_id;
        this.orden_id = orden_id;
        this.texto = texto;
        this.imagen = imagen;
        this.audio = audio;
    }
    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getLeccion_id() {
        return leccion_id;
    }

    public void setLeccion_id(int leccion_id) {
        this.leccion_id = leccion_id;
    }

    public int getOrden_id() {
        return orden_id;
    }

    public void setOrden_id(int orden_id) {
        this.orden_id = orden_id;
    }

    public String getTexto() {
        return texto;
    }

    public void setTexto(String texto) {
        this.texto = texto;
    }

    public String getImagen() {
        return imagen;
    }

    public void setImagen(String imagen) {
        this.imagen = imagen;
    }

    public String getAudio() {
        return audio;
    }

    public void setAudio(String audio) {
        this.audio = audio;
    }
}
