using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAxeWooshSound : MonoBehaviour {

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip[] woosh_Sounds;

    void PlayWooshSound() {
        audioSource.clip = woosh_Sounds[Random.Range(0, woosh_Sounds.Length)];
        audioSource.Play();
    }

	
} // class
