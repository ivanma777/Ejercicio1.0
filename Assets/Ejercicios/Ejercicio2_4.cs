using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vidas = 5;
    // Start is called before the first frame update
    void Start()
    {
        vidas += 77;

        Debug.Log("vidas =" + vidas);

        vidas -= 3;

        Debug.Log("vidas =" + vidas);

        vidas *= 4;
        
        Debug.Log("vidas =" + vidas);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
