using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int velocidad = 3;
    int defensa = 5;
    int da�o = 3;

    float media = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(velocidad);
        Debug.Log(da�o);
        Debug.Log(defensa);

        media = velocidad + defensa + da�o;

        media /= 3;

        Debug.Log(media);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
