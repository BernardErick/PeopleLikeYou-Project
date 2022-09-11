using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Item {

    public enum ItemType{
        Sword,
        HealthPotion,
        ManaPotion,
        Coin,
        Medkit,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite(){
        switch (itemType){
            default:
            case ItemType.Sword: return ItemAssets.Instance.swordSprite;
            case ItemType.HealthPotion: return ItemAssets.Instance.healthPotionSprite;
            case ItemType.ManaPotion: return ItemAssets.Instance.manaPotionSprite;
            case ItemType.Coin: return ItemAssets.Instance.coinSprite;
            case ItemType.Medkit: return ItemAssets.Instance.medkitSprite;
        }
    }

        public bool IsStackable(){
        switch (itemType){
            default:
            case ItemType.Coin:
            case ItemType.HealthPotion: 
            case ItemType.ManaPotion: 
                return true;
            case ItemType.Sword:
            case ItemType.Medkit:
                return false;
        }
    }

}
