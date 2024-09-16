using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int oro = 0;
    // Start is called before the first frame update
    void Start()
    {
        oro = 7 * 60 * 60 * 4;
        
        Debug.Log("En cuatro horas tienes " +  oro + " de oro");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
