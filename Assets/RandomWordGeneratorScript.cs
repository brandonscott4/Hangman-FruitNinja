using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomWordGeneratorScript : MonoBehaviour
{
    // Start is called before the first frame update
    public string[] WordList = { "ball", "smile", "triangle" };//less than 7 letters
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI remainingLetters;
    public string randomWord;
    char[] letters;
    public RandomWordGeneratorScript rngScript;
    int count =0;
    int remain = 0; //remaining letters left 
    void Start()
    {
        // gameObject.AddComponent<Fruit2D>().Hit();
        nameText = GetComponent<TextMeshProUGUI>();
        randomWord = WordList[Random.Range(0, WordList.Length)]; //gets a random word from index 0 to numb of strings in the array


        nameText.text = randomWord; //sets the text(onscreen) to the random word
        remainingLetters = GetComponent<TextMeshProUGUI>();
        // remainingLetters.text = "You have " + 10 + "remaining letters";


        letters = randomWord.ToCharArray(0,randomWord.Length); // ['h', 'e', 'l', 'l', 'o']



    }
    //for (int i = 0; i < letters.Length; i++)
    //{


    //  if (GetComponent<Fruit2D>().Hit())
    //{
    //  Debug.Log(letters[i]);
    //int var = letters.Length - 1;
    //remainingLetters.text = "You have " + var + "remaining letters";
    //}

    //}

    // Update is called once per frame
    void Update()
    {
        // remainingLetters.text = "You have " + 10 + "remaining letters";
        //char[] charArray = randomWord.ToCharArray(); //splits the randomword into a string of letters
        //for (int i = 0; i < charArray.Length; i++)
        // {
        // Debug.Log(charArray[i]);
        // if (GetComponent<Fruit2D>().Hit()) {
        //    int var = charArray.Length - 1;
        //      remainingLetters.text = "You have " + var + "remaining letters";
        //    }
        // }

        //string  randomWord = WordList[Random.Range(0, WordList.Length)]; //gets a random word from index 0 to numb of strings in the array



    }

    public char[] getLetters()
    {
        return letters;
    }

    public void test()
    
    {
        int remian = letters[count];
        //foreach (char c in letters)


        //  Debug.Log(c.ToString());



        if (letters.Length > count)
        {
            // letters.Length--;

            int x = letters.Length-1;
            Debug.Log("you selected "+ letters[count].ToString() +" " +"you have " + x +" "+ " letters remaining ");
            count++;
             x--;

            
        }


    }
        }

    


