using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CambiarJugador : MonoBehaviour
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
    public GameObject pelosMujeresObjeto;
    public GameObject pelosHombresObjeto;
     public GameObject Nombre;
    
    void Start()
    { 
        NumeroJugadores=FindObjectOfType<SeleccionJugadores>();
        print(NumeroJugadores.Jugadores);
        
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
        else if(color.Equals("Barba")){
        Renderer rend= faceJugadores[NumeroJugadores.Contador].GetComponent<Renderer>();
        rend.material=Barba;
        }
    }

    public void CambiarPelo(int numero){
       
       if(numero==0 && NumeroJugadores.Contador<=2){
         recorrerVector1(numero,pelohombre);
         recorrerVector2(peloMujeres);
       }
      else if(numero==1 && NumeroJugadores.Contador<=2){
         recorrerVector1(numero,pelohombre);
         recorrerVector2(peloMujeres);
       }
       else if(numero==2 && NumeroJugadores.Contador<=2){
         recorrerVector1(numero,pelohombre);
         recorrerVector2(peloMujeres);
       }
       else if(numero==0 && NumeroJugadores.Contador>2){
         recorrerVector1(numero,peloMujeres);
         recorrerVector2(pelohombre);
       }
       else if(numero==1 && NumeroJugadores.Contador>2){
           recorrerVector1(numero,peloMujeres);
         recorrerVector2(pelohombre);
       }
       else if(numero==2 && NumeroJugadores.Contador>2){
            recorrerVector1(numero,peloMujeres);
         recorrerVector2(pelohombre);
       }
       else if(numero==3 && NumeroJugadores.Contador>2){
         recorrerVector1(numero,peloMujeres);
         recorrerVector2(pelohombre);
       }
       else if(numero==4 && NumeroJugadores.Contador>2){
         recorrerVector1(numero,peloMujeres);
         recorrerVector2(pelohombre);
       }
    }

    void recorrerVector1(int numero, GameObject[] list){
          for(int i=0;i<list.Length;i++){
             if(numero==i){
             list[i].SetActive(true);
            }
            else{
                list[i].SetActive(false);
                
            }
    }
    }

    
    void recorrerVector2(GameObject[] list){
          for(int i=0;i<list.Length;i++){
                list[i].SetActive(false);  
            }
    }

     
   public void PeloLista(){
          if(NumeroJugadores.Contador>2){
                pelosMujeresObjeto.SetActive(true);
                 pelosHombresObjeto.SetActive(false);
             }
            if(NumeroJugadores.Contador<=2){
                pelosHombresObjeto.SetActive(true);
                pelosMujeresObjeto.SetActive(false);
             }
   }

   public void btSiguiente(){
       recorrerVector2(pelohombre);
       recorrerVector2(peloMujeres);
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
       recorrerVector2(pelohombre);
       recorrerVector2(peloMujeres);
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

       public void ombreJugador(){
        
        NumeroJugadores.NombreJugador=Nombre.GetComponent<TMP_InputField>().text;
        NumeroJugadores.NumeroJugador=NumeroJugadores.Contador;
        print(NumeroJugadores.Contador);
        NumeroJugadores.aceptar.SetActive(true);
        NumeroJugadores.TextAceptar.SetActive(true);
      
    }

    public void seleccionarJugador(){
       if(NumeroJugadores.ListaJugadores.Count<NumeroJugadores.Jugadores){
        Nombre.GetComponent<TMP_InputField>().text="";
       NumeroJugadores.ingresarJugadores(NumeroJugadores.NombreJugador);
       NumeroJugadores.ingresarNumeroJugadores(NumeroJugadores.NumeroJugador);
            if(NumeroJugadores.ListaJugadores.Count<NumeroJugadores.Jugadores){
                NumeroJugadores.textJugador(NumeroJugadores.ListaJugadores.Count+1);
                // textJugadorSiguiente.SetActive(true);
                // GameObject Temp=Instantiate(textJugadorSiguiente);
                // Temp.SetActive(true);
                // Destroy(textJugadorSiguiente,3f);
            }
            if(NumeroJugadores.ListaJugadores.Count==NumeroJugadores.Jugadores){
                NumeroJugadores.aceptar.SetActive(false);
                NumeroJugadores.TextAceptar.SetActive(false);
                Nombre.SetActive(false);
                // btnJugador.SetActive(false);
                NumeroJugadores.siguiente.SetActive(true); 
                NumeroJugadores.TextSiguiente.SetActive(true); 
                    
            }
       }
       else {
           print("ya selecciono los " + NumeroJugadores.Jugadores +" jugadores");
       }

    }


}
