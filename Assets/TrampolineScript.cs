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
      //  trampoline = GameObject.Find("Trampoline");
       // Debug.Log(trampoline);
    }

    // Update is called once per frame
    void Update()
    {
        quantityText.text = ShopManager.shopContents[4].ToString();
    }

    public void triggerTrampoline()
    {
        if (!IsInvoking("ResetIsTrampoline") && ShopManager.shopContents[4] > 0)
        {
          //  trampoline.GetComponent<Fruit2D>().IsBouncy = true;

            trampoline.SetActive(true);
            Invoke("ResetIsTrampoline", 3.0f);
            //Destroy(trampoline.gameObject, 3.0f);

            ShopManager.shopContents[4]--;
                quantityText.text = ShopManager.shopContents[4].ToString();
            }

        }
    private void ResetIsTrampoline()
    {
        //   ninjaPlayer.GetComponent<Ninja_Player>().isInvincible = false;
  //      trampoline.GetComponent<Fruit2D>().IsBouncy = false;
        
        trampoline.SetActive(false);
    }
}

