using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour
{
        public ConstructorPlayer[] nuevoPlayer;
    void Awake()
    {
        nuevoPlayer= new ConstructorPlayer[4];

        nuevoPlayer[0]= new ConstructorPlayer(1,"Mario",10,5);
        nuevoPlayer[1]= new ConstructorPlayer(2,"Luigi",5,10);
        nuevoPlayer[2]= new ConstructorPlayer(3,"Toad",5,5);
        nuevoPlayer[3]= new ConstructorPlayer(4,"Peach",10,10);

    }

}
