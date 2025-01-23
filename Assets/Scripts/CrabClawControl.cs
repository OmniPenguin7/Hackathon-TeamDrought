using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CrabClawControl : MonoBehaviour
{
    public string leftRightRef;

    public InputActionReference crabTriggerReference;

    public Animator crabClawAnimator;

    public bool clawClosed;


    // Update is called once per frame
    public void Update()
    {
        float crabTriggerValue = crabTriggerReference.action.ReadValue<float>();
        if (crabTriggerValue > 0f)
        {
            Debug.Log("Button press detected");
            crabClawAnimator.SetInteger("TriggerPressed", 1);
            clawClosed = true;
        }
        else 
        {
            crabClawAnimator.SetInteger("TriggerPressed", 0);
            clawClosed = false;
        }
    }
}
