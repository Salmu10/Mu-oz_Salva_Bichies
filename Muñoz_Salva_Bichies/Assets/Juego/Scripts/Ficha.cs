using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ficha : MonoBehaviour
{
    public GameObject controller;
    public GameObject casilla_movimiento;

    // Posiciones
    private int xTablero = -1;
    private int yTablero = -1;

    // Variables para seguir los movimientos de jugador "Rojo" y jugador "Verde"
    private string player;

    // Referencias para cualquier ficha del tablero
    public Sprite ficha_roja_1, ficha_roja_2, ficha_roja_3, ficha_roja_4, ficha_roja_5;
    public Sprite ficha_verde_1, ficha_verde_2, ficha_verde_3, ficha_verde_4, ficha_verde_5;

    // Cojemos los resultados de los dos dados
    public static int resultado_dado_rojo = 1;
    public static int resultado_dado_verde = 1;

    public static bool activar_fichas = false;
    public static bool ficha_roja_casa = false;
    public static bool ficha_verde_casa = false;

    public static bool Casa_Rojo = false;
    public static bool Casa_Verde = false;

    // Sonidos
    public GameObject Sonido_seleccion;

    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");

        //Configuración de las coordenadas
        SetCoords();

        switch (this.name)
        {
            case "ficha_roja_1": this.GetComponent<SpriteRenderer>().sprite = ficha_roja_1; player = "Rojo"; break;
            case "ficha_roja_2": this.GetComponent<SpriteRenderer>().sprite = ficha_roja_2; player = "Rojo"; break;
            case "ficha_roja_3": this.GetComponent<SpriteRenderer>().sprite = ficha_roja_3; player = "Rojo"; break;
            case "ficha_roja_4": this.GetComponent<SpriteRenderer>().sprite = ficha_roja_4; player = "Rojo"; break;
            case "ficha_roja_5": this.GetComponent<SpriteRenderer>().sprite = ficha_roja_5; player = "Rojo"; break;

            case "ficha_verde_1": this.GetComponent<SpriteRenderer>().sprite = ficha_verde_1; player = "Verde"; break;
            case "ficha_verde_2": this.GetComponent<SpriteRenderer>().sprite = ficha_verde_2; player = "Verde"; break;
            case "ficha_verde_3": this.GetComponent<SpriteRenderer>().sprite = ficha_verde_3; player = "Verde"; break;
            case "ficha_verde_4": this.GetComponent<SpriteRenderer>().sprite = ficha_verde_4; player = "Verde"; break;
            case "ficha_verde_5": this.GetComponent<SpriteRenderer>().sprite = ficha_verde_5; player = "Verde"; break;
        }
    }

    public void SetCoords()
    {
        float x = xTablero;
        float y = yTablero;

        x *= 0.931f;
        y *= 1.38f;

        x += -8.38f;
        y += -3.67f;

        this.transform.position = new Vector3(x, y, -1.0f);
    }

    public int GetXTablero()
    {
        return xTablero;
    }

    public int GetYTablero()
    {
        return yTablero;
    }

    public void SetXTablero(int x)
    {
        xTablero = x;
    }

    public void SetYTablero(int y)
    {
        yTablero = y;
    }

    private void OnMouseUp()
    {
        if (activar_fichas == true)
        {
            if (controller.GetComponent<Game_Controller>().GetCurrentPlayer() == player)
            {
                NuevoSonido(Sonido_seleccion, new Vector3(0, 0, 0), 1f);

                //Remove all moveplates relating to previously selected piece
                DestroyMovePlates();

                //Crear nuevas casillas de movimiento
                InitiateMovePlates();
            }
        }
    }

    public void DestroyMovePlates()
    {
        //Destroy old MovePlates
        GameObject[] movePlates = GameObject.FindGameObjectsWithTag("Casilla_Movimiento");
        for (int i = 0; i < movePlates.Length; i++)
        {
            Destroy(movePlates[i]); //Be careful with this function "Destroy" it is asynchronous
        }
    }

    public void InitiateMovePlates()
    {
        switch (this.name)
        {
            case "ficha_roja_1":

                if (resultado_dado_rojo == 1)
                {
                    Num_1_Rojo();
                }
                if (resultado_dado_rojo == 2)
                {
                    Num_2_Rojo();
                }
                if (resultado_dado_rojo == 3)
                {
                    Num_3_Rojo();
                }
                if (resultado_dado_rojo == 4)
                {
                    Num_4_Rojo();
                }
                if (resultado_dado_rojo == 5)
                {
                    Num_5_Rojo();
                }
                if (resultado_dado_rojo == 6)
                {
                    Num_6_Rojo();
                }
                break;
            case "ficha_roja_2":
                if (resultado_dado_rojo == 1)
                {
                    Num_1_Rojo();
                }
                if (resultado_dado_rojo == 2)
                {
                    Num_2_Rojo();
                }
                if (resultado_dado_rojo == 3)
                {
                    Num_3_Rojo();
                }
                if (resultado_dado_rojo == 4)
                {
                    Num_4_Rojo();
                }
                if (resultado_dado_rojo == 5)
                {
                    Num_5_Rojo();
                }
                if (resultado_dado_rojo == 6)
                {
                    Num_6_Rojo();
                }
                break;
            case "ficha_roja_3":
                if (resultado_dado_rojo == 1)
                {
                    Num_1_Rojo();
                }
                if (resultado_dado_rojo == 2)
                {
                    Num_2_Rojo();
                }
                if (resultado_dado_rojo == 3)
                {
                    Num_3_Rojo();
                }
                if (resultado_dado_rojo == 4)
                {
                    Num_4_Rojo();
                }
                if (resultado_dado_rojo == 5)
                {
                    Num_5_Rojo();
                }
                if (resultado_dado_rojo == 6)
                {
                    Num_6_Rojo();
                }
                break;
            case "ficha_roja_4":
                if (resultado_dado_rojo == 1)
                {
                    Num_1_Rojo();
                }
                if (resultado_dado_rojo == 2)
                {
                    Num_2_Rojo();
                }
                if (resultado_dado_rojo == 3)
                {
                    Num_3_Rojo();
                }
                if (resultado_dado_rojo == 4)
                {
                    Num_4_Rojo();
                }
                if (resultado_dado_rojo == 5)
                {
                    Num_5_Rojo();
                }
                if (resultado_dado_rojo == 6)
                {
                    Num_6_Rojo();
                }
                break;
            case "ficha_roja_5":
                if (resultado_dado_rojo == 1)
                {
                    Num_1_Rojo();
                }
                if (resultado_dado_rojo == 2)
                {
                    Num_2_Rojo();
                }
                if (resultado_dado_rojo == 3)
                {
                    Num_3_Rojo();
                }
                if (resultado_dado_rojo == 4)
                {
                    Num_4_Rojo();
                }
                if (resultado_dado_rojo == 5)
                {
                    Num_5_Rojo();
                }
                if (resultado_dado_rojo == 6)
                {
                    Num_6_Rojo();
                }
                break;
            case "ficha_verde_1":
                if (resultado_dado_verde == 1)
                {
                    Num_1_Verde();
                }
                if (resultado_dado_verde == 2)
                {
                    Num_2_Verde();
                }
                if (resultado_dado_verde == 3)
                {
                    Num_3_Verde();
                }
                if (resultado_dado_verde == 4)
                {
                    Num_4_Verde();
                }
                if (resultado_dado_verde == 5)
                {
                    Num_5_Verde();
                }
                if (resultado_dado_verde == 6)
                {
                    Num_6_Verde();
                }
                break;
            case "ficha_verde_2":
                if (resultado_dado_verde == 1)
                {
                    Num_1_Verde();
                }
                if (resultado_dado_verde == 2)
                {
                    Num_2_Verde();
                }
                if (resultado_dado_verde == 3)
                {
                    Num_3_Verde();
                }
                if (resultado_dado_verde == 4)
                {
                    Num_4_Verde();
                }
                if (resultado_dado_verde == 5)
                {
                    Num_5_Verde();
                }
                if (resultado_dado_verde == 6)
                {
                    Num_6_Verde();
                }
                break;
            case "ficha_verde_3":
                if (resultado_dado_verde == 1)
                {
                    Num_1_Verde();
                }
                if (resultado_dado_verde == 2)
                {
                    Num_2_Verde();
                }
                if (resultado_dado_verde == 3)
                {
                    Num_3_Verde();
                }
                if (resultado_dado_verde == 4)
                {
                    Num_4_Verde();
                }
                if (resultado_dado_verde == 5)
                {
                    Num_5_Verde();
                }
                if (resultado_dado_verde == 6)
                {
                    Num_6_Verde();
                }
                break;
            case "ficha_verde_4":
                if (resultado_dado_verde == 1)
                {
                    Num_1_Verde();
                }
                if (resultado_dado_verde == 2)
                {
                    Num_2_Verde();
                }
                if (resultado_dado_verde == 3)
                {
                    Num_3_Verde();
                }
                if (resultado_dado_verde == 4)
                {
                    Num_4_Verde();
                }
                if (resultado_dado_verde == 5)
                {
                    Num_5_Verde();
                }
                if (resultado_dado_verde == 6)
                {
                    Num_6_Verde();
                }
                break;
            case "ficha_verde_5":
                if (resultado_dado_verde == 1)
                {
                    Num_1_Verde();
                }
                if (resultado_dado_verde == 2)
                {
                    Num_2_Verde();
                }
                if (resultado_dado_verde == 3)
                {
                    Num_3_Verde();
                }
                if (resultado_dado_verde == 4)
                {
                    Num_4_Verde();
                }
                if (resultado_dado_verde == 5)
                {
                    Num_5_Verde();
                }
                if (resultado_dado_verde == 6)
                {
                    Num_6_Verde();
                }
                break;
        }
    }

    public void PointCasillaMovimiento(int x, int y)
    {
        Game_Controller sc = controller.GetComponent<Game_Controller>();

        if (sc.PositionOnTablero(x, y))
        {
            GameObject cp = sc.GetPosition(x, y);

            if (cp == null && player == "Rojo" && x != 18)
            {
                SpawnCasillaMovimiento(x, y);
            }
            else if (cp == null && player == "Verde" && x != 0)
            {
                SpawnCasillaMovimiento(x, y);
            }
            else if (cp == null && player == "Rojo" && x == 18)
            {
                CasillaMovimientoCasaSpawn(x, y);
            }
            else if (cp == null && player == "Verde" && x == 0)
            {
                CasillaMovimientoCasaSpawn(x, y);
            }
            else if (cp.GetComponent<Ficha>().player != player && x != 0 && x != 18)
            {
                CasillaMovimientoAttackSpawn(x, y);
            }
            /*
            else if (cp != null)
            {
                Debug.Log("Hey");
                
                //StartCoroutine("NoPuedeMover");
            }
            */
        }
    }

    public void Num_6_Rojo()
    {
        PointCasillaMovimiento(xTablero + 0, yTablero + 6);
        PointCasillaMovimiento(xTablero + 1, yTablero + 5);
        PointCasillaMovimiento(xTablero + 2, yTablero + 4);
        PointCasillaMovimiento(xTablero + 3, yTablero + 3);
        PointCasillaMovimiento(xTablero + 4, yTablero + 2);
        PointCasillaMovimiento(xTablero + 5, yTablero + 1);
        PointCasillaMovimiento(xTablero + 6, yTablero - 0);
        PointCasillaMovimiento(xTablero + 1, yTablero - 5);
        PointCasillaMovimiento(xTablero + 2, yTablero - 4);
        PointCasillaMovimiento(xTablero + 3, yTablero - 3);
        PointCasillaMovimiento(xTablero + 4, yTablero - 2);
        PointCasillaMovimiento(xTablero + 5, yTablero - 1);
        PointCasillaMovimiento(xTablero + 6, yTablero - 0);
    }
    public void Num_6_Verde()
    {
        PointCasillaMovimiento(xTablero - 0, yTablero + 6);
        PointCasillaMovimiento(xTablero - 1, yTablero + 5);
        PointCasillaMovimiento(xTablero - 2, yTablero + 4);
        PointCasillaMovimiento(xTablero - 3, yTablero + 3);
        PointCasillaMovimiento(xTablero - 4, yTablero + 2);
        PointCasillaMovimiento(xTablero - 5, yTablero + 1);
        PointCasillaMovimiento(xTablero - 6, yTablero - 0);
        PointCasillaMovimiento(xTablero - 1, yTablero - 5);
        PointCasillaMovimiento(xTablero - 2, yTablero - 4);
        PointCasillaMovimiento(xTablero - 3, yTablero - 3);
        PointCasillaMovimiento(xTablero - 4, yTablero - 2);
        PointCasillaMovimiento(xTablero - 5, yTablero - 1);
        PointCasillaMovimiento(xTablero - 6, yTablero - 0);
    }

    public void Num_5_Rojo()
    {
        PointCasillaMovimiento(xTablero + 0, yTablero + 5);
        PointCasillaMovimiento(xTablero + 1, yTablero + 4);
        PointCasillaMovimiento(xTablero + 2, yTablero + 3);
        PointCasillaMovimiento(xTablero + 3, yTablero + 2);
        PointCasillaMovimiento(xTablero + 4, yTablero + 1);
        PointCasillaMovimiento(xTablero + 5, yTablero + 0);
        PointCasillaMovimiento(xTablero + 0, yTablero - 5);
        PointCasillaMovimiento(xTablero + 1, yTablero - 4);
        PointCasillaMovimiento(xTablero + 2, yTablero - 3);
        PointCasillaMovimiento(xTablero + 3, yTablero - 2);
        PointCasillaMovimiento(xTablero + 4, yTablero - 1);
    }

    public void Num_5_Verde()
    {
        PointCasillaMovimiento(xTablero - 0, yTablero + 5);
        PointCasillaMovimiento(xTablero - 1, yTablero + 4);
        PointCasillaMovimiento(xTablero - 2, yTablero + 3);
        PointCasillaMovimiento(xTablero - 3, yTablero + 2);
        PointCasillaMovimiento(xTablero - 4, yTablero + 1);
        PointCasillaMovimiento(xTablero - 5, yTablero + 0);
        PointCasillaMovimiento(xTablero - 0, yTablero - 5);
        PointCasillaMovimiento(xTablero - 1, yTablero - 4);
        PointCasillaMovimiento(xTablero - 2, yTablero - 3);
        PointCasillaMovimiento(xTablero - 3, yTablero - 2);
        PointCasillaMovimiento(xTablero - 4, yTablero - 1);
    }

    public void Num_4_Rojo()
    {
        PointCasillaMovimiento(xTablero + 0, yTablero + 4);
        PointCasillaMovimiento(xTablero + 1, yTablero + 3);
        PointCasillaMovimiento(xTablero + 2, yTablero + 2);
        PointCasillaMovimiento(xTablero + 3, yTablero + 1);
        PointCasillaMovimiento(xTablero + 4, yTablero + 0);
        PointCasillaMovimiento(xTablero + 0, yTablero - 4);
        PointCasillaMovimiento(xTablero + 1, yTablero - 3);
        PointCasillaMovimiento(xTablero + 2, yTablero - 2);
        PointCasillaMovimiento(xTablero + 3, yTablero - 1);
    }

    public void Num_4_Verde()
    {
        PointCasillaMovimiento(xTablero - 0, yTablero + 4);
        PointCasillaMovimiento(xTablero - 1, yTablero + 3);
        PointCasillaMovimiento(xTablero - 2, yTablero + 2);
        PointCasillaMovimiento(xTablero - 3, yTablero + 1);
        PointCasillaMovimiento(xTablero - 4, yTablero + 0);
        PointCasillaMovimiento(xTablero - 0, yTablero - 4);
        PointCasillaMovimiento(xTablero - 1, yTablero - 3);
        PointCasillaMovimiento(xTablero - 2, yTablero - 2);
        PointCasillaMovimiento(xTablero - 3, yTablero - 1);
    }

    public void Num_3_Rojo()
    {
        PointCasillaMovimiento(xTablero + 0, yTablero + 3);
        PointCasillaMovimiento(xTablero + 1, yTablero + 2);
        PointCasillaMovimiento(xTablero + 2, yTablero + 1);
        PointCasillaMovimiento(xTablero + 3, yTablero + 0);
        PointCasillaMovimiento(xTablero + 0, yTablero - 3);
        PointCasillaMovimiento(xTablero + 1, yTablero - 2);
        PointCasillaMovimiento(xTablero + 2, yTablero - 1);
    }

    public void Num_3_Verde()
    {
        PointCasillaMovimiento(xTablero - 0, yTablero + 3);
        PointCasillaMovimiento(xTablero - 1, yTablero + 2);
        PointCasillaMovimiento(xTablero - 2, yTablero + 1);
        PointCasillaMovimiento(xTablero - 3, yTablero + 0);
        PointCasillaMovimiento(xTablero - 0, yTablero - 3);
        PointCasillaMovimiento(xTablero - 1, yTablero - 2);
        PointCasillaMovimiento(xTablero - 2, yTablero - 1);
    }

    public void Num_2_Rojo()
    {
        PointCasillaMovimiento(xTablero + 0, yTablero + 2);
        PointCasillaMovimiento(xTablero + 1, yTablero + 1);
        PointCasillaMovimiento(xTablero + 2, yTablero + 0);
        PointCasillaMovimiento(xTablero + 0, yTablero - 2);
        PointCasillaMovimiento(xTablero + 1, yTablero - 1);
    }

    public void Num_2_Verde()
    {
        PointCasillaMovimiento(xTablero - 0, yTablero + 2);
        PointCasillaMovimiento(xTablero - 1, yTablero + 1);
        PointCasillaMovimiento(xTablero - 2, yTablero + 0);
        PointCasillaMovimiento(xTablero - 0, yTablero - 2);
        PointCasillaMovimiento(xTablero - 1, yTablero - 1);
    }

    public void Num_1_Rojo()
    {
        PointCasillaMovimiento(xTablero + 0, yTablero + 1);
        PointCasillaMovimiento(xTablero + 1, yTablero + 0);
        PointCasillaMovimiento(xTablero + 0, yTablero - 1);
    }

    public void Num_1_Verde()
    {
        PointCasillaMovimiento(xTablero - 0, yTablero + 1);
        PointCasillaMovimiento(xTablero - 1, yTablero + 0);
        PointCasillaMovimiento(xTablero - 0, yTablero - 1);
    }

    public void SpawnCasillaMovimiento(int matrixX, int matrixY)
    {
        //Cambiar los valores del tablero por xy coordenadas
        float x = matrixX;
        float y = matrixY;

        x *= 0.931f;
        y *= 1.38f;

        x += -8.38f;
        y += -3.67f;

        //Set actual unity values
        GameObject cm = Instantiate(casilla_movimiento, new Vector3(x, y, -3.0f), Quaternion.identity);

        Casilla_Movimiento cmScript = cm.GetComponent<Casilla_Movimiento>();
        cmScript.SetReference(gameObject);
        cmScript.SetCoords(matrixX, matrixY);
    }

    public void CasillaMovimientoAttackSpawn(int matrixX, int matrixY)
    {
        //Cambiar los valores del tablero por xy coordenadas
        float x = matrixX;
        float y = matrixY;

        x *= 0.931f;
        y *= 1.38f;

        x += -8.38f;
        y += -3.67f;

        //Set actual unity values
        GameObject cm = Instantiate(casilla_movimiento, new Vector3(x, y, -3.0f), Quaternion.identity);

        Casilla_Movimiento cmScript = cm.GetComponent<Casilla_Movimiento>();
        cmScript.attack = true;
        cmScript.SetReference(gameObject);
        cmScript.SetCoords(matrixX, matrixY);
    }


    public void CasillaMovimientoCasaSpawn(int matrixX, int matrixY)
    {
        //Cambiar los valores del tablero por xy coordenadas
        float x = matrixX;
        float y = matrixY;

        x *= 0.931f;
        y *= 1.38f;

        x += -8.38f;
        y += -3.67f;

        //Set actual unity values
        GameObject cm = Instantiate(casilla_movimiento, new Vector3(x, y, -3.0f), Quaternion.identity);

        Casilla_Movimiento cmScript = cm.GetComponent<Casilla_Movimiento>();
        cmScript.casa = true;
        cmScript.SetReference(gameObject);
        cmScript.SetCoords(matrixX, matrixY);
    }

    void NuevoSonido(GameObject prefab, Vector3 posicion, float duracion = 5f)
    {
        Destroy(Instantiate(prefab, posicion, Quaternion.identity), duracion);
    }

    /*
    private IEnumerator NoPuedeMover()
    {
        yield return new WaitForSeconds(0.5f);
        controller.GetComponent<Game_Controller>().SiguienteTurno();
    }
    */
}

