﻿[System.Serializable]
public class Item
{
    [UnityEngine.HideInInspector]
    private ItemMB _itemMB;
    
    public int ID
    {
        get;
        internal set;
    }

    public string Name
    {
        get;
        internal set;
    }

    public string Description
    {
        get;
        internal set;
    }

    public ItemMB ItemMB
    {
        get { return _itemMB; }
        set { _itemMB = value; }
    }

    public Item(int id, string name, string description)
    {
        ID = id;
        Name = name;
        Description = description;
    }

    public Item (Item copyItem)
    {
        this.ID = copyItem.ID;
        this.Name = copyItem.Name;
        this.Description = copyItem.Description;
    }
}
