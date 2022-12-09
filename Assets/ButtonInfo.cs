using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonInfo : MonoBehaviour
{
    // Start is called before the first frame update
    public int itemID;
    public TextMeshProUGUI quantityText;
    public TextMeshProUGUI newPriceText;
    private GameObject shopManagerObj;

    void Start()
    {
        shopManagerObj = GameObject.Find("ShopManager");
        //sets power ups price and quantity, when shop is loaded
        newPriceText.text = "Price:" + ShopManager.shopPrices[itemID].ToString() + " XP";
        quantityText.text = "You have:" + ShopManager.shopContents[itemID].ToString() + " Items";
    }

    // Update is called once per frame
    void Update()
    {


    }

}
