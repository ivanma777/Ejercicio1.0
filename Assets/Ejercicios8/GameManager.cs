using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Personaje1 personaje1;
    [SerializeField] Personaje1 personaje2;
    int yaEjecutado = 1;

    // Start is called before the first frame update
    void Start()
    {
        if (yaEjecutado == 1)
        {
           
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
                PrepararPersonajes();
                
                Debug.Log(personaje1.Vida + "y exp " + personaje1.Exp + " y LVL" + personaje1.CalcularNivel(personaje1.Exp));
                Debug.Log(personaje2.Vida + "y exp " + personaje2.Exp + " y LVL" + personaje2.CalcularNivel(personaje2.Exp));

                yaEjecutado ++;
            }


        }
        


    }

    // Update is called once per frame
    void PrepararPersonajes( )
    {
        personaje1.Vida = 40;
        personaje2.Vida = 40;
        personaje1.Exp = 40;
        personaje2.Exp = 40;

       
       

       
       
    }
}
