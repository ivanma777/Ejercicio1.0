using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Ejercicios4_1 : MonoBehaviour
{
    float radio = 2.2f;
    float areaC;
    // Start is called before the first frame update
    void Start()
    {
        AreaCirculo();
        Debug.Log(areaC);
    }

    // Update is called once per frame
   void AreaCirculo()
    {
        areaC = radio * radio * 3.14f;

    }
}
