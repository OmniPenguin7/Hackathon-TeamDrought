using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bin : MonoBehaviour
{
    public List<GameObject> rubbish = new List<GameObject>(); // List to store collected items
    void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object is something you want to collect
        if (other.gameObject.CompareTag("Rubbish"))
        {
            rubbish.Add(other.gameObject);
            Destroy(other.gameObject); // Destroy the object after collection
        }
    }
}
