using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int elnum;
    // Start is called before the first frame update
    void Start()
    {
        if (elnum >= 0 && elnum <= 9)
        {
            Debug.Log("Ole");
        }
        else
        {

            Debug.Log("no ole para ti");
        }
    }

    // Update is called once per frame
    
}
