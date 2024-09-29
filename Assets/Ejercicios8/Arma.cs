using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] float danhoMin;
    [SerializeField] float danhoMax;
    [SerializeField] float CapacidadTotal;
    [SerializeField] bool auto;
    private float Municion;
    
    // Start is called before the first frame update
    void Start()
    {
        Municion = CapacidadTotal;
        
    }

   public float UtilizarArma()
    {
        if (Municion > 0)
        {
            Municion--;
            return 0 ;

        }
        else
        {
            
            return -1;

        }

    }
  public  float RecargarArma()
    {
        if (Municion < CapacidadTotal)
        {
            Municion = CapacidadTotal;
            return 0;

        }
        else
        {
            return -1f;

        }

    }
}
