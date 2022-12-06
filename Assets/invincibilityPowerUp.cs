using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class invincibilityPowerUp : MonoBehaviour
{
    private GameObject ninjaPlayer;
    private TrailRenderer trailRenderer;
    public TextMeshProUGUI quantityText;

    // Start is called before the first frame update
    void Start()
    {
        ninjaPlayer = GameObject.Find("Player");
        trailRenderer = ninjaPlayer.GetComponent<TrailRenderer>();
        //quantityText = GetComponent<TextMeshProUGUI>();
        //quantityText.text = ShopManager.shopContents[3, 1].ToString();
    }

    // Update is called once per frame
    void Update()
    {
        quantityText.text = ShopManager.shopContents[3, 1].ToString();
    }

    public void triggerInvincible()
    {
        if (!IsInvoking("resetIsInvincible") && ShopManager.shopContents[3, 1] > 0)
        {

            ninjaPlayer.GetComponent<Ninja_Player>().isInvincible = true;
            trailRenderer.startColor = Color.yellow;
            Invoke("resetIsInvincible", 5.0f);
            //update the text quanity of this power up
            //call to decrement the shop quantity
            ShopManager.shopContents[3, 1]--;
            Debug.Log(ShopManager.shopContents[3, 1].ToString());
            quantityText.text = ShopManager.shopContents[3, 1].ToString();

        }
    }

    private void resetIsInvincible()
    {
        ninjaPlayer.GetComponent<Ninja_Player>().isInvincible = false;
        trailRenderer.startColor = Color.white;
    }
}
