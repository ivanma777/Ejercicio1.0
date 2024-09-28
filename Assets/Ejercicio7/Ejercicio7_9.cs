using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    [SerializeField] int num1;
    float resto;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= num1; i++)
        {
            resto = i % 3;
            if (resto == 0)
            {
                Debug.Log(i);

            }
        }
        for (int i = 1; i >= num1; i--)
        {


            resto = i % 3;
            if (resto == 0)
            {
                Debug.Log(i);

            }

        }
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
