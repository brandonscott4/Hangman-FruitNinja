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
    }

    // Update is called once per frame
    void Update()
    {
        quantityText.text = ShopManager.shopContents[1].ToString();
    }

    //triggers the power up invinciblility for 5s duration and updates its quantity
    public void TriggerInvincible()
    {
        if (!IsInvoking("ResetIsInvincible") && ShopManager.shopContents[1] > 0)
        {

            ninjaPlayer.GetComponent<Ninja_Player>().IsInvincible = true;
            trailRenderer.startColor = Color.yellow; //modifys trailRenderer color to show player if power if is active
            Invoke("ResetIsInvincible", 5.0f);
            //call to decrement the shop quantity
            ShopManager.shopContents[1]--;
            //update the text quanity of this power up
            quantityText.text = ShopManager.shopContents[1].ToString();

        }
    }

    //function called 5s after invinciblility power up is activated
    //resets invincibility state and resets trailrenderer color
    private void ResetIsInvincible()
    {
        ninjaPlayer.GetComponent<Ninja_Player>().IsInvincible = false;
        trailRenderer.startColor = Color.white;
    }
}
