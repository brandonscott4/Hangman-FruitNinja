using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject Spawner;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GameOver()
    {

        //


        //  if (GetComponent<SpriteRenderer>().sprite = HangmanSprites[7])
        //  {

        gameOverUI.SetActive(true);
        Spawner.SetActive(false);//disables the spawner
        Debug.Log("You Lose");
        // }
    }
    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //gets the current scene and resets it 
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0); //gets the current scene and resets it 
    }
}
