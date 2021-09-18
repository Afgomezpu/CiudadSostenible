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
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;
    public GameObject Panel5;
    public GameObject Panel6;
    public GameObject Panel7;
    public GameObject Panel8; 
    public GameObject Panel9;
    public GameObject Panel10;
    public GameObject textJugadorPanel;
     
    

    
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

        
       
     }

     public void puntuacionTotal(int numero){
       print( NumeroJugadores.PuntajeJugadores[numero]);
     }


     public void Puntos(int puntuacion){
     
            //   player = jugadorSeleccionado();
              print("jugador pregunta " + NumeroJugador );
              print("Puntuacion " + player.GetComponent<Jugador>().IndexActual);
              // NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuaciones[player.GetComponent<Jugador>().IndexActual]=puntuacion;
              // print(NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuaciones.Length);
              // NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje1=NumeroJugadores.PuntajeJugadores[NumeroJugador]+puntuacion;


              // for(int i=0; i<NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuaciones.Length;i++){
              //     print("la posicion es " +i);
              //     print("El puntahes es" + NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuaciones[i]);
              //     if((NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuaciones[i]>0 && i==7)
              //     ||(NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuaciones[i]>0 && i==7)
              //     ||(NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntuaciones[i]>0 && i==7)){

              //     }
              // }
              if(player.GetComponent<Jugador>().IndexActual==1 || player.GetComponent<Jugador>().IndexActual==3 || player.GetComponent<Jugador>().IndexActual==22){
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje1=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje1+puntuacion;
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador1=NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador1+1;
              }
              else if(player.GetComponent<Jugador>().IndexActual==2 || player.GetComponent<Jugador>().IndexActual==7 || player.GetComponent<Jugador>().IndexActual==16){
                NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje2=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje2+puntuacion;
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador2=NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador2+1;
                
              }
              else if(player.GetComponent<Jugador>().IndexActual==8){
                NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje3=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje3+puntuacion;
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador3=NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador3+1;
                
              }
              else if(player.GetComponent<Jugador>().IndexActual==4 || player.GetComponent<Jugador>().IndexActual==5){
                
                NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje4=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje4+puntuacion;
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador4=NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador4+1;
                
              }
              else if(player.GetComponent<Jugador>().IndexActual==6 || player.GetComponent<Jugador>().IndexActual==11){
                NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje5=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje5+puntuacion;
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador5=NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador5+1;
                
              }
              else if(player.GetComponent<Jugador>().IndexActual==9 || player.GetComponent<Jugador>().IndexActual==10 || player.GetComponent<Jugador>().IndexActual==13){
                NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje6=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje6+puntuacion;
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador6=NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador6+1;
                
              }
              else if(player.GetComponent<Jugador>().IndexActual==14 || player.GetComponent<Jugador>().IndexActual==15 || player.GetComponent<Jugador>().IndexActual==17||player.GetComponent<Jugador>().IndexActual==23){
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje7=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje7+puntuacion;
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador7=NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador7+1;
                
              }
              else if(player.GetComponent<Jugador>().IndexActual==18){
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje8=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje8+puntuacion;
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador8=NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador8+1;
              }
              else if(player.GetComponent<Jugador>().IndexActual==12 || player.GetComponent<Jugador>().IndexActual==19 || player.GetComponent<Jugador>().IndexActual==20||player.GetComponent<Jugador>().IndexActual==21){
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje9=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje9+puntuacion;
                 NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador9=NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador9+1;
              }

        
       
     }

    public void verificar(int NumeroJugador){
      if ((NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador1*7)>=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje1){
        Panel1.SetActive(true);
      }
      else if ((NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador2*5)>=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje2){
       Panel2.SetActive(true);
      }
      else if ((NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador3*5)>=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje3){
      Panel3.SetActive(true);
      }
      else if ((NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador4*8)>=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje4){
      Panel4.SetActive(true);
      }
      else if ((NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador5*8)>=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje5){
      Panel5.SetActive(true);
      }
      else if ((NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador6*5)>=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje6){
      Panel7.SetActive(true);
      }
      else if ((NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador7*4)>=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje7){
      Panel8.SetActive(true);
      }  
      else if ((NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador8*5)>=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje8){
      Panel9.SetActive(true);
      } 
      else if ((NumeroJugadores.PuntajeJugadores[NumeroJugador].Contador9*4)>=NumeroJugadores.PuntajeJugadores[NumeroJugador].Puntaje9){
      Panel10.SetActive(true);
               player = jugadorSeleccionado();
             for(int j=0; j<player.transform.childCount;j++){
                              if(player.transform.GetChild(j).name=="Nuevotexto"){
                                  textJugadorPanel.GetComponent<TextMeshProUGUI>().text= "" + player.transform.GetChild(j).GetComponent<TextMeshPro>().text;
                              }
                      }
      }
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
