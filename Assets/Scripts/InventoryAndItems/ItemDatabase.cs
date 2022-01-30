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
            new Item(0, "Petersilie", "In der mittelalterlichen Kueche ein wichtiges Faerbemittel, um Speisen gruen zu faerben. Verantwortlich dafuer ist das darin enthaltene Chlorophyll (Blattgruen).", 0),
            new Item(1, "Bohnenkraut", "Es wurde von den Moenchen bereits im Fruehmittelalter (6.-9.Jh.) noerdlich der Alpen kultiviert. Es hat einen scharfen Beigeschmack und wurde daher auch als Pfefferersatz ('Pfefferkraut') verwendet.", 1),
            new Item(2, "Mangold", "Er war bereits in der Antike als Gemuese bekannt. Verspeist werden sowohl Staengel wie auch das Blatt. Der Geschmack erinnert an Spinat.", 2),
            new Item(3, "Salbei", "Eine im Mittelalter ueberaus geschaetzte Heil- und Wuerzpflanze mit einem sehr eigenen, medizinischen Aroma. Salbeitee ist noch heute das beliebteste Heilmittel bei Zahnfleischproblemen und Halsschmerzen.", 3),
            new Item(4, "Schnittlauch", "Er ist ein Lauchgewaechs und hat daher auch den typischen, scharfen Geruch. Seine Heimat ist der Mittelmeerraum.", 4),
            ///////////
            // Rezept Level 2 - Blanc Manger und Boehmische Erbsen
            new Item(5, "Petersilie", "Sie wurde nicht nur in der Kueche, sondern auch medizinisch in der Frauenheilkunde als Tee eingesetzt, da sie krampfloesend wirkt. Allerdings darf hier nicht ueberdosiert werden!", 0),
            new Item(6, "Bohnenkraut", "Es erinnert im Geschmack etwas an Thymian, schmeckt aber schaerfer. Beim Verzehr von Huelsenfruechten (Bohnen, Erbsen, ...) soll es die Verdauung unterstuetzen, damit nciht jedes Boehnchen ein Toenchen erzeugt.", 1),
            new Item(7, "Huhn", "Es ist im Mittelalter fast in jedem Haushalt zu finden: Sie versorgten sich nahezu selbst, lieferten Eier und wurden als alte Huehner verkocht.", 2),
            new Item(8, "Salz", "Salz ist eines der wichtigen Konservierungsmittel. Es wurde im Bergbau gewonnen und danach in riesigen Pfannen ausgekocht und gereinigt.", 3),
            new Item(9, "Pfeffer", "Pfeffer wurde aus Indien ueber See- uns Landwege importiert und daher sehr teuer. Oft wurde es in Europa sogar als Zahlungsmittel eingesetzt.", 4),
            new Item(10, "Erbsen", "Sie sind eine uralte europaeische Kulturpflanze. In den mittelalterlichen Rezeptsammlungen werden gruene, weisse und rote Erbsen genannt.", 5),
            new Item(11, "Speck", "Poekeln (Einsalzen) und Raeuchern ist eine Moeglichkeit, Schweinefleisch fuer lange Zeit haltbar zu machen. Rueckenspeck ist fett (Lardo), Bauchspeck ist von Fleisch durchzogen.", 6),
            new Item(12, "Liebstoeckel", "Hat einen starken eigentuemlichen Geruch, seine Aromen wirken wie Geschmacksverstaerker bei pikanten Speisen. Es war Heilmittel, Zauberpflanze und Gewuerz zugleich.", 7),
            new Item(13, "Reispflanze", "Reis wurde in Europa bis nach Norditalien angebaut. Sein hoher Staerkegehalt ist fuer Muse und Breispeisen wichtig.", 8),
            ///////////
            // Rezept Level 3 - Krumme Krapfen und Pflaumensauce
            new Item(14, "Pflaume", "Die Pflaume (Zwetschke) ist eine uralte europaeische Kulturpflanze. Der Fruchtzucker von Fruechten ist im Mittelalter eine der wenigen Quellen fuer Suessigkeiten.", 0),
            new Item(15, "Rotwein", "Teuerer, oft importierter Wein war ein Luxusgut, mit Wasser verduennter billiger Wein war ein Alltagsgetraenk fuer alle Altersgruppen. Die Saeure und der leichte Alkoholgehalt garantierten, dass der Wein nicht verdarb.", 1),
            new Item(16, "Ingwer", "Eines der drei Standardgewuerze des deutschen Mittelalters. Ein Rezept laesst vermuten, dass die Ingwerwurzel frisch und nicht getrocknet importiert wurde.", 2),
            new Item(17, "Zimt", "Um den Zimt ranken sich sagenhafte Geschichten: Das Nest des Phoenix sei aus Zimt gebaut, die Ernte entsprechend gefaehrlich. Das Gewuerz wird mit vielen, auch pikanten Zutaten kombiniert.", 3),
            new Item(19, "Gewuerznelken", "Sie erinnern in ihrer Form an kleine Naegel: Daraus leitete sich im Mittelhochdeutschen der Name des Gewuerzes ab.", 4),
            new Item(20, "Mehl", "Getreide war das Grundnahrungsmittel des Mittelalters und wurde gekocht als Brei oder gebacken Brot gegessen.", 5),
            new Item(21, "Ei", "Ein Ei ist bei kuehler Lagerung monatelang haltbar. In den mittelalterlichen Rezeptsammlungen sind Eier die haeufigste Zutat.", 6),
            new Item(22, "Kaese", "Kaese ist konservierte Milch. Kaeselaibe waren beliebte Abgaben, da sie lange aufbewahrt werden konnten. In den Rezepten wird Frisch- und Hartkaese genannt.", 7), 
            new Item(23, "Salz", "Es wurde in wasserdichten Faessern mit dem Schiff und mit Lasttieren transportiert.", 8), 
            new Item(24, "Pfeffer", "Im Mittelalter waren mehrere Pfeffersorten bekannt: Langer Pfeffer, Kubebenpfeffer, Schwarzer Pfeffer. Sie alle haben unterschiedliche Geschmacksrichtungen.", 9),
            new Item(25, "Butterschmalz", "Durch das Abkochen von Butter verdampf das darin enthaltene Wasser, die Butter wird dadurch sehr lange haltbar.", 10),
            new Item(26, "Muskatnuss", "Ein weiteres Importgewuerz, das der Samen des Muskatnussbaumes ist. Er ist von einer roten Huelle umgeben, die als das Gewuerz Macis bekannt ist.", 11),
            new Item(27, "Hufeisen", "Meister Hans muss den perfekten Krummen Krapfen formen!", 12),
            ///////////
            // Rezept Level 4 - Morcheln im Winter und Rotkraut und Erde und Schnee
            new Item(28, "Milch", "Milch ist nicht lange haltbar und wurde immer sehr schnell weiterverarbeitet: gesaeuert, zu Butter oder zu Kaese.", 0),
            new Item(29, "Weissbrot", "Dieses Brot wird aus sehr fein ausgesiebten Mehl hergestellt, das sehr aufwaendig produziert werden muss. Daher ist Weissbrot eine typische Speise des Adels.", 1),
            new Item(30, "Gelberuebe", "Sie ist eine spezielle Zuechtung und ist mit der Karotte verwandt. Sie ist nicht so suess wie die orange Karotte.", 2),
            new Item(31, "Petersilwurzel", "Peterwurzen, wie sie bei uns heisst, ist eines der wenigen Wurzelgemuese, die in den mittelalterlichen Rezepten genannt wird.",3),
            new Item(32, "Apfelsaft", "Saft aus Aepfeln ist nur haltbar, wenn man ihn pasteurisiert, also bei ca. 78° Celsius abkocht. Apfelsaft gaert wegen der Fruchtzucker schnell und wird zu alkohlhaltigem Most.", 4),
            new Item(33, "Zwiebel", "Sie ist eine Zuchtform der gelben Zwiebel. Ihre aeussere Schale kann man auch zum Faerben benutzen.", 5),
            new Item(34, "Olivenoel", "Olivenuel wurde aus dem Mittelmeerraum (vorwiegend Spanien) in Tonkruegen oder Holzfaessern importiert und war dementsprechend teuer.", 6),
            new Item(35, "Rindfleisch", "Rinderhaltung wurde erst im Spaetmittelalter intensiv betrieben, da durch die klimatische Abkuehlung das waermeliebende Getreide nicht mehr ausreichend wuchs.", 7),
            new Item(36, "Haselnuss", "Haselnuesse sind im Mittelalter wichtige Oelfruechte. Der Haselstrauch lieferte wertvolles sehr biegbares und belastbares Holz.", 8),
            new Item(37, "Kochloeffel", "Der Kochloeffelstiel kann als Form fuer die Morchel und zum Frittieren verwendet werden.", 9),
            new Item(38, "Bratenssaft", "Bratensaft entsteht, wenn durch die Hitze die Muskelfasern im Braten angespannt werden und die darin enthaltene Fluessigkeit herausgepresst wird. Durch Hitze entstehen leckere Roestaromen.", 10),
            new Item(39, "Pfeffer", "Der Legende nach wohnen in den Pfefferbaeumen Slangen, die bei der Ernte mit Feuer vertrieben werden. Deshalb sind Pfefferkoerner schwarz.", 11),
            new Item(40, "Salz", "Nach der Gewinnung wurde Salz in Faessern per Schiff oder mit Lasttieren zu den Maerkten gebracht. Es war das ganze Mittelalter über eine wertvolle Handelsware.", 12),
            new Item(41, "Schweineschmalz", "Schmalz wird aus Schweinefett gewonnen, das erhitzt wird, damit das darin enthaltene Wasser verdampft. Es ist bei kuehler Lagerung sehr, sehr lange haltbar.", 13),
            new Item(42, "Apfel", "Aepfel waren als gut lagerfähiges Obst sehr wichtig. Vor allem in Kloestern wurden neue Sorten gezüchtet und danach in ganz Europa verbreitet.", 14),
            new Item(43, "Ei", "In Kombination mit Staerke, die z. B. in Mehl enthalten ist, ist Ei durch das Eiweiss und das Fett im Dotter ein wunderbares Bindemittel.", 15),
            new Item(45, "Rotkraut", "Rotkraut ist eine Zuchtform des Kohlkopfes, der eigentlich hellgruen bis weisslich ist. Diese Sorte stammt aus dem Mittelmeerraum und ist seit dem Mittelalter bei uns bekannt.", 16),
            ///////////
            // Rezept Level 5 - Pastete
            new Item(46, "Weizenmehl", "Weizen, aber vor allem Hartweizen, haben viel mehr Gluten (Klebereiweiss) als andere Getreidesorten und eignen sich daher sehr gut fuers Backen. Nudelmehl aus Hartweizen kann nur mit Wasser, also ohne Ei, verknetet werden.", 0),
            new Item(47, "Olivenoel", "Olivenoel wurde nicht nur als Lebensmittel verwendet, sondern auch zur Herstellung von Salben oder als Lampenbrennstoff.", 1),
            new Item(48, "Honig", "Ein Teil der mittelalterlichen Honigernte wurde von Zeidlern, also Waldimkern, die wilde Bienenvoelker beernteten, gewonnen.", 2),
            new Item(49, "Tauwasser", "Tauwasser wurde als das reinste Wasser bezeichnet, da es scheinba r aus dem Nichts entsteht. Es wurde als Medizin benutzt.", 3),
            new Item(50, "Hefe", "Hefe ist ein Pilz, der z. B. beim Vergaeren von Bier entsteht. Im Teig baut die Hefe Zucker ab, die Gase, die dabei entstehen lassen den Teig aufgehen. Sie sind verantwortlich fuer die nach dem Backen sichtbaren Poren im Teig.", 4),
            new Item(51, "Rindfleisch", "Rinder wurde in den weiten Wiesensteppen des Ostens (z. B. heutiges Ungarn) gezuechtet. Die Tiere wurden in grossen Herden nach Westen getrieben. Sie waren wesentlich kleiner als Rinder heute.", 5),
            new Item(52, "Zwiebel", "Weil Zwiebeln in der Erde wachsen, galten sie vor allem als Nahrung der aermeren Bevoelkerung. Sie waren aber auch eine wichtige Arzneipflanze, z. B. gegen Erkaeltungen.", 6),
            new Item(53, "Wurzelgemuese", "Wegen ihrer guten Lagerfaehigkeit und ihrem Naehrwert waren alle Wurzelgemuese (z. B. Rueben, Rettich, Sellerie) ein wichtiger Bestandteil der mittelalterlichen Ernaehrung.", 7)

        };
    }
}
