package com.example.frograming.Entidades;

public class OpcionesMenuPrincipal {
    private String opcionNombre;
    private Integer opcionImagen;

    public OpcionesMenuPrincipal(String opcionNombre, Integer opcionImagen) {
        this.opcionNombre = opcionNombre;
        this.opcionImagen = opcionImagen;
    }

    public String getOpcionNombre() {
        return opcionNombre;
    }

    public void setOpcionNombre(String opcionNombre) {
        this.opcionNombre = opcionNombre;
    }

    public Integer getOpcionImagen() {
        return opcionImagen;
    }

    public void setOpcionImagen(Integer opcionImagen) {
        this.opcionImagen = opcionImagen;
    }
}