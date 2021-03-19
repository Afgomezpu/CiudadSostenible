using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{   
  public float Velocidad;
public Transform[] Puntos;
public GameObject[] Pregunta;
public GameObject camara1;
public GameObject camara2;
public GameObject camara3;
public GameObject BtnSiguiente;
public GameObject textSiguiente;

//Internos
private int indexActual = 0; 
Vector3 PuntoA; 
Vector3 PuntoB; 
float t; 
float factorT; 
int disparador;


void Start()
{
    t = 1f; 
}

void Update()
{
    if(disparador==1){  
     t += factorT * Time.deltaTime;
    if (t >= 1f) 
    {
        // cambioCamara2();
        BtnSiguiente.SetActive(true);
        textSiguiente.SetActive(true);
        disparador=0;
        // Pregunta[IndexActual].SetActive(true);
    }

    transform.position = Vector3.Lerp(PuntoA, PuntoB, t);
    }

     if(disparador==2){  
     t += factorT * Time.deltaTime;
    if (t >= 1f) 
    {
        disparador--;
        CalcularValores(1);
        
        // Pregunta[IndexActual].SetActive(true);
    }

    transform.position = Vector3.Lerp(PuntoA, PuntoB, t);
    }

     if(disparador==3){  
     t += factorT * Time.deltaTime;
    if (t >= 1f) 
    {
        disparador--;
        CalcularValores(2);
        
        // Pregunta[IndexActual].SetActive(true);
    }

    transform.position = Vector3.Lerp(PuntoA, PuntoB, t);
    }
 
 
}


public void CalcularValores(int numeroDeCasillas)

{   
    // for(int i=0; i<numero ;i++){
     Pregunta[IndexActual].SetActive(false);
    cambioCamara1();
     disparador=numeroDeCasillas;
    PuntoA = Puntos[IndexActual].position;
    PuntoB = Puntos[IndexActual + 1].position;
    t = 1.0f - t; 
    factorT = 1.0f / Vector3.Distance(PuntoA, PuntoB) * Velocidad;
    IndexActual++;
    // }
    
}


public void pregunta(){
    if(IndexActual==11 ||IndexActual==13 ||IndexActual==17 || IndexActual==21){
        CambioCamara3();
    Pregunta[IndexActual].SetActive(true);
    }
    else {
        cambioCamara2();
    Pregunta[IndexActual].SetActive(true);
    }

}

   
  void cambioCamara1(){
        camara2.SetActive(false);
        camara1.SetActive(true);
        camara3.SetActive(false);
  }

    void cambioCamara2(){
        camara2.SetActive(true);
        camara1.SetActive(false);
        camara3.SetActive(false);
  }
  
    void CambioCamara3(){
    camara3.SetActive(true);
    camara2.SetActive(false);
    camara1.SetActive(false);
 
   }



          public int  IndexActual  // property
  {
    get { return indexActual; }
    set { indexActual = value; }
  }
  


}
