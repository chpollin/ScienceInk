﻿using System.Collections;
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
        items = new List<Item>() {
            new Item(0, "Kröte", "Eine leckere Kröte."),
            new Item(1, "Kristall", "Ein magischer Kristall"),
            new Item(2, "Bohnenkraut", "ToDo"),
            new Item(3, "Mangold", "ToDo"),
            new Item(4, "Safran", "ToDo"),
            new Item(5, "Kräuter", "ToDo")
        };
    }
}
