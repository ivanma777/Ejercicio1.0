using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float vida1 = 120f;
    float veneno;
    

    // Start is called before the first frame update
    void Start()
    {
        VenenoQuita(0.03f);
        Debug.Log(vida1); 
        VenenoQuita(0.06f);
        Debug.Log(vida1); 
        VenenoQuita(0.09f);
        Debug.Log(vida1); 
        VenenoQuita(0.12f);
        Debug.Log(vida1); 
        VenenoQuita(0.15f);
        Debug.Log(vida1); 
       

       
    }

    // Update is called once per frame
   


    void VenenoQuita(float veneno)
    {
        
        vida1 -= vida1 * veneno;

       
        
    
    }

}
