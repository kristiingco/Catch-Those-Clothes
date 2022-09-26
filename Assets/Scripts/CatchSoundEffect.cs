using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchSoundEffect : MonoBehaviour {
    public static AudioClip catchSound;
    static AudioSource audioSrc;

    void Start() {
        catchSound = Resources.Load<AudioClip>("catch");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip) {
        switch(clip) {
            case "catch":
                audioSrc.PlayOneShot(catchSound);
                break;
        }
    }
}
