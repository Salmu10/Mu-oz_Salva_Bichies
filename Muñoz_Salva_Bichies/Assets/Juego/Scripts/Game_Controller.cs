using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Controller : MonoBehaviour
{
    public GameObject ficha;

    // Posiciones y equipos para cada pieza
    private GameObject[,] positions = new GameObject[19, 5];
    private GameObject[] jugadorRojo = new GameObject[5];
    private GameObject[] jugadorVerde = new GameObject[5];

    public static string currentPlayer = "Rojo";

    public GameObject Canvas_Rojo;
    public GameObject Canvas_Verde;

    //public int puntuacion_rojo = 0;
    public static int puntuacion_rojo = 0;
    public static int puntuacion_verde = 0;

    public int marcador_rojo = 0;
    public int marcador_verde = 0;

    public SpriteRenderer Semaforo;

    void Start()
    {
        puntuacion_rojo = 0;
        puntuacion_verde = 0;
        marcador_rojo = 0;
        marcador_verde = 0;

        jugadorRojo = new GameObject[] { Create("ficha_roja_1", 0, 0), Create("ficha_roja_2", 0, 1), Create("ficha_roja_3", 0, 2), Create("ficha_roja_4", 0, 3), Create("ficha_roja_5", 0, 4) };
        jugadorVerde = new GameObject[] { Create("ficha_verde_1", 18, 0), Create("ficha_verde_2", 18, 1), Create("ficha_verde_3", 18, 2), Create("ficha_verde_4", 18, 3), Create("ficha_verde_5", 18, 4) };

        // Indicar todas las posiciones de las fichas en la tabla
        for (int i = 0; i < jugadorRojo.Length; i++)
        {
            SetPosition(jugadorRojo[i]);
            SetPosition(jugadorVerde[i]);
        }
    }

    public GameObject Create(string name, int x, int y)
    {
        GameObject obj = Instantiate(ficha, new Vector3(0, 0, -1), Quaternion.identity);
        Ficha fc = obj.GetComponent<Ficha>();
        fc.name = name;
        fc.SetXTablero(x);
        fc.SetYTablero(y);
        fc.Activate();
        return obj;
    }

    public void SetPosition(GameObject obj)
    {
        Ficha fc = obj.GetComponent<Ficha>();

        positions[fc.GetXTablero(), fc.GetYTablero()] = obj;

    }

    public void SetPositionEmpty(int x, int y)
    {
        positions[x, y] = null;
    }

    public GameObject GetPosition(int x, int y)
    {
        return positions[x, y];
    }

    public bool PositionOnTablero(int x, int y)
    {
        if (x < 0 || y < 0 || x >= positions.GetLength(0) || y >= positions.GetLength(1))
        {
            return false;
        } 
            
        return true;
    }

    public string GetCurrentPlayer()
    {
        return currentPlayer;
    }

    public void SiguienteTurno()
    {
        if (currentPlayer == "Rojo")
        {
            Canvas_Verde.SetActive(true);
            GameObject.FindGameObjectWithTag("Nomrbre_Player_2").GetComponent<Text>().text = ReadJugadorVerde.Nombre_Jugador_Verde;
            Semaforo.sprite = Resources.Load<Sprite>("Semaforo/Semaforo_Verde");
            Ficha.activar_fichas = false;
            currentPlayer = "Verde";
            Casilla_Movimiento.turno = true;
        }
        else
        {
            Canvas_Rojo.SetActive(true);
            Semaforo.sprite = Resources.Load<Sprite>("Semaforo/Semaforo_Rojo");
            Ficha.activar_fichas = false;
            currentPlayer = "Rojo";
            Casilla_Movimiento.turno = false;
        }
    }

    public void Update()
    {
        marcador_rojo = puntuacion_rojo;
        marcador_verde = puntuacion_verde;

    }

    public void GameOver()
    {
        if(marcador_rojo > marcador_verde)
        {
            SceneManager.LoadScene("Victoria_Rojo");
        }

        if (marcador_rojo > marcador_verde)
        {
            SceneManager.LoadScene("Victoria_Verde");
        }

        if (marcador_rojo == marcador_verde)
        {
            SceneManager.LoadScene("Empate");
        }
    }
}
