using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    SpriteRenderer myRenderer;
    public Sprite front;
    public Sprite back;
    bool faceUp = false;

    private void Awake()
    {
        myRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("He hecho clic en la carta" + name);

        if (!faceUp)
        {
            myRenderer.sprite = front;
            
        }
        else
        {
            myRenderer.sprite = back;
        }

        faceUp = !faceUp;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
