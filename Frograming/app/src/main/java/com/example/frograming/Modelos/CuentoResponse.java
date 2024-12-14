package com.example.frograming.Modelos;

public class CuentoResponse
{
    private String id;
    private String lecion_id;
    private String orden_id;
    private String texto;
    private String imagen;
    private String audio;

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getLeecion_id() {
        return lecion_id;
    }

    public void setLeecion_id(String leecion_id) {
        this.lecion_id = leecion_id;
    }

    public String getOrden_id() {
        return orden_id;
    }

    public void setOrden_id(String orden_id) {
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
