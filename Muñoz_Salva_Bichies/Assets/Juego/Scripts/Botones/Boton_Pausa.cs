using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton_Pausa : MonoBehaviour
{

    public GameObject Canvas_Pausa;

    public void Pausa()
    {
        Canvas_Pausa.SetActive(true);

        Ficha.activar_fichas = false;

        //Time.timeScale = 0;
    }
}
