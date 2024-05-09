using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource sfxSource;
    public AudioClip background;

    private void Start() 
    {
        audioSource.clip = background;
        audioSource.Play();
    }
    
}
