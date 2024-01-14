using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerInventory : MonoBehaviour
{
   public int NumberOfOyuncak {get; private set;}

   public UnityEvent<PlayerInventory> OnOyuncakCollected; 
   public void OyuncakCollected()
   {
        NumberOfOyuncak++;
        OnOyuncakCollected.Invoke(this);
   }
}
