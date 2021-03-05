using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textoflotante : MonoBehaviour
{
    public float Vida=2;
    void Start()
    {
        
    }

   
    void Update()
    {
        Vida-=Time.deltaTime;
        if(Vida<=0){
            Destroy(this.gameObject);
        }
    }
}
