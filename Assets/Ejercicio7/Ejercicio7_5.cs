using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero;
    int inicio;
    // Start is called before the first frame update
    void Start()
    {
        while (inicio <= numero)
        {
            Debug.Log(inicio);
            inicio++;
        }

        for (int i = 1; i < numero; i++)
        {
            Debug.Log (i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
