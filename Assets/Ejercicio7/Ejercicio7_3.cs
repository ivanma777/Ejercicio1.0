using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_3 : MonoBehaviour
{
    int soldado = 100;
    // Start is called before the first frame update
    void Start()
    {
        while (soldado >= 1)
        {
            soldado--;
            Debug.Log(soldado);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
