using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje1 : MonoBehaviour
{
    
    private string nombre;
    private int exp;
    private int vida;
    

    public int Vida { get => vida; set => vida = value; }
    public int Exp { get => exp; set => exp = value; }
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

   public float CalcularNivel(int exp)
          {
                int LVL;
                LVL = exp / 1000;
                return LVL;

          }
}
