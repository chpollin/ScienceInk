using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    private void Awake()
    {
        BuildDatabase();
    }

    public Item GetItemByID(int item_id)
    {
        return items.Find(item => item.item_id == item_id);
    }

    public Item GetItemByTitle(string itemName)
    {
        return items.Find(item => item.title == itemName);
    }

    void BuildDatabase()
    {
        // if else level 1, level 2... ?
        items = new List<Item>() {
            new Item(0, "Bohnenkraut", "Lecker Bohnenkraut."),
            new Item(1, "Mangold", "Supi Mangold"),
            new Item(2, "Salbei", "Seeliger Salbei")
        };
    }
}
