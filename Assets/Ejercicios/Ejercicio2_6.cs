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
        Debug.log(velocidad);
        Debug.log(da�o);
        Debug.log(defensa);

        media = velocidad + defensa + da�o;

        media /= 3;

        Debug.log(media);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
