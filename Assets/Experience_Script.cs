using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Experience_Script : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private GameObject gameOver;
    public static int xpValue= 0;
    public GameObject gameOverUI;
    private bool isFinished;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        //  if (gameOver.GetComponent<GameManagerScript>().GameOver()) { //need to find a way to penalise players when they lose(maybe divide their final exp by 10 ) 
        //bool result = gameOverUI.SetActive(true);

        if (!gameOverUI.activeSelf ) //if the gameoverscreen is NOT active and the game is NOT finished
        {
            //isFinished = false; //gameover function only called once
            scoreText.text = "Experience points: " + xpValue ; //if you hit gameover/ exp divides by 10

        }
        else {

         //   isFinished = true; //gameover function only called once

            scoreText.text = "Experience points: " + xpValue ;
        }
    }

}
