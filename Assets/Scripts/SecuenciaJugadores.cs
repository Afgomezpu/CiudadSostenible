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

              // NumeroJugadores.PuntajeJugadores[NumeroJugador]=NumeroJugadores.PuntajeJugadores[NumeroJugador];
              print("numero de index " + player.GetComponent<Jugador>().IndexActual);


              // if(player.GetComponent<Jugador>().IndexActual==1 || player.GetComponent<Jugador>().IndexActual==3 || player.GetComponent<Jugador>().IndexActual==22){
              //    NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion1=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion1+puntuacion;
              // }
              // else if(player.GetComponent<Jugador>().IndexActual==2 || player.GetComponent<Jugador>().IndexActual==7 || player.GetComponent<Jugador>().IndexActual==16){

                
              // }
              // else if(player.GetComponent<Jugador>().IndexActual==8){

                
              // }
              // else if(player.GetComponent<Jugador>().IndexActual==4 || player.GetComponent<Jugador>().IndexActual==5){

                
              // }
              // else if(player.GetComponent<Jugador>().IndexActual==6 || player.GetComponent<Jugador>().IndexActual==11){

                
              // }
              // else if(player.GetComponent<Jugador>().IndexActual==9 || player.GetComponent<Jugador>().IndexActual==10 || player.GetComponent<Jugador>().IndexActual==13){

                
              // }
              // else if(player.GetComponent<Jugador>().IndexActual==14 || player.GetComponent<Jugador>().IndexActual==15 || player.GetComponent<Jugador>().IndexActual==17||player.GetComponent<Jugador>().IndexActual==23){

                
              // }
              // else if(player.GetComponent<Jugador>().IndexActual==18){
                
              // }
              // else if(player.GetComponent<Jugador>().IndexActual==12 || player.GetComponent<Jugador>().IndexActual==19 || player.GetComponent<Jugador>().IndexActual==20||player.GetComponent<Jugador>().IndexActual==21){
                
              // }



        
       
     }

     public void puntuacionTotal(int numero){
       print( NumeroJugadores.PuntajeJugadores[numero]);
     }


     public void Puntos(int puntuacion){
     
            //   player = jugadorSeleccionado();
              print("jugador pregunta" +NumeroJugador );
              print("Puntuacion " + player.GetComponent<Jugador>().IndexActual);
              // NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje1=NumeroJugadores.PuntajeJugadores[NumeroJugador]+puntuacion;

                 if(player.GetComponent<Jugador>().IndexActual==1 || player.GetComponent<Jugador>().IndexActual==3 || player.GetComponent<Jugador>().IndexActual==22){
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion1=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion1+puntuacion;
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador1=NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador1+puntuacion;
              }
              else if(player.GetComponent<Jugador>().IndexActual==2 || player.GetComponent<Jugador>().IndexActual==7 || player.GetComponent<Jugador>().IndexActual==16){
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion2=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion2+puntuacion;
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador2=NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador2+puntuacion;
                
              }
              else if(player.GetComponent<Jugador>().IndexActual==8){
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion3=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion3+puntuacion;
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador3=NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador3+puntuacion;
                
              }
              // else if(player.GetComponent<Jugador>().IndexActual==4 || player.GetComponent<Jugador>().IndexActual==5){
              //    NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion1=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion1+puntuacion;
              //    NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador1=NumeroJugadores.PuntajeJugadores[NumeroJugador].contador1+puntuacion;
                
              // }
              // else if(player.GetComponent<Jugador>().IndexActual==6 || player.GetComponent<Jugador>().IndexActual==11){

              // NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion1=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion1+puntuacion;
              //    NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador1=NumeroJugadores.PuntajeJugadores[NumeroJugador].contador1+puntuacion;   
              // }
              // else if(player.GetComponent<Jugador>().IndexActual==9 || player.GetComponent<Jugador>().IndexActual==10 || player.GetComponent<Jugador>().IndexActual==13){
              //    NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion1=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion1+puntuacion;
              //    NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador1=NumeroJugadores.PuntajeJugadores[NumeroJugador].contador1+puntuacion;
                
              // }
              // else if(player.GetComponent<Jugador>().IndexActual==14 || player.GetComponent<Jugador>().IndexActual==15 || player.GetComponent<Jugador>().IndexActual==17||player.GetComponent<Jugador>().IndexActual==23){
              //    NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion1=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion1+puntuacion;
              //    NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador1=NumeroJugadores.PuntajeJugadores[NumeroJugador].contador1+puntuacion;
                
              // }
              // else if(player.GetComponent<Jugador>().IndexActual==18){
              //    NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion1=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion1+puntuacion;
              //    NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador1=NumeroJugadores.PuntajeJugadores[NumeroJugador].contador1+puntuacion;
              // }
              // else if(player.GetComponent<Jugador>().IndexActual==12 || player.GetComponent<Jugador>().IndexActual==19 || player.GetComponent<Jugador>().IndexActual==20||player.GetComponent<Jugador>().IndexActual==21){
              //    NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion1=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuacion1+puntuacion;
              //    NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador1=NumeroJugadores.PuntajeJugadores[NumeroJugador].contador1+puntuacion;
              // }

        
       
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
