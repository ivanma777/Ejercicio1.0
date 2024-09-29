using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje1 : MonoBehaviour
{
    [SerializeField] Personaje1 enemigo;
    [SerializeField] Personaje1 player;
    [SerializeField] SistemaVida SistemaVida;
    [SerializeField] Arma miArma;
    [SerializeField] KeyCode KeyCode;
    [SerializeField] KeyCode KeyCode2;
    [SerializeField] KeyCode KeyCode3;
    private string nombre;
    private int exp;
    private int vida;
    private bool miTurno;
  
    public int Vida { get => vida; set => vida = value; }
    public int Exp { get => exp; set => exp = value; }
    public bool MiTurno { get => miTurno; set => miTurno = value; }


    // Start is called before the first frame update
    void Start()
    {
       if (miTurno == true)
            if (Input.GetKeyDown(KeyCode))
            {
                SistemaVida.RecibirCura(10f);

               
            }
            if (Input.GetKeyDown(KeyCode2))
            {



            miArma.UtilizarArma();
            if (miArma.UtilizarArma() == 0)
            {

                enemigo.SistemaVida.RecibirDanho(10f);
            }
            else
            {

                Debug.Log("Relaod");
            }



            }
            if (Input.GetKeyDown(KeyCode3))
            {

            miArma.RecargarArma();
            if (miArma.RecargarArma() == -1)
            {

                Debug.Log("ya cargada");
            }
            }


    }

   public float CalcularNivel(int exp)
          {
                int LVL;
                LVL = exp / 1000;
                return LVL;

          }
}
