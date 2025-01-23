using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Net : MonoBehaviour
{
    public CrabClawControl leftClaw, RightClaw;

    public List<string> netsBroken = new List<string>();

    public GameObject NetBrokenEffect;
    public GameObject player;
    public GameObject target;
    
    Transform currentTransform = currentObject.transform;


    public void OnTriggerStay(Collider other)
    {
        netsBroken.Add(netName);
        GameObject currentObject = GameObject.Find(netName);
        Transform currentTransform = currentObject.transform;
        AudioSource currentAudioSource = currentObject.GetComponent<AudioSource>();
        if (other.tag == "CrabClaw")
        {
            Debug.Log("Claw detected");

            if (leftClaw.clawClosed || RightClaw.clawClosed)
            {
                Debug.Log("Destroying net");
                this.gameObject.SetActive(false);
                Instantiate(NetBrokenEffect, currentTransform.position, currentTransform.rotation);
            }
        }
    }

    //    public void OnNetBroken(string netName)
    //    {

    //        if (currentAudioSource != null)
    //        {
    //            currentAudioSource.Play();
    //        }
    //        else
    //        {
    //            Debug.LogError("No audio source found for: " + netName);
    //        }

    //        if (netName.Contains("SharkNet") && netName.Contains("KrillNet") && netName.Contains("TurtleNet") && netName.Contains("FishNet"))
    //        {
    //            CrabGameComplete();
    //        }


    //    }

    //    public void CrabGameComplete()
    //    {
    //        Debug.Log("Crab Game Complete");
    //        player.transform.SetPositionAndRotation(target.transform.position, Quaternion.identity);
    //    }
    //}
}
