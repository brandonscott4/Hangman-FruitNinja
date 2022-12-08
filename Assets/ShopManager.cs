
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ShopManager : MonoBehaviour
{

    public static int[] shopContents = new int[6];
    public int[] shopPrices = new int[] {0, 10, 20, 30, 30, 30};
    public TextMeshProUGUI experiencePointsScore;
   

    // Start is called before the first frame update
    private void Start()
    {
        experiencePointsScore = GetComponent<TextMeshProUGUI>();
    }

    public void Purchase()
    {
        //issue finding game object each time could pass btn into function
        GameObject purchaseButton = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
        //int var = Random.Range(5, 25); //random number,when you purchase the price will increase like an economy


        if (Experience_Script.xpValue >= shopPrices[purchaseButton.GetComponent<ButtonInfo>().itemID]) //
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

