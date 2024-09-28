using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    [SerializeField] int num;
  
    // Start is called before the first frame update
    void Start()
    {
        if (num >= 2)
        {
            int result;
            for (int i = 2; i < num; i++)
            {
                result = num % i;
                if (result == 0)
                {
                    Debug.Log("no lo es");
                    break;

                }

            }
            Debug.Log("es impar");

        }
        else
        {

            Debug.Log("no lo es");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
