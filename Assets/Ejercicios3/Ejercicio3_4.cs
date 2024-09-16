using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] float exp;
    float lvl;
    // Start is called before the first frame update
    void Start()
    {
        lvl = 32 + (9 * EXP / 5);

        Debug.log("el nivel es " + lvl);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
