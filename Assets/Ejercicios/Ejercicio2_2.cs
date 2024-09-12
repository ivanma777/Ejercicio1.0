using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 3;
    float exp = 1.5f;
    char carac;
    float resultadoSuma, resultadoResta;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vidas + " " + exp);
        resultadoSuma = vidas + exp; 
        resultadoResta = exp - vidas;
        Debug.Log(resultadoSuma + " " + resultadoResta);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
