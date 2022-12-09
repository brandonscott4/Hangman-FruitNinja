
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ShopManager : MonoBehaviour
{

    public static int[] shopContents = new int[5];
    public static int[] shopPrices = new int[] {0, 25, 30, 30, 20};
    public TextMeshProUGUI experiencePointsScore;
   

    // Start is called before the first frame update
    private void Start()
    {
        experiencePointsScore = GetComponent<TextMeshProUGUI>();
    }

    public void Purchase()
    {
        GameObject purchaseButton = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        //checks if player has enough xp to buy the power up
        if (Experience_Script.xpValue >= shopPrices[purchaseButton.GetComponent<ButtonInfo>().itemID])
        {
            SoundManagerScript.PlaySound("cashRegister");

            int itemId = purchaseButton.GetComponent<ButtonInfo>().itemID;
            Experience_Script.xpValue -= shopPrices[itemId]; //calculate new price

            //var += shopContents[itemId]; //adds a random number to increase the price by 
            shopContents[itemId]++; //increase the quantity

            //purchaseButton.GetComponent<ButtonInfo>().NewPriceText.text = "Price:" + shopPrices[2, itemId].ToString() + " XP"; //new price onscreen
            purchaseButton.GetComponent<ButtonInfo>().quantityText.text = "You have:" + shopContents[itemId].ToString() + " Items"; //new quantity onscreen , error appears here when buttoninfo script(QuantityText) is static


        }
        else {
            SoundManagerScript.PlaySound("nocash");

        }
    }
    public void Return()
    {
        SceneManager.LoadScene(0);

    }

}

