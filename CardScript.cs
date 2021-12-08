using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    public Sprite imagen; //Imagen a mostrar

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = imagen;
        transform.position = new Vector3(-1, 3, 01);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
