using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class freeLetterPowerUp : MonoBehaviour
{
    private int quantity;
    private GameObject rngObject;
    // Start is called before the first frame update
    void Start()
    {
        rngObject = GameObject.Find("rngWordObject");
        //call data source to find quantity of power up available
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void triggerFreeLetter()
    {
        char freeLetter = rngObject.GetComponent<RandomWordGeneratorScript>().getRandomRemainingLetter();
        rngObject.GetComponent<RandomWordGeneratorScript>().handleCorrectGuess(freeLetter);
        //update the text quanity of this power up
    }
}
