using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject myPrefab;
    public List<GameObject> listaCartas = new List<GameObject>();
    public List<Sprite> cartasFront;
    int[] contador = { 0, 0, 0, 0, 0};
    int[] tipos = { 7, 1, 0, 9, 6 };
    int state = 1;
    int cardUp, cardUpIndex;
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
            carta_nueva.GetComponent<CardScript>().tipo = tipos[pos];
            carta_nueva.GetComponent<CardScript>().index = i;

            listaCartas.Add(carta_nueva);

            posX += 3;

            if (i == 4)
            {
                posX = -6;
                posY = -2;
            }
        }
    }

    public void ClickOnCard(int t, int index)
    {
        Debug.Log("He hecho click en la carta " + t);

        if (state == 1)
        {
            cardUp = t;
            cardUpIndex = index;
            state = 2;
        }
        else //state 2
        {
            if (t == cardUp)
            {
                Debug.Log("Pareja encontrada!!");
                listaCartas[index].SetActive(false);
                listaCartas[cardUpIndex].SetActive(false);
            }
            else
            {
                Debug.Log("No hay pareja, sigue probando");
                StartCoroutine(WaitAndPrint(index));

            }
            state = 1;
        }
    }

    IEnumerator WaitAndPrint(int i)
    {
        yield return new WaitForSeconds(2);
        listaCartas[i].GetComponent<CardScript>().Toggle();
        listaCartas[cardUpIndex].GetComponent<CardScript>().Toggle();

    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
