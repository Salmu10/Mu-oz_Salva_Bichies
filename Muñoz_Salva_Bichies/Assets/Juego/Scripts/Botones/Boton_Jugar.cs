using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boton_Jugar : MonoBehaviour
{
    public GameObject Canvas_Jugadores;
    public GameObject Canvas_Rojo;
    public SpriteRenderer Semaforo;

    public void Jugar()
    {
        Canvas_Jugadores.SetActive(false);
        Canvas_Rojo.SetActive(true);

        GameObject.FindGameObjectWithTag("Nombre_Rojo").GetComponent<Text>().text = ReadJugadorRojo.Nombre_Jugador_Rojo;
        GameObject.FindGameObjectWithTag("Nombre_Verde").GetComponent<Text>().text = ReadJugadorVerde.Nombre_Jugador_Verde;
        GameObject.FindGameObjectWithTag("Nomrbre_Player").GetComponent<Text>().text = ReadJugadorRojo.Nombre_Jugador_Rojo;
        //GameObject.FindGameObjectWithTag("Nomrbre_Player_2").GetComponent<Text>().text = ReadJugadorVerde.Nombre_Jugador_Verde;
        Semaforo.sprite = Resources.Load<Sprite>("Semaforo/Semaforo_Rojo");
    }
}
