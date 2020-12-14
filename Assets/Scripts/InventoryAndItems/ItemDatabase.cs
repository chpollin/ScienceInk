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
            // Rezept Level 1 - Maisauce
            new Item(0, "Petersilie", "In der mittelalterlichen Kueche ein wichtiges Färbemittel, um Speisen gruen zu färben. Verantwortlich dafür ist das darin enthaltene Chlorophyll (Blattgrün).", 0),
            new Item(1, "Bohnenkraut", "Es wurde von den Mönchen bereits im Frühmittelalter (6.-9.Jh.) nördlich der Alpen kultiviert. Es hat einen scharfen Beigeschmack und wurde daher auch als Pfefferersatz ('Pfefferkraut') verwendet.", 1),
            new Item(2, "Mangold", "Er war bereits in der Antike als Gemüse bekannt. Verspeist werden sowohl Stängel wie auch das Blatt. Der Geschmack erinnert an Spinat.", 2),
            new Item(3, "Salbei", "Eine im Mittelalter überaus geschätzte Heil- und Würzpflanze mit einem sehr eigenen, medizinischen Aroma. Salbeitee ist noch heute das beliebteste Heilmittel bei Zahnfleischproblemen und Halsschmerzen.", 3),
            new Item(4, "Schnittlauch", "Er ist ein Lauchgewächs und hat daher auch den typischen, scharfen Geruch. Seine Heimat ist der Mittelmeerraum.", 4),
            ///////////
            // Rezept Level 2 - Blanc Manger und Böhmische Erbsen
            new Item(5, "Petersilie", "Sie wurde nicht nur in der Küche, sondern auch medizinisch in der Frauenheilkunde als Tee eingesetzt, da sie krampflösend wirkt. Allerdings darf hier nicht überdosiert werden!", 0),
            new Item(6, "Bohnenkraut", "Es erinnert im Geschmack etwas an Thymian, schmeckt aber schärfer. Beim Verzehr von Hülsenfrüchten (Bohnen, Erbsen, ...) soll es die Verdauung unterstützen, damit nciht jedes Böhnchen ein Tönchen erzeugt.", 1),
            new Item(7, "Huhn", "Es ist im Mittelalter fast in jedem Haushalt zu finden: Sie versorgten sich nahezu selbst, lieferten Eier und wurden als alte Hühner verkocht.", 2),
            new Item(8, "Salz", "Salz ist eines der wichtigen Konservierungsmittel. Es wurde im Bergbau gewonnen und danach in riesigen Pfannen ausgekocht und gereinigt.", 3),
            new Item(9, "Pfeffer", "Pfeffer wurde aus Indien über See- uns Landwege importiert und daher sehr teuer. Oft wurde es in Europa sogar als Zahlungsmittel eingesetzt.", 4),
            new Item(10, "Erbsen", "Sie sind eine uralte europäische Kulturpflanze. In den mittelalterlichen Rezeptsammlungen werden grüne, weiße und rote Erbsen genannt.", 5),
            new Item(11, "Speck", "Pökeln (Einsalzen) und Räuchern ist eine Möglichkeit, Schweinefleisch für lange Zeit haltbar zu machen. Rückenspeck ist fett (Lardo), Bauchspeck ist von Fleisch durchzogen.", 6),
            new Item(12, "Liebstöckel", "Hat einen starken eigentümlichen Geruch, seine Aromen wirken wie Geschmacksverstärker bei pikanten Speisen. Es war Heilmittel, Zauberpflanze und Gewürz zugleich.", 7),
            new Item(13, "Reispflanze", "Reis wurde in Europa bis nach Norditalien angebaut. Sein hoher Stärkegehalt ist für Muse und Breispeisen wichtig.", 8),
            ///////////
            // Rezept Level 3 - Krumme Krapfen und Pflaumensauce
            new Item(14, "Pflaume", "Die Pflaume (Zwetschke) ist eine uralte europäische Kulturpflanze. Der Fruchtzucker von Früchten ist im Mittelalter eine der wenigen Quellen für Süßigkeiten.", 0),
            new Item(15, "Rotwein", "Teuerer, oft importierter Wein war ein Luxusgut, mit Wasser verdünnter billiger Wein war ein Alltagsgetränk für alle Altersgruppen. Die Säure und der leichte Alkoholgehalt garantierten, dass der Wein nicht verdarb.", 1),
            new Item(16, "Ingwer", "Eines der drei Standardgewürze des deutschen Mittelalters. Ein Rezept lässt vermuten, dass die Ingwerwurzel frisch und nicht getrocknet importiert wurde.", 2),
            new Item(17, "Zimt", "Um den Zimt ranken sich sagenhafte Geschichten: Das Nest des Phönix sei aus Zimt gebaut, die Ernte entsprechend gefährlich. Das Gewürz wird mit vielen, auch pikanten Zutaten kombiniert.", 3),
            new Item(8, "Mehl", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 2),
            new Item(9, "Schweineschmalz", "Lorem Ipsum Dolore Lorem Ipsum Dolore", 1),
            // Salz, Inventarposition 2
            // Pfeffer, Inventarposition 3
            
            
            
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
