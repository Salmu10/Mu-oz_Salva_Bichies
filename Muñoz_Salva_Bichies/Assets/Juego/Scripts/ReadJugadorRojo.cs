using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadJugadorRojo : MonoBehaviour
{
    public static string Nombre_Jugador_Rojo;

    public void ReadStringInput(string rojo)
    {
        Nombre_Jugador_Rojo = rojo;
    }
}
