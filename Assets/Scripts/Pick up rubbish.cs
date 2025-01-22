using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubberRing : MonoBehaviour
{

    public AudioClip clip;
    public AudioSource audioSource;
    public Input register;
    public float volume;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisonEnter(Collision collsion)
    {
        audioSource.Play();
    }




}
