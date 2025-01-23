using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayAudioOnTrigger : MonoBehaviour
{
    // Audio source to play the audio
    private AudioSource audioSource;

    // Initialize the audio source
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("No AudioSource component found on this GameObject.");
        }
    }

    // Triggered when another collider enters the box collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering object has the "Player" tag
        if (other.CompareTag("Player") && audioSource != null)
        {
            audioSource.Play();
        }
    }
}
