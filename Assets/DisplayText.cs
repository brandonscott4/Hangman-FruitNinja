using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayText : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    private GameObject rngObject;
    private string guess;

    // Start is called before the first frame update
    void Start()
    {
        rngObject = GameObject.Find("rngWordObject");
        nameText = GetComponent<TextMeshProUGUI>();

        List <char> guessArray = rngObject.GetComponent<RandomWordGeneratorScript>().Guess;
        char[] guessCharArray = guessArray.ToArray();
        guess = new string(guessCharArray);
        nameText.text = string.Join(" ", guessCharArray); //sets the text(onscreen) to the random word

        //remainingLetters = GetComponent<TextMeshProUGUI>();
        // remainingLetters.text = "You have " + 10 + "remaining letters";
    }

    // Update is called once per frame
    void Update()
    {
        List<char> currentGuessList = rngObject.GetComponent<RandomWordGeneratorScript>().Guess;
        char[] currentGuessCharArray = currentGuessList.ToArray();
        string currentGuess = new string(currentGuessCharArray);
        if (string.Compare(guess, currentGuess) != 0){
            //nameText.text = new string (currentGuessList.ToArray());
            nameText.text = string.Join(" ", currentGuessCharArray);
        }
    }
}
