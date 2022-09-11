using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPlayer : MonoBehaviour{

    [SerializeField] private UI_Inventory uiIventory;
    private Inventory inventory;
    private void Awake(){
        inventory = new Inventory(UseItem);
        uiIventory.SetInventory(inventory);

        ItemWorld.SpawnItemWorld(new Vector3(4f,-3.5f), new Item {itemType = Item.ItemType.Sword, amount = 1});
        ItemWorld.SpawnItemWorld(new Vector3(-3f,-4.5f), new Item {itemType = Item.ItemType.Sword, amount = 1});
        ItemWorld.SpawnItemWorld(new Vector3(-4f,-3f), new Item {itemType = Item.ItemType.HealthPotion, amount = 10});
        ItemWorld.SpawnItemWorld(new Vector3(-5f,-4.5f), new Item {itemType = Item.ItemType.ManaPotion, amount = 1});
        ItemWorld.SpawnItemWorld(new Vector3(-5f,-4.5f), new Item {itemType = Item.ItemType.HealthPotion, amount = 1});
        ItemWorld.SpawnItemWorld(new Vector3(-5f,-4.5f), new Item {itemType = Item.ItemType.ManaPotion, amount = 1});
    }

    private void OnTriggerEnter2D(Collider2D collider){
        ItemWorld itemWorld = collider.GetComponent<ItemWorld>();
        if(itemWorld != null){
            inventory.AddItem(itemWorld.GetItem());
            itemWorld.DestroySelf();
        }
    }

    private void UseItem(Item item){
        switch (item.itemType){
            case Item.ItemType.HealthPotion:
            Debug.Log("usou vida");
            inventory.RemoveItem(new Item{itemType = Item.ItemType.HealthPotion, amount = 1});
            break;
            case Item.ItemType.ManaPotion:
            Debug.Log("usou mana");
            inventory.RemoveItem(new Item{itemType = Item.ItemType.ManaPotion, amount = 1});
            break;
        }
    }
}
