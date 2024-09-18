using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    [SerializeField] int jugador1;
    [SerializeField] int jugador2;
    // Start is called before the first frame update
    void Start()
    {
        if (jugador1 == jugador2)
        {
            Debug.Log("Tienen la misma vida");

        }
        else
        {
            Debug.Log("No la tienen");
        
        }
    }

    // Update is called once per frame
    
}
