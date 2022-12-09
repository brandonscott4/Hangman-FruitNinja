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
        if (!gameOverUI.activeSelf ) //if the gameoverscreen is NOT active and the game is NOT finished
        {
            scoreText.text = "Experience points: " + xpValue ; //if you hit gameover/ exp divides by 10

        }
        else {
            scoreText.text = "Experience points: " + xpValue ;
        }
    }

}
