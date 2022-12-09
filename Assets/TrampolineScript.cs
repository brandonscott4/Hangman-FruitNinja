using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrampolineScript : MonoBehaviour
{
    public GameObject trampoline;
    public TextMeshProUGUI quantityText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        quantityText.text = ShopManager.shopContents[4].ToString();
    }

    //triggers the power up trampoline for 3s duration and updates its quantity
    public void triggerTrampoline()
    {
        if (!IsInvoking("ResetIsTrampoline") && ShopManager.shopContents[4] > 0)
        {
            trampoline.SetActive(true);
            Invoke("ResetIsTrampoline", 3.0f);
            ShopManager.shopContents[4]--;
            quantityText.text = ShopManager.shopContents[4].ToString();
        }

    }

    //function called 3s after trampoline power up is activated
    //resets trampolines active state
    private void ResetIsTrampoline()
    {        
        trampoline.SetActive(false);
    }

}

