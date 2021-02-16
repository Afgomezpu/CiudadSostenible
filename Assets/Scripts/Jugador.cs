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

//Internos
int IndexActual = 0; 
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
        cambioCamara2();
        disparador=0;
        Pregunta[IndexActual].SetActive(true);
    }

    transform.position = Vector3.Lerp(PuntoA, PuntoB, t);
    }
     if(disparador==2){   
        t += factorT * Time.deltaTime;
    if (t >= 1f) 
    {
        disparador=0;
        cambioCamara1();
    }

    transform.position = Vector3.Lerp(PuntoA, PuntoB, t);
    }
}


public void CalcularValores()

{   Pregunta[IndexActual].SetActive(false);
    cambioCamara1();
     disparador=1;
    PuntoA = Puntos[IndexActual].position;
    PuntoB = Puntos[IndexActual + 1].position;
    t = 1.0f - t; 
    factorT = 1.0f / Vector3.Distance(PuntoA, PuntoB) * Velocidad;
    IndexActual++;
}


public void CalcularValoresAtras()
{   Pregunta[IndexActual].SetActive(false);
    cambioCamara1();
    disparador=2;
    PuntoA = Puntos[IndexActual].position;
    PuntoB = Puntos[IndexActual - 1].position;
    t = 1.0f - t; 
    factorT = 1.0f / Vector3.Distance(PuntoA, PuntoB) * Velocidad;
    IndexActual--;
}

  void cambioCamara1(){
        camara2.SetActive(false);
        camara1.SetActive(true);
  }

    void cambioCamara2(){
        camara2.SetActive(true);
        camara1.SetActive(false);
  }


}
