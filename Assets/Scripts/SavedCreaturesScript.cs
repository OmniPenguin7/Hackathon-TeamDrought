using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SavedCreaturesScript : MonoBehaviour
{
    public List<string> savedCreatures = new List<string>();

    public GameObject NetBrokenEffect;


    public void OnItemGrabbed(string prefabName)
    {
        Debug.Log("Saved: " + prefabName);

        savedCreatures.Add(prefabName);

        GameObject currentObject = GameObject.Find(prefabName);

        AudioSource currentAudioSource = currentObject.GetComponent<AudioSource>();

        Transform currentTransform = currentObject.transform;

        //StartCoroutine(Wait(currentObject));

        Instantiate(NetBrokenEffect, currentTransform.position, currentTransform.rotation);

        if (currentAudioSource != null)
        {
            currentAudioSource.Play();
        }
        else
        {
            Debug.LogError("No audio source found for: " + prefabName);
        }

        if (savedCreatures.Contains("") && savedCreatures.Contains(""))
        {
            SavedCreaturesComplete();
        }
    }


    //public IEnumerator Wait(GameObject)
    //{
    //    yield return new WaitForSeconds(7f);
    //}

    public void SavedCreaturesComplete()
    {
        Debug.Log("You have saved all my friends!");
    }
}





