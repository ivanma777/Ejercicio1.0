using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    [SerializeField] int num;
    int result;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            result = i * num;
            Debug.Log(result);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
