using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;

    public float footstepGabDistance = 1.0f;

    private Vector3 lastFootstepPosition;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        lastFootstepPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(lastFootstepPosition, transform.position) > footstepGabDistance)
        {
            //audioSource.pitch = Random.Range(0.8f, 1.2f);
            //int randomClip = Random.Range(0, audioClips.Length);
            //audioSource.clip = audioClips[randomClip];
            //audioSource.Play();
            //lastFootstepPosition = transform.position;
        }
    }
}
