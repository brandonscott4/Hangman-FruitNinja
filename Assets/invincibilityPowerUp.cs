using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invincibilityPowerUp : MonoBehaviour
{
    private int quantity;
    private GameObject ninjaPlayer;
    private TrailRenderer trailRenderer;

    // Start is called before the first frame update
    void Start()
    {
        ninjaPlayer = GameObject.Find("Player");
        trailRenderer = ninjaPlayer.GetComponent<TrailRenderer>();
        //call data source to find quantity of power up available
        quantity = 1;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void triggerInvincible()
    {
        if (!IsInvoking("resetIsInvincible") && quantity > 0)
        {

            ninjaPlayer.GetComponent<Ninja_Player>().isInvincible = true;
            trailRenderer.startColor = Color.yellow;
            Invoke("resetIsInvincible", 5.0f);
            //update the text quanity of this power up
        }
    }

    private void resetIsInvincible()
    {
        ninjaPlayer.GetComponent<Ninja_Player>().isInvincible = false;
        trailRenderer.startColor = Color.white;
    }
}
