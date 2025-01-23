using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Net : MonoBehaviour
{
    public CrabClawControl leftClaw, RightClaw;





    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "CrabClaw")
        {
            Debug.Log("Claw detected");

            if (leftClaw.clawClosed || RightClaw.clawClosed)
            {
                Debug.Log("Destroying net");
                this.gameObject.SetActive(false);
            }
        }
    }
}
