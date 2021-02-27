using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovimientoCarros : MonoBehaviour
{
    
   public  GameObject[] player;
   public NavMeshAgent[] nav;
   Vector3 positionInicial;
   int contador;
   int NavRamdom=Random.Range(0,9);

    void Start()
    { 
       
       contador=0;
    }

    // Update is called once per frame
    void Update()
    {
        movimiento();
    }

    void movimiento(){
        instantiate(nav[NavRamdom]);
        nav[NavRamdom].SetDestination(player[contador].transform.position);
        if(nav[NavRamdom].transform.position.x==player[contador].transform.position.x && nav[NavRamdom].transform.position.z==player[contador].transform.position.z){
            NavRamdom=Random.Range(0,9);
            contador++;
        }
    }

}
