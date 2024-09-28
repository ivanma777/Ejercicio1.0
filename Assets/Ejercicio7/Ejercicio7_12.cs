using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    
    // Start is called before the first frame update
    void Start()
    {
        SumarTodosLosNumeros(num1, num2);
    }

    void SumarTodosLosNumeros(int sum1, int sum2 )
    {
        int result = 0;

        if ( sum1 <= sum2 )
        {
            for (int i = sum1; i <= sum2; i++)
            {
                result =  result + i;
               
            }
           

            Debug.Log(result);
        }
        if (sum1 >= sum2)
        {
            for (int i = sum2; i <= sum1; i++)
            {
                result =result + i ;
                
            }
             
            Debug.Log(result);
        }



    }
}
