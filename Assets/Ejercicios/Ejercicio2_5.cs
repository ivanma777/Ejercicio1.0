using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1 = 3;
    int vidasPlayer2 = 4;
    int vidasPlayer3 = 5;
    int vidasPlayer4 = 6;
    // Start is called before the first frame update
    void Start()
    {
        vidasPlayer2 = vidasPlayer3;

        Debug.log(vidasPlayer3);

        vidasPlayer3 = vidasPlayer1;

        Debug.log(vidasPlayer1);


        vidasPlayer1 = vidasPlayer4;

        Debug.log(vidasPlayer4);


        vidasPlayer4 = vidasPlayer2;

        Debug.log(vidasPlayer);





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
