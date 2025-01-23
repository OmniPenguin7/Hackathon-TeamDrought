using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bin : MonoBehaviour
{
    public GameObject binEffect;

    public Transform binEffectTransform;

    public List<GameObject> rubbish = new List<GameObject>(); // List to store collected items

    [SerializeField]
    private string targetTag = "Player"; // Tag of the object that should trigger the audio

    public AudioSource audioSource; // Reference to the AudioSource component
    void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object is something you want to collect
        if (other.gameObject.CompareTag("Rubbish"))
        {
            rubbish.Add(other.gameObject);
            Destroy(other.gameObject); // Destroy the object after collection

            Instantiate(binEffect, binEffectTransform.position, transform.rotation);
            Debug.Log("bin effect working");

            audioSource.Play();


            
            


        }
    }

}

//public class PlayAudioOnObjectEnter : MonoBehaviour
//{
//    [SerializeField]
//    private string targetTag = "Player"; // Tag of the object that should trigger the audio

//    public AudioSource audioSource; // Reference to the AudioSource component

//    private void Start()
//    {
//        // Get the AudioSource component
//        audioSource = GetComponent<AudioSource>();
//        if (audioSource == null)
//        {
//            Debug.LogError("No AudioSource found on this GameObject. Please add one.");
//        }
//    }

//    private void OnTriggerEnter(Collider other)
//    {
//        // Check if the object entering the trigger has the correct tag
//        if (other.CompareTag(targetTag) && audioSource != null)
//        {
//            // Play the audio
//            audioSource.Play();
//        }
//    }
//}
