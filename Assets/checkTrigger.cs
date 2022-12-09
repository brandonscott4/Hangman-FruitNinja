using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkTrigger : MonoBehaviour
{
    GameObject[] letters;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        letters = GameObject.FindGameObjectsWithTag("Fruit");

        if (other.tag=="Fruit")
        {

            //(assuming trigger is off(collision enabled) )if it passess through fruit, it goes enables collsion for the next script 

            //collider.isTrigger = true;
            //other.GetComponent<Collider2D>().isTrigger = !other.GetComponent<Collider2D>().isTrigger;

            other.GetComponent<Collider>().enabled = !other.GetComponent<Collider>().enabled;
            //gameObject.GetComponent(Collider).isTrigger = false;
            Debug.Log("hi");



        }
        else
        {
            Debug.Log("lol");
        }
    } 
}