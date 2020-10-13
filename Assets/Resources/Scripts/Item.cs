using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//https://medium.com/@yonem9/create-an-unity-inventory-part-1-basic-data-model-3b54451e25ec
public class Item
{
    public int item_id;
    public string title;
    public string description;
    public int inventorySlotPosition;
    public Sprite icon;
    //public Dictionary<string,int> stats = new Dictionary<string, int>();

    public Item(int item_id, string title, string description, int inventorySlotPosition)
    {
        this.item_id = item_id;
        this.title = title;
        this.description = description;
        this.icon = Resources.Load<Sprite>("Sprites/Items/" + title);
        this.inventorySlotPosition = inventorySlotPosition;
        //this.stats = stats;
    }

    // Item = ingredient with a title, icon and description; used in inventory and in questlog
    public Item(Item item)
    {
        this.item_id = item.item_id;
        this.title = item.title;
        this.description = item.description;
        this.icon = Resources.Load<Sprite>("Sprites/Items/" + item.title);
        this.inventorySlotPosition = item.inventorySlotPosition;
        //this.stats = item.stats;
    }



}
