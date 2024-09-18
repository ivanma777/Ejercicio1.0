using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int nivel;
    // Start is called before the first frame update
    void Start()
    {
        if(nivel % 10 == 0 && nivel > 0)
        {
            Debug.Log("Es multiplo de 10");

        }
        else
        {
            Debug.Log("No lo es");

        }
    }

    
}
