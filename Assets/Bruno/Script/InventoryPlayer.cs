using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPlayer : MonoBehaviour{

    [SerializeField] private UI_Inventory uiIventory;
    private Inventory inventory;
    private void Awake(){
        inventory = new Inventory();
        uiIventory.SetInventory(inventory);

        ItemWorld.SpawnItemWorld(new Vector3(1,-1), new Item {itemType = Item.ItemType.Sword, amount = 1});
        ItemWorld.SpawnItemWorld(new Vector3(0,0), new Item {itemType = Item.ItemType.Sword, amount = 1});
        ItemWorld.SpawnItemWorld(new Vector3(0,-3), new Item {itemType = Item.ItemType.HealthPotion, amount = 1});
        ItemWorld.SpawnItemWorld(new Vector3(-5,0), new Item {itemType = Item.ItemType.ManaPotion, amount = 1});
    }
}
