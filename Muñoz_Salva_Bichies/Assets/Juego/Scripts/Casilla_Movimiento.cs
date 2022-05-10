using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casilla_Movimiento : MonoBehaviour
{
    public GameObject controller;

    GameObject reference = null;

    // Posiciones en el tablero
    int matrixX;
    int matrixY;

    // Si la condición es falsa: mover, si es verdadera: atacar
    public bool attack = false;
    public bool casa = false;
    public static bool turno = false;

    //public string currentPlayer = "Rojo";

    public GameObject Canvas_Rojo;
    public GameObject Canvas_Verde;

    // Sonidos
    public GameObject Sonido_casa;
    public GameObject Sonido_kill;
    public GameObject Sonido_mover;


    public int puntuacion_kill = 1;
    public int puntuacion_meta = 2;

    public static int contador_rojo = 0;
    public static int contador_verde = 0;


    public void Start()
    {
        if (attack)
        {
            // Cambiar el color de la casilla_movimiento a rojo (matar)
            gameObject.GetComponent<SpriteRenderer>().color = new Color (1.0f, 0.0f, 0.0f, 1.0f);
        }

        if (casa)
        {
            // Cambiar el color de la casilla_movimiento a azul (meta)
            gameObject.GetComponent<SpriteRenderer>().color = new Color (0.0f, 0.0f, 1.0f, 1.0f);
        }

    }

    public void OnMouseUp()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");
        
        if (attack)
        {
            GameObject cp = controller.GetComponent<Game_Controller>().GetPosition(matrixX, matrixY);

            if (turno == false)
            {
                Game_Controller.puntuacion_rojo += puntuacion_kill;
                Destroy(cp);
                NuevoSonido(Sonido_kill, new Vector3(0, 0, 0), 1f);
                contador_verde++;
                if (contador_verde == 5)
                {
                    controller.GetComponent<Game_Controller>().GameOver();
                }
            }

            if (turno == true)
            {
                Game_Controller.puntuacion_verde += puntuacion_kill;
                Destroy(cp);
                NuevoSonido(Sonido_kill, new Vector3(0, 0, 0), 1f);
                contador_rojo++;
                if (contador_rojo == 5)
                {
                    controller.GetComponent<Game_Controller>().GameOver();
                }
            }
        }

        if (casa)
        {
            //GameObject cp = controller.GetComponent<Game_Controller>().GetPosition(matrixX, matrixY);

            if (turno == false)
            {
                Game_Controller.puntuacion_rojo += puntuacion_meta;
                Destroy(reference);
                NuevoSonido(Sonido_casa, new Vector3(0, 0, 0), 1f);
                contador_rojo++;
                if (contador_rojo == 5)
                {
                    controller.GetComponent<Game_Controller>().GameOver();
                }
            }

            if (turno == true)
            {
                Game_Controller.puntuacion_verde += puntuacion_meta;
                Destroy(reference);
                NuevoSonido(Sonido_casa, new Vector3(0, 0, 0), 1f);
                contador_verde++;
                if (contador_verde == 5)
                {
                    controller.GetComponent<Game_Controller>().GameOver();
                }
            }
        }
        else
        {
            NuevoSonido(Sonido_mover, new Vector3(0, 0, 0), 1f);
        }
        

        //Set the Chesspiece's original location to be empty
        controller.GetComponent<Game_Controller>().SetPositionEmpty(reference.GetComponent<Ficha>().GetXTablero(), reference.GetComponent<Ficha>().GetYTablero());

        //Move reference chess piece to this position
        reference.GetComponent<Ficha>().SetXTablero(matrixX);
        reference.GetComponent<Ficha>().SetYTablero(matrixY);
        reference.GetComponent<Ficha>().SetCoords();

        //Update the matrix
        controller.GetComponent<Game_Controller>().SetPosition(reference);

        //NuevoSonido(Sonido_mover, new Vector3(0, 0, 0), 1f);

        // Cambiar el jugador actual
        controller.GetComponent<Game_Controller>().SiguienteTurno();

        // Destruir las casillas de movimiento incluida la misma propia
        reference.GetComponent<Ficha>().DestroyMovePlates();
    }

    public void SetCoords(int x, int y)
    {
        matrixX = x;
        matrixY = y;
    }

    public void SetReference(GameObject obj)
    {
        reference = obj;
    }

    public GameObject GetReference()
    {
        return reference;
    }

    void NuevoSonido (GameObject prefab, Vector3 posicion, float duracion = 5f)
    {
        Destroy(Instantiate(prefab, posicion, Quaternion.identity), duracion);
    }
}
