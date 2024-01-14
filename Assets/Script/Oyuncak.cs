using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oyuncak : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory != null)
        {
            playerInventory.OyuncakCollected();
            gameObject.SetActive(false);
        }
    }
}
