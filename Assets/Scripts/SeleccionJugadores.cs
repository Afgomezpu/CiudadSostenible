using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeleccionJugadores : MonoBehaviour
{
    private int contador;
    private int jugadores;
    
    
    
    void Awake(){
        DontDestroyOnLoad(gameObject);
    }


    void Start()
    {

    }
    void Update()
    { 
        
    }
        public int Contador  // property
     {
    get { return contador; }
    set { contador = value; }
    }

           public int  Jugadores  // property
  {
    get { return jugadores; }
    set { jugadores = value; }
  }
}
