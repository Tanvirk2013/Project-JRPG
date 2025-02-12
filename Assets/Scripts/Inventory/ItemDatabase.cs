﻿using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    #region Public Properties

    public static ItemDatabase Instance
    {
        get;
        internal set;
    }

    // All items that exist in the game will be stored in this database
    // Items should be referenced as their prefab
    public List<Item> Items
    {
        get;
        internal set;
    }

    #endregion Public Properties

    #region Private Methods

    private void Awake()
    {
        Instance = this;

        CreateDatabase();
    }

    #endregion Private Methods

    #region Public Methods

    public void CreateDatabase()
    {
        // All items need to be hardcoded
        Items = new List<Item>()
        {
            new Item(1, "Test", "Test"),
            new Item(2, "Arrow", "An arrow")
        };
    }

    public Item GetItemByID(int id)
    {
        return Items.Find(item => item.ID == id);
    }

    public Item GetItemByName(string name)
    {
        return Items.Find(item => item.Name == name);
    }

    public Object GetItemPrefab(int id)
    {
        Item temp = GetItemByID(id);
        Object loadedObject = null;

        if (temp != null)
            loadedObject = Resources.Load("Items/" + temp.Name, typeof(GameObject));

        if (loadedObject == null)
            Debug.LogError("loadedObject is null");

        return loadedObject;
    }

    #endregion Public Methods
}