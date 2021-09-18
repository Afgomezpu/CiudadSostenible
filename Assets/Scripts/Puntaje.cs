using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
     private int puntaje1;
     private int contador1;
     private int puntaje2;
     private int contador2;
     private int puntaje3;
     private int contador3;
     private int puntaje4;
     private int contador4;
     private int puntaje5;
     private int contador5;
     private int puntaje6;
     private int contador6;
     private int puntaje7;
     private int contador7;
     private int puntaje8;
     private int contador8;
     private int puntaje9;
     private int contador9;
    private int[] puntuaciones=new int[]{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
    private int[] numeroPregunta;

    void Start()
    { 
      

      // for(int i=0; i<Puntuaciones.Length;i++){
      //   Puntuaciones[i]=0;
      // }
      numeroPregunta=new int[23]; 
     Puntaje1=0;
     Contador1=0;
      Puntaje2=0;
     Contador2=0;
     Puntaje3=0;
     Contador3=0;
     Puntaje4=0;
     Contador4=0;
     Puntaje5=0;
     Contador5=0;
     Puntaje6=0;
     Contador6=0;
     Puntaje7=0;
     Contador7=0;
     Puntaje8=0;
     Contador8=0;
     Puntaje9=0;
     Contador9=0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

              public int  Puntaje1  // property
  {
    get { return puntaje1; }
    set { puntaje1 = value; }
  }
  
              public int  Contador1  // property
  {
    get { return contador1; }
    set { contador1 = value; }
  }

                 public int  Puntaje2  // property
  {
    get { return puntaje2; }
    set { puntaje2 = value; }
  }
  
              public int  Contador2  // property
  {
    get { return contador2; }
    set { contador2 = value; }
  }
                public int  Puntaje3  // property
  {
    get { return puntaje3; }
    set { puntaje3 = value; }
  }
  
              public int  Contador3  // property
  {
    get { return contador3; }
    set { contador3 = value; }
  }
                public int  Puntaje4 // property
  {
    get { return puntaje4; }
    set { puntaje4 = value; }
  }
  
              public int  Contador4  // property
  {
    get { return contador4; }
    set { contador4 = value; }
  }
                public int  Puntaje5  // property
  {
    get { return puntaje5; }
    set { puntaje5 = value; }
  }
  
              public int  Contador5  // property
  {
    get { return contador5; }
    set { contador5 = value; }
  }
                public int  Puntaje6  // property
  {
    get { return puntaje6; }
    set { puntaje6 = value; }
  }
  
              public int  Contador6  // property
  {
    get { return contador6; }
    set { contador6 = value; }
  }
                public int  Puntaje7  // property
  {
    get { return puntaje7; }
    set { puntaje7 = value; }
  }
  
              public int  Contador7  // property
  {
    get { return contador7; }
    set { contador7 = value; }
  }
                public int  Puntaje8  // property
  {
    get { return puntaje8; }
    set { puntaje8 = value; }
  }
  
              public int  Contador8  // property
  {
    get { return contador8; }
    set { contador8 = value; }
  }
                public int  Puntaje9  // property
  {
    get { return puntaje9; }
    set { puntaje9 = value; }
  }
  
              public int  Contador9  // property
  {
    get { return contador9; }
    set { contador9 = value; }
  } 
  
              public int[]  Puntuaciones  // property
  {
    get { return puntuaciones; }
    set { puntuaciones = value; }
  } 
}
