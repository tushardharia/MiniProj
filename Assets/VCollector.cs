using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VCollector : MonoBehaviour
{
    public bool enter = false;

    void OnTriggerEnter2D (Collider2D vase)
    {
        if (vase.CompareTag("Player"))
        {
            pickup();
        }
    }

    void pickup()
    {
        if (enter == false)
        {
            Debug.Log("Entered!");
            enter = true;
        }
        else
        {
            Debug.Log("Already Entered");
        }
    }
}
