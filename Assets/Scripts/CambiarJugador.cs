using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarJugador : MonoBehaviour
{

    SeleccionJugadores NumeroJugadores;
    public Material Oscuro;
    public Material Medio;
    public Material Blanca;
    public GameObject[] faceJugadores;
    public GameObject[] jugadores;
    
    void Start()
    { 
        NumeroJugadores=FindObjectOfType<SeleccionJugadores>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambiarcolorPiel(string color){
       
       if(color.Equals("Oscuro")){
        Renderer rend= faceJugadores[NumeroJugadores.Contador].GetComponent<Renderer>();
        rend.material=Oscuro;
        }
        else if(color.Equals("Medio")){
        Renderer rend= faceJugadores[NumeroJugadores.Contador].GetComponent<Renderer>();
        rend.material=Medio;
        }
        else if(color.Equals("Blanca")){
        Renderer rend= faceJugadores[NumeroJugadores.Contador].GetComponent<Renderer>();
        rend.material=Blanca;
        }
    }

   public void btSiguiente(){
        NumeroJugadores.Contador=NumeroJugadores.Contador+1;
          if(NumeroJugadores.Contador<jugadores.Length){
            for(int i=0;i<jugadores.Length;i++){
             if(i==NumeroJugadores.Contador){
             jugadores[i].SetActive(true);
            //  perfil.GetComponent<TextMeshProUGUI>().text = Listperfil[i];
            }
            else{
                jugadores[i].SetActive(false);
                
            }
          }
    
    }
    else if(NumeroJugadores.Contador==jugadores.Length){
        NumeroJugadores.Contador=0;
        jugadores[jugadores.Length-1].SetActive(false);
        jugadores[NumeroJugadores.Contador].SetActive(true);
        // perfil.GetComponent<TextMeshProUGUI>().text = Listperfil[NumeroJugadores.Contador];
    }
    print(NumeroJugadores.Contador);
    }

    public void btAtras(){
        print(jugadores.Length);
        print(NumeroJugadores.Contador);
        NumeroJugadores.Contador=NumeroJugadores.Contador-1;
          if(NumeroJugadores.Contador<jugadores.Length && NumeroJugadores.Contador>=0){
            for(int i=0;i<jugadores.Length;i++){
             if(i==NumeroJugadores.Contador){
             jugadores[i].SetActive(true);
            //  perfil.GetComponent<TextMeshProUGUI>().text = Listperfil[i];
            }
            else{
                jugadores[i].SetActive(false);
            }
          }
    
    }
    else if(NumeroJugadores.Contador<0){
        print("entro a el contrador");
        NumeroJugadores.Contador=jugadores.Length-1;
        jugadores[0].SetActive(false);
        jugadores[NumeroJugadores.Contador].SetActive(true);
        // perfil.GetComponent<TextMeshProUGUI>().text = Listperfil[NumeroJugadores.Contador];
    }

    }


}
