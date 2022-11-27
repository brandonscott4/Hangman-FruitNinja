using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomWordGeneratorScript : MonoBehaviour
{
    // Start is called before the first frame update
    public  string[] WordList = {"ball","smile","triangle"};//less than 7 letters
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI remainingLetters;
    public string randomWord;
    void Start()
    {

         nameText = GetComponent<TextMeshProUGUI>();
        string randomWord= WordList[Random.Range(0,WordList.Length)]; //gets a random word from index 0 to numb of strings in the array
        //print(randomWord);
        //Debug.Log(randomWord);

         nameText.text =  randomWord ; //sets the text(onscreen) to the random word



    }

    // Update is called once per frame
    void Update()
    { 
        remainingLetters= GetComponent<TextMeshProUGUI>();

        char[] charArray = randomWord.ToCharArray(); //splits the randomword into a string of letters
        for (int i = 0; i < charArray.Length; i++)
        {
            Debug.Log(charArray[i]);
            if (GetComponent<Fruit2D>().Hit()) {
                int var = charArray.Length - 1;
                remainingLetters.text = "You have " + var + "remaining letters";
            }
        }
    }
}
