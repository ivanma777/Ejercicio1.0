using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int num;
    // Start is called before the first frame update
    void Start()
    {
        while (num == -num)
        {
            num--;
            Debug.Log(num);

        }

        for (int i = num; i == -num ; i--)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
