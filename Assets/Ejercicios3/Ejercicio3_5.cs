using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radio;
    float longitud, area;
    // Start is called before the first frame update
    void Start()
    {
        longitud = 2 * 3.14 * radio;
        area = 3.14 * radio ^ 2;

        Debug.log("la longitud es " + longitud);
        Debug.log("la area es " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
