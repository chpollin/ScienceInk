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
        // Item_ must be assignet to ingeredient object (Pickup Script)
        // name like "Bohnenkraut" must be same like the name of the .png
        // ToDo: a number representing the slot in the InventoryPanel
        items = new List<Item>() {
            ///////////
            // Rezept 1
            new Item(0, "Bohnenkraut", "Lecker Bohnenkraut. Lorem Ipsum Dolore Lorem Ipsum Dolore Lorem Ipsum Dolore Lorem Ipsum Dolore Lorem Ipsum Dolore", 0),
            new Item(1, "Mangold", "Supi Mangold Lorem Ipsum Dolore Lorem Ipsum Dolore Lorem Ipsum Dolore Lorem Ipsum Dolore Lorem Ipsum Dolore Lorem Ipsum Dolore", 1),
            new Item(2, "Salbei", "Seeliger Salbei Lorem Ipsum Dolore Lorem Ipsum Dolore Lorem Ipsum Dolore Lorem Ipsum Dolore Lorem Ipsum Dolore Lorem Ipsum Dolore", 2),
            ///////////
            // Rezept 2
            new Item(3, "Reispflanze", "Lorem Ipsum Dolore Lorem Ipsum Dolore Lorem Ipsum Dolore Lorem Ipsum Dolore Lorem Ipsum Dolore Lorem Ipsum Dolore", 0),
            new Item(4, "Huhn", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 1),
            new Item(5, "Salz", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 2),
            new Item(6, "Pfeffer", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 3),
            new Item(7, "Erbsen", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 4),
            ///////////
            // Rezept 3
            new Item(8, "Mehl", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 0),
            new Item(9, "Schweineschmalz", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 1),
            // Salz, Inventarposition 2
            // Pfeffer, Inventarposition 3
            new Item(10, "Ingwer", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 4),
            new Item(11, "Pflaume", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 5),
            new Item(12, "Rotwein", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 6),
            new Item(13, "Hufeisen", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 7),
            ///////////
            // Rezept 4
            new Item(14, "Milch", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 0),
            // Schweineschmalz Inventarposition  1
            // Salz, Inventarposition 2
            // Pfeffer, Inventarposition 3
            new Item(16, "Brot", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 4),
            new Item(17, "Gelberübe", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 5),
            new Item(18, "Petersilwurzel", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 6),
            new Item(19, "Apfelsaft", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 7),
            new Item(20, "Zwiebel", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 8),
            new Item(21, "Olivenoel", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 9),
            new Item(22, "Rindfleisch", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 10),
            new Item(23, "Haselnuss", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 11),
            new Item(24, "Kochlöffel", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 12),
            new Item(15, "Bratenssaft", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 13)
        };
    }
}
