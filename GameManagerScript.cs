using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject myPrefab;
    public List<GameObject> listaCartas = new List<GameObject>();
    public List<Sprite> cartasFront;
    int[] contador = { 0, 0, 0, 0, 0};

    GameObject carta_nueva;

    // Start is called before the first frame update
    void Start()
    {

        float posX = -6;
        float posY = 2;

        for (int i= 0; i < 10; i++)
        {
            carta_nueva = Instantiate(myPrefab, new Vector3(posX, posY, 0), Quaternion.identity);
            carta_nueva.name = "Carta" + i;

            bool encontrado = false; //Posición adecuada
            int pos = 0;

            while (!encontrado)
            {
                pos = Random.Range(0, 5);
                if (contador[pos] < 2)
                {
                    contador[pos] += 1;
                    encontrado = true;
                }
            }

            carta_nueva.GetComponent<CardScript>().front = cartasFront[pos];
            
            listaCartas.Add(carta_nueva);

            posX += 3;

            if (i == 4)
            {
                posX = -6;
                posY = -2;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        Debug.Log("Has hecho clic en: " + carta_nueva.name);
    }
}