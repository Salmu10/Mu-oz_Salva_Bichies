using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton_Reiniciar : MonoBehaviour
{
    public void Reiniciar()
    {
        SceneManager.LoadScene("Game");
        Game_Controller.currentPlayer = "Rojo";
    }
}
