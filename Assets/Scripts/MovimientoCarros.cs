using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovimientoCarros : MonoBehaviour
{

   public  GameObject[] player;
   public NavMeshAgent[] nav;
   public NavMeshAgent primerObjeto;
    public NavMeshAgent SegundoObjeto;
     public NavMeshAgent TercerObjeto;
   List<NavMeshAgent>  ObjetosCarros;
   Vector3 positionInicial;
   int contador;
   int NavRamdom;
   bool bandera;
   bool seguir1;
   bool seguir2;
   bool seguir3;
   bool seguir4;
   bool seguir5;
   int ContadorDecarros;
    int numero;
    int numero2;
    int numero3;
    void Start()
    {   
        numero=0;
        numero2=0;
        numero3=0;
        ObjetosCarros=new List<NavMeshAgent>();
        // NavRamdom=Random.Range(0,9);
        NavRamdom=Random.Range(0,9);  
        primerObjeto=Instantiate(nav[NavRamdom],new Vector3(118.6569f, -2.031067f, 134.2f), Quaternion.identity);
        contador=0;
        bandera=true;
        seguir1=false;
        seguir2=false;
        seguir3=false;
        seguir4=false;
        seguir5=false;

        // primerObjeto=Instantiate(nav[NavRamdom],new Vector3(118.6569f, -2.031067f, 134.2f), Quaternion.identity);
        // ObjetosCarros.Add(primerObjeto);
    }

    // Update is called once per frame
    void Update()
    {
        CreadorCarros();
    }

  

    void CreadorCarros(){

        if(seguir1){
            
             NavRamdom=Random.Range(0,9);  
             primerObjeto=Instantiate(nav[NavRamdom],new Vector3(118.6569f, -2.031067f, 134.2f), Quaternion.identity);
             seguir1=false;
             ObjetosCarros.Add(primerObjeto); 

        }
        movimiento(primerObjeto);

         if(seguir2){
            
             NavRamdom=Random.Range(0,9);  
             SegundoObjeto=Instantiate(nav[NavRamdom],new Vector3(118.6569f, -2.031067f, 134.2f), Quaternion.identity);
             seguir2=false;
             seguir4=true;
             ObjetosCarros.Add(SegundoObjeto); 
        }
        if(seguir4){
        movimiento2(SegundoObjeto);
        }

         if(seguir3){
            
             NavRamdom=Random.Range(0,9);  
             TercerObjeto=Instantiate(nav[NavRamdom],new Vector3(118.6569f, -2.031067f, 134.2f), Quaternion.identity);
             seguir3=false;
             seguir5=true;
             ObjetosCarros.Add(TercerObjeto); 
        }
        if(seguir5){
        movimiento3(TercerObjeto);
        }
    //     if(bandera){
    //     // NavRamdom=Random.Range(0,9);  
    //     // primerObjeto=Instantiate(nav[NavRamdom],new Vector3(118.6569f, -2.031067f, 134.2f), Quaternion.identity);
    //     // primerObjeto=Instantiate(nav[NavRamdom],new Vector3(118.6569f, -2.031067f, 134.2f), Quaternion.identity);
    //     // ObjetosCarros.Add(primerObjeto);
    //     movimiento(primerObjeto);
    //     }
    //    else if(seguir){
    //         NavRamdom=Random.Range(0,9);  
    //         NavMeshAgent SegundoObjeto=Instantiate(nav[NavRamdom],new Vector3(118.6569f, -2.031067f, 134.2f), Quaternion.identity);
    //         movimiento(SegundoObjeto);

    //     }
        }
    


    void movimiento(NavMeshAgent Carro){
        //  NavMeshAgent opcional=Instantiate(nav[NavRamdom],new Vector3(118.6569f, -2.031067f, 134.2f), Quaternion.identity);
        // if(bandera){
        // primerObjeto=Instantiate(nav[NavRamdom],new Vector3(118.6569f, -2.031067f, 134.2f), Quaternion.identity);
        // ObjetosCarros.Add(primerObjeto); 
        // bandera==false;
        // }
        
       Carro.SetDestination(player[numero].transform.position);
        if(Carro.transform.position.x==player[numero].transform.position.x && Carro.transform.position.z==player[numero].transform.position.z ){
            numero++;
            if(numero==1){ 
            seguir2=true;
            bandera=false;}
              if(numero==3){
            numero=0;
            Destroy(ObjetosCarros[0]);
            Destroy(Carro);
            seguir1=true;
        }
          
        }
       
        // if(numero==3){
        //     numero=0;
        //     Destroy(Carro);
        //     seguir1=true;
        // }
    
    }
    void movimiento2(NavMeshAgent Carro){
        //  NavMeshAgent opcional=Instantiate(nav[NavRamdom],new Vector3(118.6569f, -2.031067f, 134.2f), Quaternion.identity);
        // if(bandera){
        // primerObjeto=Instantiate(nav[NavRamdom],new Vector3(118.6569f, -2.031067f, 134.2f), Quaternion.identity);
        // ObjetosCarros.Add(primerObjeto); 
        // bandera==false;
        // }
       
       Carro.SetDestination(player[numero2].transform.position);
        if(Carro.transform.position.x==player[numero2].transform.position.x && Carro.transform.position.z==player[numero2].transform.position.z ){
            numero2++;
              if(numero2==1){ 
                  seguir3=true;
            }

              if(numero2==3){
            numero2=0;
             Destroy(ObjetosCarros[0]);
            Destroy(SegundoObjeto);
            seguir2=true;
        }
            
        }
        //  if(numero2==3){
        //     numero2=0;
        //     Destroy(Carro);
        //     seguir2=true;
        // }
    
    }
    void movimiento3(NavMeshAgent Carro){
        //  NavMeshAgent opcional=Instantiate(nav[NavRamdom],new Vector3(118.6569f, -2.031067f, 134.2f), Quaternion.identity);
        // if(bandera){
        // primerObjeto=Instantiate(nav[NavRamdom],new Vector3(118.6569f, -2.031067f, 134.2f), Quaternion.identity);
        // ObjetosCarros.Add(primerObjeto); 
        // bandera==false;
        // }
        
       Carro.SetDestination(player[numero3].transform.position);
        if(Carro.transform.position.x==player[numero3].transform.position.x && Carro.transform.position.z==player[numero3].transform.position.z ){
            NavRamdom=Random.Range(0,9);
            numero3++;
             if(numero3==1){ 

            bandera=false;}
              if(numero3==3){
            numero3=0;
            Destroy(TercerObjeto);
            seguir3=true;
           
        }
        }
        // if(numero3==3){
        //     numero3=0;
        //     Destroy(Carro);
        //     seguir3=true;
        // }
    
    }

}
