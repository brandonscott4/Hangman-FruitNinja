using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class shopLogic : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update

    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();

    }
    public void Return()
    {
        SceneManager.LoadScene(0);

    }
    public void Experience()
    {

        scoreText.text = "Current Experience points: " + Experience_Script.xpValue;
    }
}
