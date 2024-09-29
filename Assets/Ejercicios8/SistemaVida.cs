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

    public float RecibirCura(float cantidad) 
           {
        
                
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

   public  float RecibirDanho(float danho)
         {
            
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
