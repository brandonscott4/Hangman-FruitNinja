using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject Spawner;
    public GameObject gameWonUI;

    public Button invincibilityBtn;
    public Button freeLetterBtn;
    public Button extraLifeBtn;

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
        Spawner.SetActive(false);//disables the spawner

        //list of letters still on screen when game has been won
        GameObject[] letters = GameObject.FindGameObjectsWithTag("Fruit");

        //if there are letters on screen set all their colliders to false
        if(letters.Length != 0){
              foreach (GameObject letter in letters)
            {
                letter.GetComponent<Collider2D>().enabled = false;
            }
        }

        invincibilityBtn.interactable = false;
        freeLetterBtn.interactable = false;
        extraLifeBtn.interactable = false;

        Debug.Log("You Won");
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
        SoundManagerScript.PlaySound("gameOver");
        Spawner.SetActive(false);//disables the spawner

        //list of letters still on screen when game is over
        GameObject[] letters = GameObject.FindGameObjectsWithTag("Fruit");

        //if there are letters on screen set all their colliders to false
        if(letters.Length != 0){
              foreach (GameObject letter in letters)
            {
                letter.GetComponent<Collider2D>().enabled = false;
            }
        }
       

        invincibilityBtn.interactable = false;
        freeLetterBtn.interactable = false;
        extraLifeBtn.interactable = false;
        Debug.Log("You Lose");
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //gets the current scene and resets it 
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0); //gets the current scene and resets it 
    }
   
}
