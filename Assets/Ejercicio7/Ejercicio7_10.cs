using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    float resultado;
    // Start is called before the first frame update
    void Start()
    {
        {
            for (int i = num2; i <= num1; i++)
            {
                resultado = i % 2;
                if (i >= 0 && resultado == 0)
                {
                    Debug.Log(i + "postivo" + " par");
                }
                else if (i >= 0 && resultado > 0)
                {
                    Debug.Log(i + "postivo" + " impar");


                } 
                else if (i < 0 && resultado > 0)
                {
                    Debug.Log(i + "negativo" + " impar");


                }
                else
                {
                    Debug.Log(i + " negativo" + " par");

                }

            }
            for (int i = num2; i >= num1; i--)
            {

                resultado = i % 2;
                if (i >= 0 && resultado == 0)
                {
                    Debug.Log(i + "postivo" + " par");
                }
                else if (i >= 0 && resultado > 0)
                {
                    Debug.Log(i + "postivo" + " impar");


                }
                else if (i < 0 && resultado > 0)
                {
                    Debug.Log(i + "negativo" + " impar");


                }
                else
                {
                    Debug.Log(i + " negativo" + " par");

                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
