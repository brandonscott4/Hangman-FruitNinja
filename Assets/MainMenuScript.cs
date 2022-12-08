using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public GameObject jsonManagerObj;

    void Start()
    {
        //jsonManagerObj = GameObject.Find("jsonManagerObj");

        //if shopContents has just been initialised
        if (ShopManager.shopContents[0] == 0)
        {
            int[] shopArrayJson = jsonManagerObj.GetComponent<jsonManager>().loadFromJSON();

            for (int i=0; i<6; i++)
            {
                ShopManager.shopContents[i] = shopArrayJson[i];
            }
        }
    }
    public void playGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);//getting the active scene,getting the build index, then adding 1 (going to the next in the list) 
    }
    public void HowTo()
    {
      
    }
    public void Shop()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        //save game
        jsonManagerObj.GetComponent<jsonManager>().saveToJSON();
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
            Application.Quit();

    }
}
