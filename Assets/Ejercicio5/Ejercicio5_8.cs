using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int H;
    [SerializeField] int M;
    [SerializeField] int S;
    // Start is called before the first frame update
    void Start()
    {
        if (  H <= 59 && M <= 59 && S <= 59)
        {
            Debug.Log("Son las " + H + ":" + M );

        }
    }

    
}