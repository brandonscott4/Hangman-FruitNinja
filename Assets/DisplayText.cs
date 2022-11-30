using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayText : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    private GameObject rngObject;
    //public TextMeshProUGUI remainingLetters;


    // Start is called before the first frame update
    void Start()
    {
        rngObject = GameObject.Find("rngWordObject");
        nameText = GetComponent<TextMeshProUGUI>();
        nameText.text = rngObject.GetComponent<RandomWordGeneratorScript>().getRandomWord(); //sets the text(onscreen) to the random word

        //remainingLetters = GetComponent<TextMeshProUGUI>();
        // remainingLetters.text = "You have " + 10 + "remaining letters";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
