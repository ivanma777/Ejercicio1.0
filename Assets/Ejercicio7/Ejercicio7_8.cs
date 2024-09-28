using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    float resto;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = num2; i <= num1; i++)
        {
            resto = i % 2;
            if (resto == 0)
            {
                Debug.Log(i);

            }
            
            

        }
        for (int i = num2; i >= num1; i--)
        {


            resto = i % 2;
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
