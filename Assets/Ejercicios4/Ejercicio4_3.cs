using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Convertir(5.5f, "euro");
        Debug.Log(Convertir(5.5f,"euro");
    }

    // Update is called once per frame
    string Convertir(float cantidad, string moneda)
    {
        if (moneda == "euro")
        {
            cantidad = cantidad * 1.11f;

        }
        if  (moneda == "dolar")
        {
            cantidad /= 1.11f;
        
        }
        string Moneda = cantidad + "Tipo moneda";
    }
}
