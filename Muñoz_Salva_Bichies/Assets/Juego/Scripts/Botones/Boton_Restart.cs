using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton_Restart : MonoBehaviour
{

    public GameObject Canvas_Pausa;

    public void Restart()
    {
        Canvas_Pausa.SetActive(false);

        Ficha.activar_fichas = true;

        //Time.timeScale = 1;
    }
}
