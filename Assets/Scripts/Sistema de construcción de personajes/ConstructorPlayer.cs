﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ConstructorPlayer
{
   //Atributos o propiedades
   public int playerId;
   public string nombre;
   
   public float vida;
   public float velocidad;

   private Transform posicionActual;
   private int daño;

   //Método constructor
   public ConstructorPlayer(int id, string n, float vida, float vel){
      
      this.playerId=id;
      this.nombre=n;
      this.vida=vida;
      this.velocidad=vel;
   }
}
