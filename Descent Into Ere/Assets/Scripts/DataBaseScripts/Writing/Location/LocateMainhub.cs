﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LocateMainhub : MonoBehaviour
{
    DataMgr data = DataMgr.Instance;
    InventoryMgr Inven = InventoryMgr.Instance;
    // Start is called before the first frame update
    void Start()
    {
        data.location = "MainHub";
        data.Playerhealth = Health.health;
        data.PlayerLives = Health.lives;
        data.Playercurrency = CurrencyCounter.currentCoins;
        Inven.NumberOfItem = Inventory.NumberOfItems;
        Inven.ItemName = "Potion";
        
        string locationUpdate = JsonUtility.ToJson(data);
        string InvenUpdate = JsonUtility.ToJson(Inven);
        File.WriteAllText("PlayerSaveData.json", locationUpdate);
        File.WriteAllText("PlayerInventory.json", InvenUpdate);
    }

}
