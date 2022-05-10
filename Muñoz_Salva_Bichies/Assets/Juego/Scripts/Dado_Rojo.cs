using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Dado_Rojo : MonoBehaviour {


    // Array sprites de los lados del dado para cargar de la carpeta de Dado.
    private Sprite[] Lados_dado;

    // Reference to sprite renderer to change sprites
    private SpriteRenderer rend;

    public GameObject Canvas;

    public int Resultado_rojo = 0;

    public string dado_rojo;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        Lados_dado = Resources.LoadAll<Sprite>("Dado/");
        rend.sprite = Lados_dado[5];
    }

    private void OnMouseDown()
    {
        StartCoroutine("RollTheDice");
    }

    // Coroutine para lanzar el dado
    private IEnumerator RollTheDice()
    {
        int randomDiceSide = 0;

        // Bucle para cambiar el resultado del dado aleatoriamente
        // Antes de mostrar el lado final. 20 interacciones.
        for (int i = 0; i <= 20; i++)
        {
            // Coje un numero aleatorio entre 0 y 6 
            randomDiceSide = Random.Range(0, 6);

            // Set sprite to upper face of dice from array according to random value
            rend.sprite = Lados_dado[randomDiceSide];

            // Pausa antes de la siguiente interacción
            yield return new WaitForSeconds(0.05f);
        }

        // Tiempo de muestreo del resultado
        yield return new WaitForSeconds(1.5f);

        Ficha.resultado_dado_rojo = randomDiceSide + 1;

        dado_rojo = "" + Ficha.resultado_dado_rojo;

        // Desactivamos el canvas del dado rojo
        Canvas.SetActive(false);
        GameObject.FindGameObjectWithTag("Dado").GetComponent<Text>().text = dado_rojo;
        Ficha.activar_fichas = true;
    }
}
