using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    [SerializeField] int nivel;
    // Start is called before the first frame update
    void Start()
    {
        if (nivel % 2 == 0)
        {
            Debug.Log("PAR");

        }
        else 
        {
            Debug.Log("IMPAR");

        }
    }

   
}
