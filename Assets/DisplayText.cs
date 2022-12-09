using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayText : MonoBehaviour
{

    public TextMeshProUGUI wordText;
    private GameObject rngObject;

    // Start is called before the first frame update
    void Start()
    {
        rngObject = GameObject.Find("rngWordObject");
        wordText = GetComponent<TextMeshProUGUI>();

        List <char> guessArray = rngObject.GetComponent<RandomWordGeneratorScript>().Guess;
        char[] guessCharArray = guessArray.ToArray();
        wordText.text = string.Join(" ", guessCharArray); //sets the text(onscreen) to the random word
    }

    // Update is called once per frame
    void Update()
    {
        //List<char> currentGuessList = rngObject.GetComponent<RandomWordGeneratorScript>().Guess;
        //char[] currentGuessCharArray = currentGuessList.ToArray();
        //string currentGuess = new string(currentGuessCharArray);
        //if (string.Compare(guess, currentGuess) != 0){
        //    nameText.text = string.Join(" ", currentGuessCharArray);
        //}
    }

    //updates the wordText
    public void UpdateWordText(){
        List<char> currentGuessList = rngObject.GetComponent<RandomWordGeneratorScript>().Guess;
        char[] currentGuessCharArray = currentGuessList.ToArray();
        wordText.text = string.Join(" ", currentGuessCharArray);
    }

}
