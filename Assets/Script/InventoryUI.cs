using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI oyuncakText;

    // Start is called before the first frame update
    void Start()
    {
        oyuncakText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateOyuncakText(PlayerInventory playerInventory)
    {
        oyuncakText.text = playerInventory.NumberOfOyuncak.ToString();
    }
}
