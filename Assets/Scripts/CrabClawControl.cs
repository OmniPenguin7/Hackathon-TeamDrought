using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class CrabClawControl : MonoBehaviour
{
    public InputActionReference crabTriggerReference;

    public Animator crabClawAnimator;


    // Update is called once per frame
    public void Update()
    {
        float crabTriggerValue = crabTriggerReference.action.ReadValue<float>();
        if (crabTriggerValue > 0f)
        {
            Debug.Log("Button press detected");
            crabClawAnimator.SetInteger("TriggerPressed", 1);
        }
        else 
        {
            crabClawAnimator.SetInteger("TriggerPressed", 0);
        }
    }
}
