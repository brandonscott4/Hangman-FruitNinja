using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public void playGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//getting the active scene,getting the build index, then adding 1 (going to the next in the list) 
    }
    public void HowTo()
    {
      
    }
    public void Shop()
    {
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
