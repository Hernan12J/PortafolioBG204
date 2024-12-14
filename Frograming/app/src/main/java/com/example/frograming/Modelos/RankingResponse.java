package com.example.frograming.Modelos;

public class RankingResponse {
    private String nombre;
    private String apellido;
    private int puntos;
    private String nombre_tematica;
    private String imagen;
    private int id;
    private int posicion;

    public RankingResponse(String nombre, String apellido, int puntos, String nombre_tematica, String imagen, int id, int posicion) {
        this.nombre = nombre;
        this.apellido = apellido;
        this.puntos = puntos;
        this.nombre_tematica = nombre_tematica;
        this.imagen = imagen;
        this.id = id;
        this.posicion = posicion;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public int getPuntos() {
        return puntos;
    }

    public void setPuntos(int puntos) {
        this.puntos = puntos;
    }

    public String getNombre_tematica() {
        return nombre_tematica;
    }

    public void setNombre_tematica(String nombre_tematica) {
        this.nombre_tematica = nombre_tematica;
    }

    public String getImagen() {
        return imagen;
    }

    public void setImagen(String imagen) {
        this.imagen = imagen;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getPosicion() {
        return posicion;
    }

    public void setPosicion(int posicion) {
        this.posicion = posicion;
    }
}
