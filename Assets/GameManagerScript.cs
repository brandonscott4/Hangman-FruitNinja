using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject Spawner;
    public GameObject gameWonUI;

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


        SoundManagerScript.PlaySound("game won2");

        gameWonUI.SetActive(true);

        Spawner.SetActive(false);//disables the spawner
        Debug.Log("You Won");
    }
    public void GameOver()
    {

        SoundManagerScript.PlaySound("gameOver");
        gameOverUI.SetActive(true);

        Spawner.SetActive(false);//disables the spawner
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
