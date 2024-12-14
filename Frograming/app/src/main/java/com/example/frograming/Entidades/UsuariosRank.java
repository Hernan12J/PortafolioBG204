package com.example.frograming.Entidades;

public class UsuariosRank {
    String nombreUsuario, grupo;
    int posicion, puntaje, fotoPerfil;

    public UsuariosRank(){
    }

    public UsuariosRank(String nombreUsuario, String grupo, int posicion, int puntaje, int fotoPerfil) {
        this.nombreUsuario = nombreUsuario;
        this.grupo = grupo;
        this.posicion = posicion;
        this.puntaje = puntaje;
        this.fotoPerfil = fotoPerfil;
    }

    public String getNombreUsuario() {
        return nombreUsuario;
    }

    public void setNombreUsuario(String nombreUsuario) {
        this.nombreUsuario = nombreUsuario;
    }

    public String getGrupo() {
        return grupo;
    }

    public void setGrupo(String grupo) {
        this.grupo = grupo;
    }

    public int getPosicion() {
        return posicion;
    }

    public void setPosicion(int posicion) {
        this.posicion = posicion;
    }

    public int getPuntaje() {
        return puntaje;
    }

    public void setPuntaje(int puntaje) {
        this.puntaje = puntaje;
    }

    public int getFotoPerfil() {
        return fotoPerfil;
    }

    public void setFotoPerfil(int fotoPerfil) {
        this.fotoPerfil = fotoPerfil;
    }
}
