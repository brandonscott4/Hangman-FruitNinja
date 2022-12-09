using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class HowToLogic : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Tutorials;
    // private GameObject Tuttorial2;
    // private GameObject Tuttorial3;
    // private GameObject Tuttorial4;
    private int startNumber = 0;
    private int EndNumber = 3;
    private int number;
    public GameObject NextBtn;
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

            if (number == 3) {
                NextBtn.SetActive(false);

            }
        }
        else {
            NextBtn.SetActive(false);

            Tutorials[number].SetActive(false);

        }
    }
  

   public void Back()
    {
        SceneManager.LoadScene(0);

    }
}

