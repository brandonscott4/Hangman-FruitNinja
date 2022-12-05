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
    public GameObject ShopManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NewPriceText.text = "Price:" + ShopManager.GetComponent<ShopManager>().shopContents[2, ItemID].ToString()+ " XP";
        QuantityText.text = "You have:" + ShopManager.GetComponent<ShopManager>().shopContents[3, ItemID].ToString()+ " Items";

    }
}
