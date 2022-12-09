using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicHangman : MonoBehaviour
{
    public Sprite[] hangmanSprites;
    private int hangmanSpriteIndex = 0;
    public GameManagerScript gameManager;
    private bool isFinished; //checks if the game is finished or not 

    // Start is called before the first frame update
    void Start()
    {
        //sets initial hangman sprite
        GetComponent<SpriteRenderer>().sprite = hangmanSprites[hangmanSpriteIndex];
    }

    //increments the hangman sprite index and displays relevant hangman sprite
    //checks for game over state
    public void Incrementor()
    {
        hangmanSpriteIndex++;
 
        GetComponent<SpriteRenderer>().sprite = hangmanSprites[hangmanSpriteIndex];

        if (hangmanSpriteIndex == 6 && !isFinished)
        {
            isFinished = true; //gameover function only called once
            gameManager.GameOver();
        }
    }

    //decrements the hangman sprite index and displays relevant hangman sprite
    public bool Decrementor()
    {
        if (!(hangmanSpriteIndex == 0))
        {
            hangmanSpriteIndex--;
            GetComponent<SpriteRenderer>().sprite = hangmanSprites[hangmanSpriteIndex];
            return true;
        }

        return false;
    }


    // Update is called once per frame
    void Update()
    {

    }
}

