using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovimientoCarros : MonoBehaviour
{

   public  GameObject[] player;
   public NavMeshAgent[] nav;
    NavMeshAgent primerObjeto;
    NavMeshAgent SegundoObjeto;
    NavMeshAgent TercerObjeto;
    NavMeshAgent CuartoObjeto;
    NavMeshAgent QuintoObjeto;
    NavMeshAgent SextoObjeto;
    NavMeshAgent SeptimoObjeto;
    NavMeshAgent OctavoObjeto;
    NavMeshAgent NovenoObjeto;
   List<NavMeshAgent>  ObjetosCarros;
   public float x;
   public float y;
   public float z;
   Vector3 positionInicial;
   int contador;
   int NavRamdom;
 
   bool seguir2;
   bool seguir3;
   bool seguir4;
   bool seguir5;
    bool seguir6;
   bool seguir7;
   bool seguir8;
   bool seguir9;
    bool seguirMove2;
   bool seguirMove3;
   bool seguirMove4;
   bool seguirMove5;
    bool seguirMove6;
   bool seguirMove7;
   bool seguirMove8;
   bool seguirMove9;
   int ContadorDecarros;
    int numero;
    int numero2;
    int numero3;
    int numero4;
    int numero5;
    int numero6;
    int numero7;
    int numero8;
    int numero9;
    bool pararCarros;
    void Start()
    {   
        numero=0;
        numero2=0;
        numero3=0;
        ObjetosCarros=new List<NavMeshAgent>();
        // NavRamdom=Random.Range(0,8);
        NavRamdom=Random.Range(0,nav.Length);  
        primerObjeto=Instantiate(nav[NavRamdom],new Vector3(x, y,z), Quaternion.identity);
        contador=0;
        seguir2=false;
        seguir3=false;
        seguir4=false;
        seguir6=false;
        seguir7=false;
        seguir8=false;
        seguir5=false;
        seguir9=false;
        seguirMove2=false;
        seguirMove3=false;
        seguirMove4=false;
        seguirMove5=false;
        seguirMove6=false;
        seguirMove7=false;
        seguirMove8=false;
        seguirMove9=false;
        pararCarros=true;


    }

    // Update is called once per frame
    void Update()
    {
        CreadorCarros();
    }

  

    void CreadorCarros(){


        movimiento(primerObjeto);

         if(seguir2){
            
            NavRamdom=Random.Range(0,nav.Length);  
             SegundoObjeto=Instantiate(nav[NavRamdom],new Vector3(x,y,z), Quaternion.identity);
             seguir2=false;
             seguirMove2=true;
             ObjetosCarros.Add(SegundoObjeto); 
        }
        if(seguirMove2){
        movimiento2(SegundoObjeto);
        }

         if(seguir3){
            
            NavRamdom=Random.Range(0,nav.Length);  
             TercerObjeto=Instantiate(nav[NavRamdom],new Vector3(x,y,z), Quaternion.identity);
             seguir3=false;
             seguirMove3=true;
             ObjetosCarros.Add(TercerObjeto); 
        }
        if(seguirMove3){
        movimiento3(TercerObjeto);
        }
           if(seguir4){
            
            NavRamdom=Random.Range(0,nav.Length);  
             CuartoObjeto=Instantiate(nav[NavRamdom],new Vector3(x,y,z), Quaternion.identity);
             seguir4=false;
             seguirMove4=true;
             ObjetosCarros.Add(TercerObjeto); 
        }
        if(seguirMove4){
        movimiento4(CuartoObjeto);
        }
           if(seguir5){
            
            NavRamdom=Random.Range(0,nav.Length);  
             QuintoObjeto=Instantiate(nav[NavRamdom],new Vector3(x,y,z), Quaternion.identity);
             seguir5=false;
             seguirMove5=true;
             ObjetosCarros.Add(TercerObjeto); 
        }
        if(seguirMove5){
        movimiento5(QuintoObjeto);
        }
           if(seguir6){
            
            NavRamdom=Random.Range(0,nav.Length);  
             SextoObjeto=Instantiate(nav[NavRamdom],new Vector3(x,y,z), Quaternion.identity);
             seguir6=false;
             seguirMove6=true;
             ObjetosCarros.Add(TercerObjeto); 
        }
        if(seguirMove6){
        movimiento6(SextoObjeto);
        }
           if(seguir7){
            
            NavRamdom=Random.Range(0,nav.Length);  
             SeptimoObjeto=Instantiate(nav[NavRamdom],new Vector3(x,y,z), Quaternion.identity);
             seguir7=false;
             seguirMove7=true;
             ObjetosCarros.Add(TercerObjeto); 
        }
        if(seguirMove7){
        movimiento7(SeptimoObjeto);
        }
           if(seguir8){
            
            NavRamdom=Random.Range(0,nav.Length);  
             OctavoObjeto=Instantiate(nav[NavRamdom],new Vector3(x,y,z), Quaternion.identity);
             seguir8=false;
             seguirMove8=true;
             ObjetosCarros.Add(TercerObjeto); 
        }
        if(seguirMove8){
        movimiento8(OctavoObjeto);
        }
           if(seguir9){
            
            NavRamdom=Random.Range(0,nav.Length);  
             NovenoObjeto=Instantiate(nav[NavRamdom],new Vector3(x,y,z), Quaternion.identity);
             seguir9=false;
             seguirMove9=true;
             ObjetosCarros.Add(TercerObjeto); 
        }
        if(seguirMove9){
        movimiento9(NovenoObjeto);
        }
    
    }
    


    void movimiento(NavMeshAgent Carro){
   
        
       Carro.SetDestination(player[numero].transform.position);
        if(Carro.transform.position.x==player[numero].transform.position.x && Carro.transform.position.z==player[numero].transform.position.z ){
            numero++;
            if(numero==1 && pararCarros==true){ 
            seguir2=true;
              }
              if(numero==11){
            numero=0;
            pararCarros=false;
    

        }  
        }
       
   
    
    }
    void movimiento2(NavMeshAgent Carro){
 
       Carro.SetDestination(player[numero2].transform.position);
        if(Carro.transform.position.x==player[numero2].transform.position.x && Carro.transform.position.z==player[numero2].transform.position.z ){
            numero2++;
              if(numero2==1 && pararCarros==true){ 
                  seguir3=true;
            }

              if(numero2==11){
            numero2=0;
            pararCarros=false;
         
        }
            
        }
 
    
    }
    void movimiento3(NavMeshAgent Carro){
      
       Carro.SetDestination(player[numero3].transform.position);
        if(Carro.transform.position.x==player[numero3].transform.position.x && Carro.transform.position.z==player[numero3].transform.position.z ){
            NavRamdom=Random.Range(0,8);
            numero3++;
             if(numero3==1 && pararCarros==true){ 
                 seguir4=true;
              }
              if(numero3==11){
            numero3=0;
            pararCarros=false;
           
           
        }
        }
      
    
    }
        void movimiento4(NavMeshAgent Carro){
      
       Carro.SetDestination(player[numero4].transform.position);
        if(Carro.transform.position.x==player[numero4].transform.position.x && Carro.transform.position.z==player[numero4].transform.position.z ){
            NavRamdom=Random.Range(0,8);
            numero4++;
             if(numero4==1 && pararCarros==true){ 
                 seguir5=true;
              }
              if(numero4==11){
            numero4=0;
            pararCarros=false;
           
           
        }
        }
      
    
    }
        void movimiento5(NavMeshAgent Carro){
      
       Carro.SetDestination(player[numero5].transform.position);
        if(Carro.transform.position.x==player[numero5].transform.position.x && Carro.transform.position.z==player[numero5].transform.position.z ){
            NavRamdom=Random.Range(0,8);
            numero5++;
             if(numero5==1 && pararCarros==true){ 
                 seguir6=true;
              }
              if(numero5==11){
            numero5=0;
           pararCarros=false;
           
        }
        }
      
    
    }
        void movimiento6(NavMeshAgent Carro){
      
       Carro.SetDestination(player[numero6].transform.position);
        if(Carro.transform.position.x==player[numero6].transform.position.x && Carro.transform.position.z==player[numero6].transform.position.z ){
            NavRamdom=Random.Range(0,8);
            numero6++;
             if(numero6==1 && pararCarros==true){ 
                 seguir7=true;
              }
              if(numero6==11){
            numero6=0;
            pararCarros=false;
           
           
        }
        }
      
    
    }
        void movimiento7(NavMeshAgent Carro){
      
       Carro.SetDestination(player[numero7].transform.position);
        if(Carro.transform.position.x==player[numero7].transform.position.x && Carro.transform.position.z==player[numero7].transform.position.z ){
            NavRamdom=Random.Range(0,8);
            numero7++;
             if(numero7==1 && pararCarros==true){ 
                 seguir8=true;
              }
              if(numero7==11){
            numero7=0;
            pararCarros=false;
           
           
        }
        }
      
    
    }
        void movimiento8(NavMeshAgent Carro){
      
       Carro.SetDestination(player[numero8].transform.position);
        if(Carro.transform.position.x==player[numero8].transform.position.x && Carro.transform.position.z==player[numero8].transform.position.z ){
            NavRamdom=Random.Range(0,8);
            numero8++;
             if(numero8==1 && pararCarros==true){ 
                 seguir9=true;
              }
              if(numero8==11){
            numero8=0;
           
           pararCarros=false;
        }
        }
      
    
    }
        void movimiento9(NavMeshAgent Carro){
      
       Carro.SetDestination(player[numero9].transform.position);
        if(Carro.transform.position.x==player[numero9].transform.position.x && Carro.transform.position.z==player[numero9].transform.position.z ){
            NavRamdom=Random.Range(0,8);
            numero9++;
             if(numero9==1 && pararCarros==true){ 

              }
              if(numero9==11){
            numero9=0;
           
           pararCarros=false;
        }}
        }


            void movimiento10(NavMeshAgent Carro){
      
       Carro.SetDestination(player[numero9].transform.position);
        if(Carro.transform.position.x==player[numero9].transform.position.x && Carro.transform.position.z==player[numero9].transform.position.z ){
            NavRamdom=Random.Range(0,8);
            numero9++;
             if(numero9==1 && pararCarros==true){ 

              }
              if(numero9==11){
            numero9=0;
           
           pararCarros=false;
        }
        }   
    }

}
