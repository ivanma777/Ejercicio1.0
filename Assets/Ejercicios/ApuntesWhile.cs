using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApuntesWhile : MonoBehaviour
{
    [SerializeField] int vidas;
    // Start is called before the first frame update
    void Start()
    {
        //while : mientras
        //Bucle indeterminado
        //for : determinadoe
        while (vidas > 0) //Bucle (ciclo)
        {
            Debug.Log("sigo vivo con " + vidas);

            vidas--; //vidas = vidas - 1
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
