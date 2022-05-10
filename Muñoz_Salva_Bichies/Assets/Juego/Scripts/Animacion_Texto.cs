using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animacion_Texto : MonoBehaviour
{
    string frase = "¿Cómo se juega?\n\n" + "El equipo rojo empieza la partida. El jugador podrá mover la ficha haciendo\n" + 
        "click de manera vertical y horizontal, combinando la numeración como\n" + "quieras. Por ejemplo, si saco un 5 puedo mover 3 en vertical y 2 en\n" +
        "horizontal, o las 5 en vertical u horizontal, no puedes volver hacia atrás.\n\n" + "Para eliminar una ficha del enemigo, debes caer en su casilla y sumarás\n" +
        "un punto, cada vez que llegues a la base del enemigo, sumarás dos puntos.\n" + "Pero solo podrás llegar si sacas el número exacto y si no hay una ficha rival.\n\n" +
        "El juego termina cuando uno de los dos equipos se queda sin fichas y\n" + "ganará el jugador que más puntos tenga en su marcador.";
    public Text texto;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Reloj());
    }

    IEnumerator Reloj()
    {
        foreach (char caracter in frase)
        {
            texto.text = texto.text + caracter;
            yield return new WaitForSeconds(0.05f);
        }
    }


}
