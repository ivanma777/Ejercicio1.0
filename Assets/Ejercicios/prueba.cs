using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        SumaDosNum();
    }

    // Update is called once per frame
   

    void SumaDosNum ()
    {
        RestarDosNumeros();

    }

    void RestarDosNumeros()
    {
        //Variables locales//

        int paga1 = 3;
        int paga2 = 3;
        int pagaTotal = paga1 + paga2;
        Debug.Log(pagaTotal);



    }


    void HacerSuperNena(float sugar, float purpurina, string nombre)
    {

    }
    
}
