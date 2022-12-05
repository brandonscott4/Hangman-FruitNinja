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
    //private string randomWord;
    //public TextMeshProUGUI remainingLetters;


    // Start is called before the first frame update
    void Start()
    {
        rngObject = GameObject.Find("rngWordObject");
        //randomWord = rngObject.GetComponent<RandomWordGeneratorScript>().getRandomWord();
        nameText = GetComponent<TextMeshProUGUI>();

        List <char> guess_array = rngObject.GetComponent<RandomWordGeneratorScript>().getGuess();
        char[] guess_charArray = guess_array.ToArray();
        guess = new string(guess_charArray);
        nameText.text = string.Join(" ", guess_charArray); //sets the text(onscreen) to the random word

        //remainingLetters = GetComponent<TextMeshProUGUI>();
        // remainingLetters.text = "You have " + 10 + "remaining letters";
    }

    // Update is called once per frame
    void Update()
    {
        List<char> currentGuessList = rngObject.GetComponent<RandomWordGeneratorScript>().getGuess();
        char[] currentGuess_charArray = currentGuessList.ToArray();
        string currentGuess = new string(currentGuess_charArray);
        if (string.Compare(guess, currentGuess) != 0){
            //nameText.text = new string (currentGuessList.ToArray());
            nameText.text = string.Join(" ", currentGuess_charArray);
        }
    }
}
