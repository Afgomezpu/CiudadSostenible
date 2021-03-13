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
    public GameObject[] jugadores;
    public GameObject[] peloMujeres;
    public  GameObject[] pelohombre;
    List<GameObject> listJugadores;
    int aux;
    int Jugador;
    public GameObject jugador1;
    public GameObject Jugador2;
    private int numeroJugadorsecuencia;
    List<GameObject> jugadoresSecuencia=new List<GameObject>();
     
    void Start(){    

         NumeroJugadores=FindObjectOfType<SeleccionJugadores>();
         asignarJugadores();
         listJugadores=new List<GameObject>();
         numeroJugadorsecuencia=0;
          //  JugadoresSecuencia=new List<GameObject>();
         
     //     JugadoresPrueba=new List<GameObject>();
       
     //     JugadoresPrueba.Add(jugador1);
     //     JugadoresPrueba.Add(Jugador2);
    }


    void Update()
    {
        
    }

     void asignarJugadores(){
               //  foreach(int NumeroPlayer in NumeroJugadores.ListaNumeroJugadores){
               for(int i=0; i<NumeroJugadores.ListaNumeroJugadores.Count; i++){ 
                    //   GameObject personaje=Instantiate(jugadores[NumeroPlayer]);
                      GameObject personaje=Instantiate(jugadores[NumeroJugadores.ListaNumeroJugadores[i]]);
                      personaje.transform.position=new Vector3(203.9f,82f,24.5f);
                      print(personaje);
                      JugadoresSecuencia.Add(personaje);
                      if(NumeroJugadores.ListaColor[i]!="Normal"){
                           for(int j=0; j<personaje.transform.childCount;j++){
                              if(personaje.transform.GetChild(j).name=="Body"){
                                   Renderer rend=personaje.transform.GetChild(j).GetComponent<Renderer>();
                                   rend.material=CambiarcolorPiel(NumeroJugadores.ListaColor[i]);
                              }
                      }
                  }
                    if(NumeroJugadores.ListaPelo[i]!=5 && NumeroJugadores.ListaNumeroJugadores[i]<=2){
                                GameObject personaje2=Instantiate(pelohombre[NumeroJugadores.ListaPelo[i]]);
                                personaje2.transform.parent=personaje.transform;
                                personaje2.transform.position=new Vector3(187.3f,-9.5f,22.4f);
     
                    }
                     if(NumeroJugadores.ListaPelo[i]!=5 && NumeroJugadores.ListaNumeroJugadores[i]>2){
                                if(NumeroJugadores.ListaPelo[i]==4){
                                   GameObject personaje2=Instantiate(peloMujeres[NumeroJugadores.ListaPelo[i]]);
                                personaje2.transform.parent=personaje.transform;
                                personaje2.transform.position=new Vector3(187.3f,-9f,22.4f);
                                }
                                else{
                                      GameObject personaje2=Instantiate(peloMujeres[NumeroJugadores.ListaPelo[i]]);
                                personaje2.transform.parent=personaje.transform;
                                personaje2.transform.position=new Vector3(187.3f,-13f,22.4f);
                                }

     
                    }
                    
     }

     print(JugadoresSecuencia.Count);
     }

     public void asignarSoloJugador(){

                    //   GameObject personaje=Instantiate(jugadores[NumeroPlayer]);
                      GameObject personaje=Instantiate(jugadores[NumeroJugadores.ListaNumeroJugadores[NumeroJugadores.ListaNumeroJugadores.Count-1]]);
                      personaje.transform.position=new Vector3(203.9f,82f,24.5f);
                      print(personaje);
                      JugadoresSecuencia.Add(personaje);
                      if(NumeroJugadores.ListaColor[NumeroJugadores.ListaNumeroJugadores.Count-1]!="Normal"){
                           for(int j=0; j<personaje.transform.childCount;j++){
                              if(personaje.transform.GetChild(j).name=="Body"){
                                   Renderer rend=personaje.transform.GetChild(j).GetComponent<Renderer>();
                                   rend.material=CambiarcolorPiel(NumeroJugadores.ListaColor[NumeroJugadores.ListaNumeroJugadores.Count-1]);
                              }
                      }
                  }
                    if(NumeroJugadores.ListaPelo[NumeroJugadores.ListaNumeroJugadores.Count-1]!=5 && NumeroJugadores.ListaNumeroJugadores[NumeroJugadores.ListaNumeroJugadores.Count-1]<=2){
                                GameObject personaje2=Instantiate(pelohombre[NumeroJugadores.ListaPelo[NumeroJugadores.ListaNumeroJugadores.Count-1]]);
                                personaje2.transform.parent=personaje.transform;
                                personaje2.transform.position=new Vector3(202.3537f,24.15f,24.59483f);
     
                    }
                     if(NumeroJugadores.ListaPelo[NumeroJugadores.ListaNumeroJugadores.Count-1]!=5 && NumeroJugadores.ListaNumeroJugadores[NumeroJugadores.ListaNumeroJugadores.Count-1]>2){
                                if(NumeroJugadores.ListaPelo[NumeroJugadores.ListaNumeroJugadores.Count-1]==4){
                                   GameObject personaje2=Instantiate(peloMujeres[NumeroJugadores.ListaPelo[NumeroJugadores.ListaNumeroJugadores.Count-1]]);
                                personaje2.transform.parent=personaje.transform;
                                personaje2.transform.position=new Vector3(202.3537f,24f,24.59483f);
                                }
                                else{
                                      GameObject personaje2=Instantiate(peloMujeres[NumeroJugadores.ListaPelo[NumeroJugadores.ListaNumeroJugadores.Count-1]]);
                                personaje2.transform.parent=personaje.transform;
                                personaje2.transform.position=new Vector3(202.3537f,20f,24.59483f);
                                }

     
                    }
                    print(NumeroJugadores.ListaNumeroJugadores.Count);
                    
     

     }
       
       
     Material CambiarcolorPiel(string color){
       
       if(color.Equals("Oscuro")){
        return Oscuro;
        }
        else if(color.Equals("Medio")){
        
         return Medio;
        }
        
        else if(color.Equals("Blanca")){
     
         return Blanca;
        }
        else if(color.Equals("Barba")){
     
         return Barba;
        }
        else{
             return null;
        }
    }


    public void secuenciaprueba(){
     //    for(int i=0;i<)

    }

           public int  NumeroJugadorsecuencia  // property
  {
    get { return numeroJugadorsecuencia; }
    set { numeroJugadorsecuencia = value; }
  }
  
           public List<GameObject>  JugadoresSecuencia  // property
  {
    get { return jugadoresSecuencia; }
    set { jugadoresSecuencia = value; }
  }

    
}
