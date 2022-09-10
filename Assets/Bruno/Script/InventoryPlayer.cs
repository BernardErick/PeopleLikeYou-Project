using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPlayer : MonoBehaviour{

    [SerializeField] private UI_Inventory uiIventory;
    private Inventory inventory;
    private void Awake(){
        inventory = new Inventory();
        uiIventory.SetInventory(inventory);
    }
}
