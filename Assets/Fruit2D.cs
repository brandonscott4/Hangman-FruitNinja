using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit2D : MonoBehaviour
{

    private bool canBeDead; //If we can destroy the object
    private Vector3 screen; //Position on the screen
    public GameObject splat;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Set screen position
        screen = Camera.main.WorldToScreenPoint(transform.position);
        //If we can die and are not on the screen
        if (canBeDead && screen.y < -20)
        {
            //Destroy
            Destroy(gameObject);
           // Experience_Script.xpValue++; //adds to the xp when objects are destroyed
        }
        //If we cant die and are on the screen
        //for the fruit to appear on screen the first time
        else if (!canBeDead && screen.y > -10)
        {
            //We can die
            canBeDead = true;
        }
    }

    public bool Hit()
    {
 
        if(gameObject.tag == "Fruit")
        {

            //Experience_Script.xpValue++; //adds to the xp when objects are destroyed
            Instantiate(splat, transform.position, transform.rotation);
        }
        Destroy(gameObject);
        return true;

    }
}
