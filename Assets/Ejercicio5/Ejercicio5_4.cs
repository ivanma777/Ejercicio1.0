using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] float numero11, numero12;
    float resultado;
    // Start is called before the first frame update
    void Start()
    {
        if (numero11 == 0 || numero12 == 0)
        {
            Debug.Log("ERROR");

        }
        else
        {

            resultado = numero11 / numero12;
            Debug.Log(resultado);
        }
    }

    // Update is called once per frame
    
}
