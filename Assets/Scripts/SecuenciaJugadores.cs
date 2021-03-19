using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SecuenciaJugadores : MonoBehaviour
{   
    GameObject player ;
  
     List<GameObject> jugadores;
    private int numeroJugador;
    AsignarJugadores NumeroJugadores;
    public GameObject textJugador;
    

    
    void Start()
    {  
        NumeroJugadores=FindObjectOfType<AsignarJugadores>();
        NumeroJugador=NumeroJugadores.JugadoresSecuencia.Count-1;
        
    }


public void Jugar(){
  GameObject jugadorPrimero=new GameObject();
  if(NumeroJugador>=NumeroJugadores.JugadoresSecuencia.Count-1){
     jugadorPrimero=NumeroJugadores.JugadoresSecuencia[0];
  }
  else{
      jugadorPrimero=NumeroJugadores.JugadoresSecuencia[NumeroJugador+1];
  }
  
    for(int j=0; j<jugadorPrimero.transform.childCount;j++){
                              if(jugadorPrimero.transform.GetChild(j).name=="Nuevotexto"){
                                print("Nuevo jugador " +  jugadorPrimero.transform.GetChild(j).GetComponent<TextMeshPro>().text );
                                  textJugador.GetComponent<TextMeshProUGUI>().text= "Jugador: " + jugadorPrimero.transform.GetChild(j).GetComponent<TextMeshPro>().text;
                              }
                      }
  
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
              print("jugador pregunta" +NumeroJugador );
              NumeroJugadores.PuntajeJugadores[NumeroJugador]=NumeroJugadores.PuntajeJugadores[NumeroJugador];

        
       
     }

     public void puntuacionTotal(int numero){
       print( NumeroJugadores.PuntajeJugadores[numero]);
     }


     public void Puntos(int puntuacion){
     
            //   player = jugadorSeleccionado();
              print("jugador pregunta" +NumeroJugador );
              NumeroJugadores.PuntajeJugadores[NumeroJugador]=NumeroJugadores.PuntajeJugadores[NumeroJugador]+puntuacion;

        
       
     }

     public void LlamarPregunta(){
         player = jugadorSeleccionado();
             for(int j=0; j<player.transform.childCount;j++){
                              if(player.transform.GetChild(j).name=="Nuevotexto"){
                                  textJugador.GetComponent<TextMeshProUGUI>().text= "Jugador: " + player.transform.GetChild(j).GetComponent<TextMeshPro>().text;
                              }
                      }
         player.GetComponent<Jugador>().pregunta();
     }
     


             public int  NumeroJugador  // property
  {
    get { return numeroJugador; }
    set { numeroJugador = value; }
  }

}
