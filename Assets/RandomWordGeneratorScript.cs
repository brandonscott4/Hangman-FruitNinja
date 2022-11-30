using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class RandomWordGeneratorScript : MonoBehaviour
{
    // Start is called before the first frame update
    private string[] WordList = { "ball", "smile", "triangle" };//less than 7 letters
    private string randomWord;
    private List<char> remaining_letters;
    private List<char> other_letters;
    //maybe dont need this as can create an instance in another script
    //public RandomWordGeneratorScript rngScript;
    int count =0;
    //int remain = 0; //remaining letters left
    void Awake()
    {
        // gameObject.AddComponent<Fruit2D>().Hit();
        randomWord = WordList[Random.Range(0, WordList.Length)]; //gets a random word from index 0 to numb of strings in the array
        Debug.Log(randomWord);

        char[] char_letters = randomWord.ToCharArray(0,randomWord.Length); // ['h', 'e', 'l', 'l', 'o']
        // letters left to guess, as a List so letters can be removed
        remaining_letters = char_letters.ToList();

        other_letters = setOtherLetters();



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

    public List<char> getRemainingLetters()
    {
        return remaining_letters;
    }

    public List<char> getOtherLetters()
    {
        return other_letters;
    }

    public char getRandomOtherLetter()
    {
        return other_letters[Random.Range(0, other_letters.Count)];
    }

    public char getRandomRemainingLetter()
    {
        return remaining_letters[Random.Range(0, remaining_letters.Count)];
    }

    public bool isLetterInRemainingLetters(char c)
    {
        return remaining_letters.Contains(c);
    }

    public string getRandomWord()
    {
        return randomWord;
    }


    public void test()
    
    {
        //int remian = remaining_letters[count];
        //foreach (char c in letters)


        //  Debug.Log(c.ToString());



        if (remaining_letters.Count > count)
        {
            // letters.Length--;

            int x = remaining_letters.Count-1;
            Debug.Log("you selected "+ remaining_letters[count].ToString() +" " +"you have " + x +" "+ " letters remaining ");
            count++;
             x--;

            
        }


    }

    //sets list that contains all letters that arent in the current word
    public List<char> setOtherLetters()
    {
        List<char> other_letters = new List<char>();
        for (char c = 'a'; c <= 'z'; c++)
        {
            if (!remaining_letters.Contains(c))
                other_letters.Add(c);
        }

        return other_letters;

    }

    //adds a letter to other letters list, if that letter is not to be guessed still
    public void addToOtherLetters(char c)
    {
        //check as could be multiple occurences of a letter
        if (!remaining_letters.Contains(c))
        {
            other_letters.Add(c);
        }
            
    }

    public void removeLetterFromRemaning(char c)
    {
        // not sure whether to use index or char cos there could be more than one occurence
    }
}

    


