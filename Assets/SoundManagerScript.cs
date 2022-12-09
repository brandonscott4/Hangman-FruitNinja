using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SoundManagerScript : MonoBehaviour
{
    private static AudioClip cashRegister, swordSlice, gameOverSound, gameWonSound, noCash, sliceLose;
    private static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        cashRegister = Resources.Load<AudioClip> ("cashRegister");
        swordSlice = Resources.Load<AudioClip> ("swordSlice");
        noCash = Resources.Load<AudioClip> ("nocash");
        gameOverSound = Resources.Load<AudioClip> ("gameOver");
        gameWonSound = Resources.Load<AudioClip> ("game won2");
        sliceLose = Resources.Load<AudioClip>("sliceLose");

        audioSrc = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip) {
        switch (clip) {
            case "cashRegister":
                audioSrc.PlayOneShot(cashRegister,1);
                break;

            case "swordSlice":
                audioSrc.PlayOneShot(swordSlice,1);
                break;

            case "nocash":
                audioSrc.PlayOneShot(noCash,1);
                break;

            case "gameOver":
                audioSrc.PlayOneShot(gameOverSound,1);
                break;

            case "game won2":
                audioSrc.PlayOneShot(gameWonSound,1);
                break;
            case "sliceLose":
                audioSrc.PlayOneShot(sliceLose, 1);
                break;
        }
    }
}
