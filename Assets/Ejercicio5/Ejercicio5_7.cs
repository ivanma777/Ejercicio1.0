using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int velocida;
    [SerializeField] int velocida2;
    [SerializeField] int velocida3;
    
    // Start is called before the first frame update
    void Start()
    {
        if(velocida > velocida2 && velocida > velocida3)
        {
            Debug.Log("el veloz es 1");
        }
        else if(velocida2 > velocida3)
        {
            Debug.Log("el veloz es 2");

        }
        else
        {
            Debug.Log("veloz 3");

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
