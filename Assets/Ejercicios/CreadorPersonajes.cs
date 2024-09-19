using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{
    int numero = 5;
    string texto = "loco";
    [SerializeField]Personaje link;


    // Start is called before the first frame update
    void Start()
    {
        link.Vida = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
