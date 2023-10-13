using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
   public int NumberOfGems { get; private set; }

   public UnityEvent<PlayerInventory> onGemCollected;

   public void GemCollected()
   {
    NumberOfGems++;
    onGemCollected.Invoke(this);
   }
}
