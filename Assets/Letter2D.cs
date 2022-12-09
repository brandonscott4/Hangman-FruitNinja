using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter2D : MonoBehaviour
{

    private bool canBeDead; //If we can destroy the object
    private Vector3 screen; //Position on the screen
    public ParticleSystem correctParticles;
    public ParticleSystem incorrectParticles;
    private float particleDuration = 1.0f;
    private char letter;
    private GameObject rngObject;
    private GameObject dynamicHangman;
    private GameObject ninjaPlayer;

    //properties
    public char Letter{ set{letter = value;}}


    // Start is called before the first frame update
    void Start()
    {
        ninjaPlayer = GameObject.Find("Player");
        rngObject = GameObject.Find("rngWordObject");
        dynamicHangman = GameObject.Find("hangmanList");

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
        //checks if this instance of class letter2D is a correct guess
        bool isCorrect = rngObject.GetComponent<RandomWordGeneratorScript>().IsLetterInRemainingLetters(letter);
        if (isCorrect)
        {
            SoundManagerScript.PlaySound("swordSlice");
            rngObject.GetComponent<RandomWordGeneratorScript>().HandleCorrectGuess(letter);
            ShowCorrectParticles();
            //update the xp for a correct guess
            Experience_Script.xpValue+=3;


        }
        else if (rngObject.GetComponent<RandomWordGeneratorScript>().IsLetterInOtherLetters(letter))
        {
            SoundManagerScript.PlaySound("sliceLose");

            if (!ninjaPlayer.GetComponent<Ninja_Player>().IsInvincible)
            {
                //call the incrementor function to update the hangman state
                dynamicHangman.GetComponent<DynamicHangman>().Incrementor();

                if(Experience_Script.xpValue > 0){
                    //update the xp for a incorrect guess
                    Experience_Script.xpValue--;
                }
                
            }

            rngObject.GetComponent<RandomWordGeneratorScript>().HandleIncorrectGuess(letter);
            ShowIncorrectParticles();
        }
        
        Destroy(gameObject);
        return true;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Box")
        {

            int direction = Random.Range(-50, 50);
            //This way you can go right and left

            int force = Random.Range(1200, 1400);
            //This way you can variate the force

            //gameObject.GetComponent<Collider2D>().isTrigger = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(direction, force));
            //gameObject.GetComponent<Collider2D>().isTrigger = true;

        }
    }

    //instantiates correct particles using prefab and destroys these particles after set duration
    private void ShowCorrectParticles()
    {
        ParticleSystem correctParticleInstance = Instantiate(correctParticles, transform.position, transform.rotation);
        Destroy(correctParticleInstance.gameObject, particleDuration);
    }

    //instantiates incorrect particles using prefab and destroys these particles after set duration
    private void ShowIncorrectParticles()
    {
        ParticleSystem incorrectParticleInstance = Instantiate(incorrectParticles, transform.position, transform.rotation);
        Destroy(incorrectParticleInstance.gameObject, particleDuration);
    }

}
