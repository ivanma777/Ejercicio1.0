using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje1 : MonoBehaviour
{
    private string nombre;
    private int exp;
    private int vida;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   float CacularNivel()
    {
        int LVL;
        LVL = exp / 1000;
        return LVL;

    }
}
