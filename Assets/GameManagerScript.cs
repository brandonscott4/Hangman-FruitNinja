using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject spawner;
    public GameObject gameWonUI;    

    public GameObject rngObject;

    public Button invincibilityBtn;
    public Button freeLetterBtn;
    public Button extraLifeBtn;
    public Button trampolineBtn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void GameWon()
    {
        gameWonUI.SetActive(true);
        SoundManagerScript.PlaySound("game won2");
        HandleGameEnd();
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
        gameOverUI.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = "Word was: "+ rngObject.GetComponent<RandomWordGeneratorScript>().RandomWord;
        SoundManagerScript.PlaySound("gameOver");
        HandleGameEnd();
    }
    
    private void HandleGameEnd()
    {
        spawner.SetActive(false);//disables the spawner

        //list of letters still on screen when game is over
        GameObject[] letters = GameObject.FindGameObjectsWithTag("Letter");

        //if there are letters on screen set all their colliders to false
        if(letters.Length != 0){
              foreach (GameObject letter in letters)
            {
                letter.GetComponent<Collider2D>().enabled = false;
            }
        }
       
        //disables powerup buttons
        invincibilityBtn.interactable = false;
        freeLetterBtn.interactable = false;
        extraLifeBtn.interactable = false;
        trampolineBtn.interactable = false;
    }

    public void Restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //gets the current scene and resets it 
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0); //loads main menu scene
    }
   
}
