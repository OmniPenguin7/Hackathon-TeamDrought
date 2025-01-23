using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Net : MonoBehaviour
{
    public CrabClawControl leftClaw, RightClaw;

    private GameObject netToDestroy;

    private void Start()
    {
        netToDestroy = GetComponent<GameObject>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "CrabClaw")
        {
            if(leftClaw.clawClosed || RightClaw.clawClosed)
            {
                Destroy(netToDestroy);
            }
        }
    }
}
