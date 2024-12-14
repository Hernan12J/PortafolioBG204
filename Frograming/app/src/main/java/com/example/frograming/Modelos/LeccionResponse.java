package com.example.frograming.Modelos;

public class LeccionResponse
{
    private String id;
    private String tematica_id;
    private String titulo;
    private String contenido;
    private String video;

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getTematica_id() {
        return tematica_id;
    }

    public void setTematica_id(String tematica_id) {
        this.tematica_id = tematica_id;
    }

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public String getContenido() {
        return contenido;
    }

    public void setContenido(String contenido) {
        this.contenido = contenido;
    }

    public String getVideo() {
        return video;
    }

    public void setVideo(String video) {
        this.video = video;
    }
}
