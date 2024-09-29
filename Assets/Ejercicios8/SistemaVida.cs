using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaVida : MonoBehaviour
{
    [SerializeField] float vidaInicial;
    private float vidaActual;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float RecibirCura(float cantidad) 
    {
        
        cantidad = 10;
        if (cantidad >= 0)
        {
            vidaActual = vidaInicial + cantidad;
            return vidaActual;

        }
        else
        
        {
            vidaActual = -1f;
            return vidaActual;
        }

        
    }

    float RecibirDanho(float danho)
    {
        danho = 10;
        if (danho >= 0)
        {
            vidaActual = vidaInicial - danho;
            if (vidaActual <= 0 )
            {
                vidaActual = 0;
                return vidaActual;
            }
            else
            {
                return vidaActual;

            }

        }
        else

        {
            vidaActual = -1f;
            return vidaActual;
        }

    }

}
