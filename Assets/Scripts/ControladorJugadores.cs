﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugadores : MonoBehaviour
{
    private int jugadores;
    
    
       void Awake(){
        DontDestroyOnLoad(gameObject);
    }
    
    void Start()
    {
      
    }


    void Update()
    {
        
    }

    public void NumeroJugadores(int numero){

        Jugadores=numero;
    }

        public int Jugadores   // property
  {
    get { return jugadores; }
    set { jugadores = value; }
  }



}