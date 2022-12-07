
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ShopManager : MonoBehaviour
{

    public static int[,] shopContents = new int[6,6];
    public TextMeshProUGUI ExperiencePointsScore;
   

    // Start is called before the first frame update
    private void Awake()
    {
        Debug.Log("Called Start for shopManager");
        //Debug.Log(shopContents[3, 1]);

        //if shopContents has just been initialised
        if (shopContents[1, 1] == 0)
        {
            Debug.Log("Run inital array mapping");
            //ID'S
            shopContents[1, 1] = 1;
            shopContents[1, 2] = 2;
            shopContents[1, 3] = 3;
            shopContents[1, 4] = 4;
            shopContents[1, 5] = 5;

            //PRICE
            shopContents[2, 1] = 10;
            shopContents[2, 2] = 20;
            shopContents[2, 3] = 30;
            shopContents[2, 4] = 40;
            shopContents[2, 5] = 50;

            //Quantity
            shopContents[3, 1] = 0;
            shopContents[3, 2] = 0;
            shopContents[3, 3] = 0;
            shopContents[3, 4] = 0;
            shopContents[3, 5] = 0;
        }

        ExperiencePointsScore = GetComponent<TextMeshProUGUI>();

        //could get access to all buttons in start
    }
    public void purchase()
    {
        //issue finding game object each time could pass btn into function
        GameObject purchaseButton = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        int var = Random.Range(5, 25); //random number,when you purchase the price will increase like an economy


        if (Experience_Script.xpValue >= shopContents[2, purchaseButton.GetComponent<ButtonInfo>().ItemID]) //
        {
            SoundManagerScript.PlaySound("cashRegister");

            int itemId = purchaseButton.GetComponent<ButtonInfo>().ItemID;
            Experience_Script.xpValue -= shopContents[2, itemId]; //calculate new price 

            var += shopContents[2, itemId]; //adds a random number to increase the price by 
            shopContents[3, itemId]++; //increase the quantity

            purchaseButton.GetComponent<ButtonInfo>().NewPriceText.text = "Price:" + shopContents[2, itemId].ToString() + " XP"; //new price onscreen
            purchaseButton.GetComponent<ButtonInfo>().QuantityText.text = "You have:" + shopContents[3, itemId].ToString() + " Items"; //new quantity onscreen , error appears here when buttoninfo script(QuantityText) is static


        }
        else {
            SoundManagerScript.PlaySound("nocash");

        }
    }
    public void Return()
    {
        SceneManager.LoadScene(0);

    }
    public void Experience()
    {

        ExperiencePointsScore.text = "Current Experience points: " + Experience_Script.xpValue;
    }

}

