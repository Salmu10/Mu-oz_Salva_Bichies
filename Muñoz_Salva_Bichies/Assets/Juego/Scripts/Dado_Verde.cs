using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Dado_Verde : MonoBehaviour {

    // Array sprites de los lados del dado para cargar de la carpeta de Dado.
    private Sprite[] Lados_dado;

    // Reference to sprite renderer to change sprites
    private SpriteRenderer rend;

    public GameObject Canvas;

    public int Resultado_verde = 0;

    public string dado_verde;

    private void Start () 
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
            // Pick up random value from 0 to 6 (All inclusive)
            randomDiceSide = Random.Range(0, 6);

            // Set sprite to upper face of dice from array according to random value
            rend.sprite = Lados_dado[randomDiceSide];

            // Pausa antes de la siguiente interacción
            yield return new WaitForSeconds(0.05f);
        }

        // Tiempo de muestreo del resultado
        yield return new WaitForSeconds(1.5f);

        Ficha.resultado_dado_verde = randomDiceSide + 1;

        dado_verde = "" + Ficha.resultado_dado_verde;

        // Desactivamos el canvas del dado verde
        Canvas.SetActive(false);
        GameObject.FindGameObjectWithTag("Dado").GetComponent<Text>().text = dado_verde;
        Ficha.activar_fichas = true;
    }
}
