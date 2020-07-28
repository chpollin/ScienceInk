using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public List<UIItem> uIItems = new List<UIItem>();
    public GameObject slotPrefab;
    public Transform slotPanel;
    public int numberOfSlots = 5;

    private void Awake()
    {
        for(int count = 0; count < numberOfSlots; count ++)
        {
            GameObject instance = Instantiate(slotPrefab);
            instance.transform.SetParent(slotPanel);
            uIItems.Add(instance.GetComponentInChildren<UIItem>());
        }
    }

    public void UpdateSlot(int slot, Item item)
    {   
        // UpdateItem() in UIItem.cs
        uIItems[slot].UpdateItem(item);
    }

    public void AddNewItem(Item item)
    {
        Debug.Log("Add new Item to UIInventory");
        // use the item it also as slot id: Item with id 2 is using slot 2
        UpdateSlot(item.item_id, item);
    }

    public void RemoveItem(Item item)
    {
        UpdateSlot(uIItems.FindIndex(count => count.item == item), null);
    }

}
