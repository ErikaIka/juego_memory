using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    SpriteRenderer myRenderer;
    public Sprite front;
    public Sprite back;
    bool faceUp = false;
    GameObject myGameManager;
    public int tipo;

    private void Awake()
    {
        myRenderer = GetComponent<SpriteRenderer>();
        myGameManager = GameObject.FindGameObjectWithTag("GameController");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        //Debug.Log("He hecho clic en la carta" + name);
        myGameManager.GetComponent<GameManagerScript>().ClickOnCard(tipo);

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
