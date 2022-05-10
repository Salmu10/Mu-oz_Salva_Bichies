using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlMarcador : MonoBehaviour
{
    //public Casilla_Movimiento casillaMovimiento;

    public Game_Controller gameController;

    public Text Marcador_rojo;

    public Text Marcador_verde;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Marcador_rojo.text = " " + gameController.marcador_rojo;
        Marcador_verde.text = " " + gameController.marcador_verde;
    }
}
