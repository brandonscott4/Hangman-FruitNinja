
    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.EventSystems;
public class ShopManager : MonoBehaviour
{

    public int[,] shopContents = new int[6,6];
    public TextMeshProUGUI ExperiencePointsScore;
   

    // Start is called before the first frame update
    private void Start()
    {
        ExperiencePointsScore = GetComponent<TextMeshProUGUI>();
        //ID'S
        shopContents[1,1] = 1;
        shopContents[1,2] = 2;
        shopContents[1,3] = 3;
        shopContents[1,4] = 4;
        shopContents[1,5] = 5;

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
    public void purchase()
    {
        GameObject purchaseButton = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        int var = Random.Range(5, 25); //random number,when you purchase the price will increase like an economy



        if (Experience_Script.xpValue>= shopContents[2, purchaseButton.GetComponent<ButtonInfo>().ItemID] ) //
        {
            Experience_Script.xpValue -= shopContents[2, purchaseButton.GetComponent<ButtonInfo>().ItemID]; //calculate new price 

           var += shopContents[2, purchaseButton.GetComponent<ButtonInfo>().ItemID]; //adds a random number to increase the price by 
            shopContents[3, purchaseButton.GetComponent<ButtonInfo>().ItemID]++; //increase the quantity 


            purchaseButton.GetComponent<ButtonInfo>().NewPriceText.text = shopContents[2, purchaseButton.GetComponent<ButtonInfo>().ItemID].ToString(); //new price onscreen
            purchaseButton.GetComponent<ButtonInfo>().QuantityText.text = shopContents[3, purchaseButton.GetComponent<ButtonInfo>().ItemID].ToString(); //new quantity onscreen , error appears here when buttoninfo script(QuantityText) is static
            //purchaseButton.GetComponent< ButtonInfo > ().QuantityText = ;

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

