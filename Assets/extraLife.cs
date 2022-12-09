using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class extraLife : MonoBehaviour
{
    private GameObject dynamicHangmanObj;
    public TextMeshProUGUI quantityText;

    // Start is called before the first frame update
    void Start()
    {
        dynamicHangmanObj = GameObject.Find("hangmanList");
    }

    // Update is called once per frame
    void Update()
    {
        quantityText.text = ShopManager.shopContents[3].ToString();
    }

    //triggers the power up extra life and updates its quantity
    public void triggerExtraLife()
    {
        if (ShopManager.shopContents[3] > 0)
        {

            if (dynamicHangmanObj.GetComponent<DynamicHangman>().Decrementor())
            {
                //call to decrement the shop quantity
                ShopManager.shopContents[3]--;
                //update the text quanity of this power up
                quantityText.text = ShopManager.shopContents[3].ToString();
            }
            
        }
    }
}
