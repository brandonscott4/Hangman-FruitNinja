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

    public void triggerExtraLife()
    {
        if (ShopManager.shopContents[3] > 0)
        {

            if (dynamicHangmanObj.GetComponent<DynamicHangman>().decrementor())
            {
                //update the text quanity of this power up
                //call to decrement the shop quantity
                ShopManager.shopContents[3]--;
                quantityText.text = ShopManager.shopContents[3].ToString();
            }
            
        }
    }
}
