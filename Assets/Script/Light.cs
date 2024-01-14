using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSFlashlight : MonoBehaviour
{
    public Light flashlight; // Fener ýþýðý
    public KeyCode toggleKey = KeyCode.F; // Feneri açma/kapatma tuþu

    void Update()
    {
        // Feneri açma/kapatma iþlemi
        if (Input.GetKeyDown(toggleKey))
        {
            flashlight.enabled = !flashlight.enabled;
        }

        // Feneri karakterin baþýna taþýma
        flashlight.transform.position = transform.position + transform.forward * 1.0f; // Ayarlamalarý ihtiyacýnýza göre deðiþtirin
        flashlight.transform.rotation = Quaternion.LookRotation(transform.forward, transform.up);
    }
}
