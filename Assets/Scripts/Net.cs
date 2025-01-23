using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Net : MonoBehaviour
{
    public CrabClawControl leftClaw, RightClaw;

    public List<Net> nets;

    public GameObject NetBrokenEffect;
    public GameObject player;
    public GameObject target;
    
    //Transform currentTransform = currentObject.transform;

    public void Start()
    {
        nets = new List<Net>();
    }

    public void Update()
    {
        if (nets.Count == 5)
        {
            CrabGameComplete();
        }
        else
        {
            Debug.Log("List not complete");
        }
    }

    public void OnTriggerStay(Collider other)
    {
        //netsBroken.Add(netName);
        //GameObject currentObject = GameObject.Find(netName);
        //Transform currentTransform = currentObject.transform;
        //AudioSource currentAudioSource = currentObject.GetComponent<AudioSource>();
        if (other.tag == "CrabClaw")
        {
            Debug.Log("Claw detected");

            if (leftClaw.clawClosed || RightClaw.clawClosed)
            {
                Debug.Log("Destroying net");
                this.gameObject.SetActive(false);
                //Instantiate(NetBrokenEffect, currentTransform.position, currentTransform.rotation);
                Net newNets = new Net();
                nets.Add(newNets);            
            }

        }

        
    }

  

    public void CrabGameComplete()
    {
        Debug.Log("Crab Game Complete");
        player.transform.SetPositionAndRotation(target.transform.position, Quaternion.identity);
    }
}

