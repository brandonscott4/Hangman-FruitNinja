using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class RandomWordGeneratorScript : MonoBehaviour
{
    private string[] wordList = { "ball", "smile", "triangle", "apple", "yellow", "river", "bucket", "cake", "chalk", "feather", "garden", "house", "language", "letter", "library", "minute", "orange", "plant", "rhythm", "trouble", "umbrella", "watch", "window"};//less than 9 letters
    private string randomWord;
    private List<char> remainingLetters; //remaining letters in word to be guessed
    private List<char> otherLetters; // letters that arent in word and havent been guessed yet
    private List<char> guess = new List<char>();
    private List<char> guessProgress;
    private bool isFinished; //checks if the game is finished or not 
    public GameManagerScript gameManager;
    public GameObject wordText;

    //properties
    public List<char> Guess{ get{return guess;}}


    void Awake()
    {
        randomWord = wordList[Random.Range(0, wordList.Length)]; //gets a random word from index 0 to numb of strings in the array
        SetGuess();
        char[] splitRandomWord = randomWord.ToCharArray(0,randomWord.Length); // "hello" to ['h', 'e', 'l', 'l', 'o']
        // letters left to guess, as a List so letters can be removed
        remainingLetters = splitRandomWord.ToList();
        guessProgress = splitRandomWord.ToList();
        otherLetters = SetOtherLetters();
    }

    // Update is called once per frame
    void Update()
    {

        if (remainingLetters.Count == 0 && !isFinished)
        {
            isFinished = true; //gameover function only called once
            gameManager.GameWon();
        }
    }

    public char GetRandomOtherLetter()
    {
        return otherLetters[Random.Range(0, otherLetters.Count)];
    }

    public char GetRandomRemainingLetter()
    {
        return remainingLetters[Random.Range(0, remainingLetters.Count)];
    }

    public bool IsLetterInRemainingLetters(char letter)
    {
        return remainingLetters.Contains(letter);
    }

    public bool IsLetterInOtherLetters(char letter)
    {
        return otherLetters.Contains(letter);
    }

    //sets guess list as all _ initially, run once in start
    private void SetGuess()
    {
        for (int i = 0; i < randomWord.Length; i++)
        {
            guess.Add('_');
        }
    }

    //sets list that contains all letters that arent in the current word, run once in start
    public List<char> SetOtherLetters()
    {
        List<char> otherLetters = new List<char>();
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            if (!remainingLetters.Contains(letter))
                otherLetters.Add(letter);
        }

        return otherLetters;

    }

    //update guess progress and remove letter from remaining letters to guess
    public void HandleCorrectGuess(char letter)
    {
        int indexOfLetter = guessProgress.IndexOf(letter);
        guess[indexOfLetter] = letter;
        guessProgress[indexOfLetter] = '_';
        remainingLetters.Remove(letter);
        wordText.GetComponent<DisplayText>().UpdateWordText();
    }

    //removes a letter from other letters list
    public void HandleIncorrectGuess(char letter)
    {
        otherLetters.Remove(letter);
    }

    

}

    


