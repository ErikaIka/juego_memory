using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject myPrefab;
    // Start is called before the first frame update
    void Start()
    {

        for (int i= 1; i < 6; i++)
        {
            GameObject carta_nueva = Instantiate(myPrefab, new Vector3((-9 + i*3), 2, 0), Quaternion.identity);
            carta_nueva.name = ("Carta" + i);
            
        }
        for (int i = 1; i < 6; i++)
        {
            GameObject carta_nueva = Instantiate(myPrefab, new Vector3((-9 + i *3), -2, 0), Quaternion.identity);
            carta_nueva.name = ("Carta" + (i+5));

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
