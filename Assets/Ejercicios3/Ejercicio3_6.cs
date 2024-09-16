using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float velocidad;
    float velocidadMs;
    
    
    // Start is called before the first frame update
    void Start()
    {
        velocidadMs = velocidad / 3.6f;
        Debug.Log("la velocidad en ms es " + velocidadMs);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
