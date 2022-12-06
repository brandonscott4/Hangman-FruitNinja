using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonInfo : MonoBehaviour
{
    // Start is called before the first frame update
    public int ItemID;
    public TextMeshProUGUI QuantityText;
    public TextMeshProUGUI NewPriceText;
    //public GameObject ShopManagerObj;
    //public static int qtyInvincibility = 0;
    //public static int qtyFreeLetter = 0;
    void Start()
    {
        //this runs everytime the shop is loaded
        NewPriceText.text = "Price:" + ShopManager.shopContents[2, ItemID].ToString() + " XP";
        QuantityText.text = "You have:" + ShopManager.shopContents[3, ItemID].ToString() + " Items";
    }

    // Update is called once per frame
    void Update()
    {


    }

}
