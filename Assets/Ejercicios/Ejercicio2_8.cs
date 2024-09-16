using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    int vida1 = 120;
    float veneno = 0f;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(VenenoQuita);
    }

    // Update is called once per frame
    void Update()
    {
        VenenoQuita();
    }


    void VenenoQuita(veneno < float 0.15)
    {
        veneno += 0.03;
        vida1 -= vida1 * veneno;

        Debug.log(vida1);
    
    }

}
