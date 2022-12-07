using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicHangman : MonoBehaviour
{
    public Sprite hangman1;
    //public Sprite hangman2, hangman3, hangman4, hangman5, hangman6, hangman7;
    // public Texture2D[] hangmen;
    public Sprite[] HangmanSprites;
    public int n = 0;
    //private GameObject brgObject;
    public GameManagerScript gameManager;
    private bool isFinished; //checks if the game is finished or not 
    private GameObject Fruit2D;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = hangman1;
        LoadSprites();

      //  brgObject = GameObject.Find("Background");

    }
    public void LoadSprites()
    {


        object[] loadedSprites = Resources.LoadAll("HangmanSprite", typeof(Sprite));
        HangmanSprites = new Sprite[loadedSprites.Length];


        for (int i = 0; i < loadedSprites.Length; i++)
        {
            HangmanSprites[i] = (Sprite)loadedSprites[i];

        }





    }


    public void Incrementor()
    {
        {
            n++;
            Debug.Log("incrementor "+ n);
 
           
                GetComponent<SpriteRenderer>().sprite = HangmanSprites[n];
            SoundManagerScript.PlaySound("hangmanbeep");
             //   Debug.Log("test");

                // if (HangmanSprites[6])
            
            if (n == 6 && !isFinished)
            {
                isFinished = true; //gameover function only called once
                gameManager.GameOver();
                Debug.Log("bye");



            }
        }

    }

    public bool decrementor()
    {
        if (!(n == 0))
        {
            n--;
            GetComponent<SpriteRenderer>().sprite = HangmanSprites[n];
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

