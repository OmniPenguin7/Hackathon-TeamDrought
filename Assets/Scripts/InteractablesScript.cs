using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class InteractablesScript : MonoBehaviour
{
    public List<string> hintItems = new List<string>();

    public GameObject NetBrokenEffect;


    public void OnItemGrabbed(string prefabName)
    {
        Debug.Log("Picked up: " + prefabName);

        hintItems.Add(prefabName);

        GameObject currentObject = GameObject.Find(prefabName);

        AudioSource currentAudioSource = currentObject.GetComponent<AudioSource>();

        Transform currentTransform = currentObject.transform;

        StartCoroutine(Wait(currentObject));

        Instantiate(NetBrokenEffect, currentTransform.position, currentTransform.rotation);

        if (currentAudioSource != null)
        {
            currentAudioSource.Play();
        }
        else
        {
            Debug.LogError("No audio source found for: " + prefabName);
        }

        if (hintItems.Contains("FlyingMachine") && hintItems.Contains("MurderBook"))
        {
            Complete();
        }
    }


    public IEnumerator Wait(GameObject)
    {
        yield return new WaitForSeconds(7f);
    }

    public void HintListComplete()
    {
        Debug.Log("You found all the clues!");
    }
}





