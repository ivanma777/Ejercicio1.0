using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ejercicios4_1 : MonoBehaviour
{
    float radio = 2.2f, basee = 2f, altura = 4f, lado = 5f;
    float areaC,areaT,areaCu;

    // Start is called before the first frame update
    void Start()
    {
        AreaCirculo();
        Debug.Log(areaC);

        AreaTriangulo();
        Debug.Log(areaT);
        
        AreaCuadrado();
        Debug.Log(areaCu);


    }

    // Update is called once per frame
   void AreaCirculo()
    {
        areaC = radio * radio * 3.14f;

    }
    void AreaTriangulo()
    {
        areaT = (basee * altura) / 2;

    }
    void AreaCuadrado()
    {
        areaCu = lado * lado;

    }
}
