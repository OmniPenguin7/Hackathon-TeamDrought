using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class TeleportOnGrab : MonoBehaviour
{
    [SerializeField]
    private Transform teleportDestination; // Destination to teleport the player

    private XRGrabInteractable grabInteractable; // Reference to the XRGrabInteractable component

    private void Awake()
    {
        // Get the XRGrabInteractable component on this GameObject
        grabInteractable = GetComponent<XRGrabInteractable>();

        // Ensure there's a teleport destination assigned
        if (teleportDestination == null)
        {
            Debug.LogError("Teleport destination not assigned.");
        }

        // Subscribe to the select entered event
        grabInteractable.selectEntered.AddListener(OnGrab);
    }

    private void OnDestroy()
    {
        // Unsubscribe from the event to prevent memory leaks
        grabInteractable.selectEntered.RemoveListener(OnGrab);
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        if (teleportDestination != null)
        {
            // Find the XR Rig or Player GameObject and teleport it
            Transform playerTransform = args.interactorObject.transform.root; // Assuming the XR Rig is the root of the interactor
            playerTransform.position = teleportDestination.position;
            playerTransform.rotation = teleportDestination.rotation;
        }

    }
}
