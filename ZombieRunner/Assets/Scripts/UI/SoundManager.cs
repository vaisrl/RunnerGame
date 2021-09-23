using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip playerHurt, shot, zombieDeath, goingIntoWallofHands, reload;
    public static AudioSource audioSource;

    private void Start()
    {
        playerHurt = Resources.Load<AudioClip>("playerHurt");
        shot = Resources.Load<AudioClip>("shot");
        zombieDeath = Resources.Load<AudioClip>("zombieDeath");
        goingIntoWallofHands = Resources.Load<AudioClip>("goingIntoWallofHands");
        reload = Resources.Load<AudioClip>("reload");

        audioSource = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "playerHurt":
                audioSource.PlayOneShot(playerHurt);
                break;
            case "shot":
                audioSource.PlayOneShot(shot);
                break;
            case "zombieDeath":
                audioSource.PlayOneShot(zombieDeath);
                break;
            case "goingIntoWallofHands":
                audioSource.PlayOneShot(goingIntoWallofHands);
                break;
            case "reload":
                audioSource.PlayOneShot(reload);
                break;
        }
    }


}
