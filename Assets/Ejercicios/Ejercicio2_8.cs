using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    int vida1 = 120;
    float veneno;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(VenenoQuita(0.03));
        Debug.Log(VenenoQuita(0.06));
        Debug.Log(VenenoQuita(0.09));
        Debug.Log(VenenoQuita(0.12));
        Debug.Log(VenenoQuita(0.15));
    }

    // Update is called once per frame
   


    void VenenoQuita(float veneno)
    {
        
        vida1 -= vida1 * veneno;

        Debug.log(vida1);
        
    
    }

}
