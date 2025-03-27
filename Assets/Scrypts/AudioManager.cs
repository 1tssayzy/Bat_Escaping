using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("---Audio---")]
    [SerializeField] AudioSource audioSource;
    [Header("---Audio Clips---")]
    public AudioClip background;
    private void Start()
    {
        audioSource.clip = background;
        audioSource.Play();
    }
    
}
