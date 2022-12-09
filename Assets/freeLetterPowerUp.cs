using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class freeLetterPowerUp : MonoBehaviour
{
    private GameObject rngObject;
    public TextMeshProUGUI quantityText;
    // Start is called before the first frame update
    void Start()
    {
        rngObject = GameObject.Find("rngWordObject");
    }

    // Update is called once per frame
    void Update()
    {
        quantityText.text = ShopManager.shopContents[2].ToString();
    }

    //triggers the power up free letter and updates its quantity
    public void triggerFreeLetter()
    {
        if(ShopManager.shopContents[2] > 0)
        {
            char freeLetter = rngObject.GetComponent<RandomWordGeneratorScript>().GetRandomRemainingLetter();
            rngObject.GetComponent<RandomWordGeneratorScript>().HandleCorrectGuess(freeLetter);
            //call to decrement the shop quantity
            ShopManager.shopContents[2]--;
            //update the text quanity of this power up
            quantityText.text = ShopManager.shopContents[2].ToString();
        }

    }
}
