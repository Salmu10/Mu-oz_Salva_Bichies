using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boton_Instrucciones : MonoBehaviour
{
    public void Instrucciones()
    {
        SceneManager.LoadScene("Como_Jugar");
    }
}
