using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI gemText;
    // Start is called before the first frame update
    void Start()
    {
        gemText = GetComponent<TextMeshProUGUI>();
    }

   public void UpdateGemText(PlayerInventory playerinv)
   {
    gemText.text = playerinv.NumberOfGems.ToString();
   }
}
