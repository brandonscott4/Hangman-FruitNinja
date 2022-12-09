using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowToLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Tutorials;
    // private GameObject Tuttorial2;
    // private GameObject Tuttorial3;
    // private GameObject Tuttorial4;
    private int startNumber = 0;
    private int EndNumber = 4;
    private int number;
    void Start()
    {

 
        number = startNumber;
        Tutorials[0].SetActive(true);

    }
    public void Next()
    {
        if (number < EndNumber)
        {
            Tutorials[number].SetActive(false);

            number++;

            Tutorials[number].SetActive(true);
           // Debug.Log(number);

        }
        else {
            number = 0;
                
                }
    }
  

   public void Back()
    {
        SceneManager.LoadScene(0);

    }
}

