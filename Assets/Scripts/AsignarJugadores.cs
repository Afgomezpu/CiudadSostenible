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

    void Start(){    
         NumeroJugadores=FindObjectOfType<SeleccionJugadores>();
         asignarJugadores();
    }


    void Update()
    {
        
    }

     void asignarJugadores(){
               //  foreach(int NumeroPlayer in NumeroJugadores.ListaNumeroJugadores){
               for(int i=0; i<NumeroJugadores.ListaNumeroJugadores.Count; i++){ 
                    //   GameObject personaje=Instantiate(jugadores[NumeroPlayer]);
                      GameObject personaje=Instantiate(jugadores[NumeroJugadores.ListaNumeroJugadores[i]]);
                      personaje.transform.position=new Vector3(187.3f,50f,22.4f);
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
}
