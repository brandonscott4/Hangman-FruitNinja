using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip cashRegister,SwordSlice,GameOverSound,GameWonSound,Hangmanbeep;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        cashRegister = Resources.Load<AudioClip> ("cashRegister");
        SwordSlice = Resources.Load<AudioClip> ("swordSlice");

        Hangmanbeep = Resources.Load<AudioClip> ("hangmanbeep");
        GameOverSound = Resources.Load<AudioClip> ("gameOver");
        //cashRegister = Resources.Load<AudioClip>("cash-register");
        GameWonSound = Resources.Load<AudioClip> ("game won2");

        audioSrc = gameObject.GetComponent<AudioSource>();



       // AudioClip cashRegister = Resources.Load("cash-register", typeof(AudioClip)) as AudioClip;
        // SwordSlice = Resources.Load<AudioClip>("sword-slice");
        //AudioClip SwordSlice = Resources.Load("sword-slice", typeof(AudioClip)) as AudioClip;
        //AudioClip Hangmanbeep = Resources.Load("hangmanbeep", typeof(AudioClip)) as AudioClip;
        //AudioClip GameOverSound = Resources.Load("game-over", typeof(AudioClip)) as AudioClip;
        //AudioClip GameWonSound = Resources.Load("game won2", typeof(AudioClip)) as AudioClip;

        //  Hangmanbeep = Resources.Load<AudioClip>("hangmanbeep");
        //  GameOverSound = Resources.Load<AudioClip>("game-over");
        //cashRegister = Resources.Load<AudioClip>("cash-register");
//        GameWonSound = Resources.Load<AudioClip>("game won2");
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
                audioSrc.PlayOneShot(SwordSlice,1);
                break;

           // case "hangmanbeep":
             //   audioSrc.PlayOneShot(Hangmanbeep,1);
               // break;


            case "gameOver":
                audioSrc.PlayOneShot(GameOverSound,1);
                break;

            case "game won2":
                audioSrc.PlayOneShot(GameWonSound,1);
                break;
        }
    }
}
