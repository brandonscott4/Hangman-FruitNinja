using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class freeLetterPowerUp : MonoBehaviour
{
    private int quantity;
    private GameObject rngObject;
    public TextMeshProUGUI quantityText;
    // Start is called before the first frame update
    void Start()
    {
        rngObject = GameObject.Find("rngWordObject");
        //quantityText = GetComponent<TextMeshProUGUI>();
        //quantityText.text = ShopManager.shopContents[3, 2].ToString();
        //call data source to find quantity of power up available
    }

    // Update is called once per frame
    void Update()
    {
        quantityText.text = ShopManager.shopContents[2].ToString();
    }

    public void triggerFreeLetter()
    {
        if(ShopManager.shopContents[2] > 0)
        {
            char freeLetter = rngObject.GetComponent<RandomWordGeneratorScript>().GetRandomRemainingLetter();
            rngObject.GetComponent<RandomWordGeneratorScript>().HandleCorrectGuess(freeLetter);
            //update the text quanity of this power up
            //call to decrement the shop quantity
            ShopManager.shopContents[2]--;
            quantityText.text = ShopManager.shopContents[2].ToString();
        }

    }
}
