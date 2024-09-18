using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios4_5 : MonoBehaviour
{
    float radio = 2.2f, basee = 2f, altura = 4f, lado = 5f;
    float areaC, areaT, areaCu;
    // Start is called before the first frame update
    void Start()
    {
        AreaCirculo();
        Convertir(areaC, "euro");
        
    }

    // Update is called once per frame
    void Convertir(float cantidad, string moneda)
    {
        if (moneda == "euro")
        {
            cantidad = cantidad * 1.11f;

        }
        if (moneda == "dolar")
        {
            cantidad /= 1.11f;

        }
        string Moneda = cantidad + "Tipo moneda";

        Debug.Log(cantidad);
    }
    void AreaCirculo()
    {
        areaC = radio * radio * 3.14f;

    }
    //float AreaCirculo()
    //areC = radio * radio * 3.14f;
    //return;
    //Esto es otra forma de arreglarlo para poner directamente el metodo
    void AreaTriangulo()
    {
        areaT = (basee * altura) / 2;

    }
    void AreaCuadrado()
    {
        areaCu = lado * lado;

    }
}
