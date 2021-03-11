using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecuenciaJugadores : MonoBehaviour
{   
    GameObject player ;
    public GameObject jugador1;
    public GameObject Jugador2;
     List<GameObject> jugadores;
    private int numeroJugador;
    AsignarJugadores NumeroJugadores;
    
    void Start()
    {   jugadores=new List<GameObject>(); 
        jugadores.Add(jugador1);
        jugadores.Add(Jugador2);
        NumeroJugadores=FindObjectOfType<AsignarJugadores>();
        NumeroJugador=NumeroJugadores.JugadoresSecuencia.Count-1;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     
      GameObject jugadorSeleccionado(){
        print(NumeroJugador);
         if(NumeroJugador>=NumeroJugadores.JugadoresSecuencia.Count-1){
            NumeroJugador=0;
        }
        else{
            NumeroJugador++;
        }
        return NumeroJugadores.JugadoresSecuencia[NumeroJugador];
       
     }

     public void LlamarJugador(int numero){
     
            //   player = jugadorSeleccionado();
              player.GetComponent<Jugador>().CalcularValores(numero);
        
       
     }

     public void LlamarPregunta(){
         player = jugadorSeleccionado();
         player.GetComponent<Jugador>().pregunta();
     }
     
    // public void Secuencia(){
    //   if(NumeroJugador>jugadores.Count){
    //       NumeroJugador=0;
    //   }
    //   if(NumeroJugador<=jugadores.Count) {
            
    //   }

    // }

             public int  NumeroJugador  // property
  {
    get { return numeroJugador; }
    set { numeroJugador = value; }
  }

}
