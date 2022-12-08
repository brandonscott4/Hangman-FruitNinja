using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicHangman : MonoBehaviour
{
    public Sprite[] hangmanSprites;
    public int hangmanSpriteIndex = 0;
    public GameManagerScript gameManager;
    private bool isFinished; //checks if the game is finished or not 

    // Start is called before the first frame update
    void Start()
    {
        //LoadSprites();
        GetComponent<SpriteRenderer>().sprite = hangmanSprites[hangmanSpriteIndex];

    }

    //public void LoadSprites()
    //{
    //    object[] loadedSprites = Resources.LoadAll("HangmanSprite", typeof(Sprite));
    //    hangmanSprites = new Sprite[loadedSprites.Length];

    //    for (int i = 0; i < loadedSprites.Length; i++)
    //    {
    //        hangmanSprites[i] = (Sprite)loadedSprites[i];
    //    }
   // }


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
        //GetComponent<SpriteRenderer>().sprite = hangman2;

    }
}

