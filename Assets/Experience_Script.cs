using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Experience_Script : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int xpValue= 0 ;


    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Experience points:" + xpValue*50;
    }

}
