using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerinv = other.GetComponent<PlayerInventory>();

        if (playerinv != null)
        {
            playerinv.GemCollected();
            gameObject.SetActive(false);
        }
    }
}
