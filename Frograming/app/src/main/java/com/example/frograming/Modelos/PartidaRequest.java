package com.example.frograming.Modelos;

public class PartidaRequest {
    private int usuario_id;
    private int pregunta_id;
    private int puntos_obtenidos;

    public int getUsuario_id() {
        return usuario_id;
    }

    public void setUsuario_id(int usuario_id) {
        this.usuario_id = usuario_id;
    }

    public int getPregunta_id() {
        return pregunta_id;
    }

    public void setPregunta_id(int pregunta_id) {
        this.pregunta_id = pregunta_id;
    }

    public int getPuntos_obtenidos() {
        return puntos_obtenidos;
    }

    public void setPuntos_obtenidos(int puntos_obtenidos) {
        this.puntos_obtenidos = puntos_obtenidos;
    }
}
