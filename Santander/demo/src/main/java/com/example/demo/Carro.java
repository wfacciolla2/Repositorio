package com.example.demo;

public class Carro {

    public Carro(String marca, String modelo, Integer ano, String variante){
        this.marca = marca;
        this.modelo = modelo;
        this.ano = ano;
        this.variante = variante;
    }

    public String marca;
    public String modelo;
    public Integer ano;
    public String variante;

    public String getMarca(){return marca;}
    public void setMarca(String marca){this.marca = marca;}

    public String getModelo(){return modelo;}
    public void setModelo(String modelo){this.modelo = modelo;}

    public Integer getAno(){return ano;}
    public void setAno(Integer ano){this.ano = ano;}

    public String getVariante(){return variante;}
    public void setVariante(String variante){this.variante = variante;}
}
