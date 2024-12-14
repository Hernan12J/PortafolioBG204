package com.example.frograming.Entidades;

public class Leccion
{
    private int id;
    private int tematica_id;
    private String titulo;
    private String contenido;
    private String video;

    public Leccion(int id, int tematica_id, String titulo, String contenido, String video)
    {
        this.id = id;
        this.tematica_id = tematica_id;
        this.titulo = titulo;
        this.contenido = contenido;
        this.video = video;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getTematica_id() {
        return tematica_id;
    }

    public void setTematica_id(int tematica_id) {
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
