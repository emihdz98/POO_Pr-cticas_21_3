using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
   public string nombre;
   public int playerId;
   
   public float vida;
   public float velocidad;

  BasePlayer bPlayer;

private void Start() {
      
      bPlayer=GameObject.FindObjectOfType<BasePlayer>();
    CargarDatos(playerId);
 }

void CargarDatos(int id){
    for (int i = 0; i < bPlayer.nuevoPlayer.Length; i++)
    {
        if (bPlayer.nuevoPlayer[i].playerId==id)
        {
            this.nombre=bPlayer.nuevoPlayer[i].nombre;
            this.vida=bPlayer.nuevoPlayer[i].vida;
            this.velocidad=bPlayer.nuevoPlayer[i].velocidad;
        }
        
        
    }
}
}
