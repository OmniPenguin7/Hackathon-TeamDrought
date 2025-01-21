using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PirateGameScript : MonoBehaviour
{

    public List<string> rubbishCollected = new List<string>();

    public GameObject RubbishCollectedEffect;
    public void OnItemGrabbed (string prefabName)
    {
        Debug.Log("Collected: " + prefabName);

        rubbishCollected.Add(prefabName);

        GameObject currentObject = GameObject.Find(prefabName);

        AudioSource currentAudioSource = currentObject.GetComponent<AudioSource>();

        Transform currentTransform = currentObject.transform;

        Instantiate(RubbishCollectedEffect, currentTransform.position, currentTransform.rotation);

        if (currentAudioSource != null)
        {
            currentAudioSource.Play();
        }
        else
        {
            Debug.LogError("No audio source found for: " + prefabName);
        }

        if (rubbishCollected.Contains(""))
        {
            RubbishCollectionComplete();
        }
    }

    public void RubbishCollectionComplete()
    {
        Debug.Log("You have collected all the rubbish!");
    }


    public void OnTriggerEnter(Collider other)
    {
        GameObject currentObject = GameObject.Find(prefabName);

        if (other.tag == "Rubbish")
        {
            StartCoroutine(DestroyWait(currentObject));
        }
    }

    public IEnumerator DestroyWait (GameObject itemToDestroy)
    {
        yield return new WaitForSeconds(1f);
        Destroy(itemToDestroy);
    }

  

}
