using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ConstruirNombre("Pepe", "Piyuela", "Bicarbonato", 33);
    }

    // Update is called once per frame
   void ConstruirNombre(string nombre, string apellido1, string apellido2, int edad)
   {
       

        Debug.Log("La persona se llama  "  + nombre +  apellido1 + apellido2 + "y  tiene " + edad + " a�os");


    }
}
