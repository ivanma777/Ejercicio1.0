using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios4_4 : MonoBehaviour
{
    [SerializeField]float velocidad;
    // Start is called before the first frame update
    void Start()
    {

        CambioVelocidad();


    }

    // Update is called once per frame
    void CambioVelocidad()
    {
        velocidad *= 3.6f;
        Debug.Log(velocidad);
    }
}
