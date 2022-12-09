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
        quantityText.text = ShopManager.shopContents[1].ToString();
    }

    public void TriggerInvincible()
    {
        if (!IsInvoking("ResetIsInvincible") && ShopManager.shopContents[1] > 0)
        {

            ninjaPlayer.GetComponent<Ninja_Player>().IsInvincible = true;
            trailRenderer.startColor = Color.yellow;
            Invoke("ResetIsInvincible", 5.0f);
            //update the text quanity of this power up
            //call to decrement the shop quantity
            ShopManager.shopContents[1]--;
            quantityText.text = ShopManager.shopContents[1].ToString();

        }
    }

    private void ResetIsInvincible()
    {
        ninjaPlayer.GetComponent<Ninja_Player>().IsInvincible = false;
        trailRenderer.startColor = Color.white;
    }
}
