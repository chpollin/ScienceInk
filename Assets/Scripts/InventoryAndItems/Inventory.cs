using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://medium.com/@yonem9/create-an-unity-inventory-part-2-configure-the-inventory-3a990eff8cba
public class Inventory : MonoBehaviour
{
    public List<Item> characterItems = new List<Item>();
    public ItemDatabase itemDatabase;
    public UIInventory inventoryUI;

    public void GiveItem(int item_id)
    {
        Item itemToAdd = itemDatabase.GetItemByID(item_id);
        characterItems.Add(itemToAdd);
        inventoryUI.AddNewItem(itemToAdd);
        Debug.Log("Added item: " + itemToAdd.title);
    }

    public Item CheckForItem(int item_id)
    {
        return characterItems.Find(item => item.item_id == item_id);
    }

    public void RemoveItem(int item_id)
    {
        Item itemToRemove = CheckForItem(item_id);
        if (itemToRemove != null)
        {
            characterItems.Remove(itemToRemove);
            inventoryUI.RemoveItem(itemToRemove);
        }
    }




}
