﻿using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Inventory : MonoBehaviour {

    #region Singleton
    public static Inventory instance;

    void awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one inventory");
            return;
        }

        instance = this;
    }
    #endregion

    public List<Item> Playerinventory = new List<Item>();

    #region AddOrRemove
    public void AddItem(Item NewItem)
    {
        Debug.Log("Adding Item");
        Playerinventory.Add(NewItem);
    }

    public void RemoveItem(Item Item)
    {
        Playerinventory.Remove(Item);
    }
    #endregion
}
