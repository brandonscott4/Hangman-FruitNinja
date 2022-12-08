using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class RandomWordGeneratorScript : MonoBehaviour
{
    private string[] WordList = { "ball", "smile", "triangle", "apple", "yellow", "river", "bucket", "cake", "chalk", "feather", "garden", "house", "language", "letter", "library", "minute", "orange", "plant", "rhythm", "trouble", "umbrella", "watch", "window"};//less than 9 letters
    private string randomWord;
    private List<char> remaining_letters;
    private List<char> other_letters;
    private List<char> guess = new List<char>();
    private List<char> guessProgress;
    private bool isFinished; //checks if the game is finished or not 
    public GameManagerScript gameManager;

    //properties
    public List<char> Guess{ get{return guess;}}


    void Awake()
    {
        randomWord = WordList[Random.Range(0, WordList.Length)]; //gets a random word from index 0 to numb of strings in the array
        setGuess();
        char[] splitRandomWord = randomWord.ToCharArray(0,randomWord.Length); // "hello" to ['h', 'e', 'l', 'l', 'o']
        // letters left to guess, as a List so letters can be removed
        remaining_letters = splitRandomWord.ToList();
        guessProgress = splitRandomWord.ToList();
        other_letters = setOtherLetters();
    }

    // Update is called once per frame
    void Update()
    {

        if (remaining_letters.Count == 0 && !isFinished)
        {
            isFinished = true; //gameover function only called once
            gameManager.GameWon();
        }
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

    public bool isLetterInOtherLetters(char c)
    {
        return other_letters.Contains(c);
    }

    //sets guess list as all _ initially, run once in start
    private void setGuess()
    {
        for (int i = 0; i < randomWord.Length; i++)
        {
            guess.Add('_');
        }
    }

    //sets list that contains all letters that arent in the current word, run once in start
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

    //update guess progress and remove letter from remaining letters to guess
    public void handleCorrectGuess(char c)
    {
        int indexOfLetter = guessProgress.IndexOf(c);
        guess[indexOfLetter] = c;
        guessProgress[indexOfLetter] = '_';
        remaining_letters.Remove(c);
    }

    //removes a letter from other letters list
    public void handleIncorrectGuess(char c)
    {
        other_letters.Remove(c);


    }

    

}

    


