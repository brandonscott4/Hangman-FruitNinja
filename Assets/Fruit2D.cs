using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit2D : MonoBehaviour
{

    private bool canBeDead; //If we can destroy the object
    private Vector3 screen; //Position on the screen
    public GameObject splat;
    public ParticleSystem correctParticles;
    public ParticleSystem incorrectParticles;
    private float particleDuration = 1.0f;
    private char letter;
    private GameObject rngObject;
    private GameObject DynamicHangman;
    private GameObject ninjaPlayer;


    // Start is called before the first frame update
    void Start()
    {
        ninjaPlayer = GameObject.Find("Player");
        rngObject = GameObject.Find("rngWordObject");
        DynamicHangman = GameObject.Find("hangmanList");

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
       //     Instantiate(splat, transform.position, transform.rotation);

            bool isCorrect = rngObject.GetComponent<RandomWordGeneratorScript>().isLetterInRemainingLetters(letter);
            Debug.Log(letter + " - " + isCorrect);
            if (isCorrect)
            {
                SoundManagerScript.PlaySound("swordSlice");

                rngObject.GetComponent<RandomWordGeneratorScript>().handleCorrectGuess(letter);
                showCorrectParticles();
               // Experience_Script.xpValue++;


            }
            else if (rngObject.GetComponent<RandomWordGeneratorScript>().isLetterInOtherLetters(letter))
            {
                SoundManagerScript.PlaySound("sliceLose");

                if (!ninjaPlayer.GetComponent<Ninja_Player>().isInvincible)
                {
                    DynamicHangman.GetComponent<DynamicHangman>().Incrementor();
                    Experience_Script.xpValue--;
                }
                    rngObject.GetComponent<RandomWordGeneratorScript>().handleIncorrectGuess(letter);
                    showIncorrectParticles();

                
                

            }

            //else check if letter is in other letters if so remove it (we dont want user to guess wrong letter twice)


        }
        Destroy(gameObject);
        return true;

    }

    //can this be in start method?
    public void setLetter(char c)
    {
        letter = c;
    }

    private void showCorrectParticles()
    {
        ParticleSystem correctParticleInstance = Instantiate(correctParticles, transform.position, transform.rotation);
        Destroy(correctParticleInstance.gameObject, particleDuration);
    }

    private void showIncorrectParticles()
    {
        ParticleSystem incorrectParticleInstance = Instantiate(incorrectParticles, transform.position, transform.rotation);
        Destroy(incorrectParticleInstance.gameObject, particleDuration);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Box"){
            //gameObject.GetComponent<Collider2D>().isTrigger = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 20.0f, ForceMode2D.Impulse);
            //gameObject.GetComponent<Collider2D>().isTrigger = true;
            Destroy(other.gameObject, 3.0f);
        }
    }
}
