using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{   
  public float Velocidad;
public Transform[] Puntos;
public GameObject camara1;
public GameObject camara2;

//Internos
int IndexActual = 0; //Index para mover en puntos
Vector3 PuntoA; //Punto A para Lerp
Vector3 PuntoB; //Punto B para Lerp
float t; //Factor tiempo de Lerp
float factorT; //Factor de moviemnto
int disparador;


void Start()
{
    t = 1f; //Esto ayuda al primer calculo
}

void Update()
{
    if(disparador==1){  
     t += factorT * Time.deltaTime;
    if (t >= 1f) //ya llegamos?
    {
        disparador=0;
        cambioCamara2();
    }

    transform.position = Vector3.Lerp(PuntoA, PuntoB, t);
    }
     if(disparador==2){   
        t += factorT * Time.deltaTime;
    if (t >= 1f) //ya llegamos?
    {
        disparador=0;
        cambioCamara1();
    }

    transform.position = Vector3.Lerp(PuntoA, PuntoB, t);
    }
}


public void CalcularValores()

{    cambioCamara1();
     disparador=1;
    PuntoA = Puntos[IndexActual].position;
    PuntoB = Puntos[IndexActual + 2].position;
    t = 1.0f - t; //Solo para continuar con el movimiento y no se vea brusco una pausa
    //FactorT siempre sera diferente entre puntos, pero al final esto ayudara que el moviento siempre sea la misma.
    factorT = 1.0f / Vector3.Distance(PuntoA, PuntoB) * Velocidad;
    // IndexActual++;
    IndexActual=IndexActual+2;
}


public void CalcularValoresAtras()
{   cambioCamara1();
    disparador=2;
    PuntoA = Puntos[IndexActual].position;
    PuntoB = Puntos[IndexActual - 1].position;
    t = 1.0f - t; //Solo para continuar con el movimiento y no se vea brusco una pausa
    //FactorT siempre sera diferente entre puntos, pero al final esto ayudara que el moviento siempre sea la misma.
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
