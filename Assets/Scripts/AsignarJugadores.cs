using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsignarJugadores : MonoBehaviour
{
    SeleccionJugadores NumeroJugadores;
    public Material Oscuro;
    public Material Medio;
    public Material Blanca;
    public Material Barba;
    public GameObject[] faceJugadores;
    public GameObject[] jugadores;
    public GameObject[] peloMujeres;
    public  GameObject[] pelohombre;

    void Start()
    

    
         NumeroJugadores=FindObjectOfType<SeleccionJugadores>();
    }


    void Update()
    {
        
    }

     void asignarJugadores(){
                for(int j=0; j<jugadores.Length;j++){
                    if(NumeroJugadores.listaNumeroJugadores==)
                
              }

     }
}
