# Meister Hanns' Quest

> Ein edukativer 2D-Plattformer ueber mittelalterliche Kochkunst und Lebensmittelwissenschaft.

**Meister Hanns' Quest** ist ein Lernspiel, entwickelt im Rahmen des Projekts [ScienceInk](https://science-ink.uni-graz.at/de/) am [Zentrum fuer Informationsmodellierung](https://informationsmodellierung.uni-graz.at/) der Universitaet Graz. Der Spieler schluepft in die Rolle von Meister Hanns, einem mittelalterlichen Kuechenmeister, und sammelt historisch authentische Zutaten, um Rezepte aus mittelalterlichen Kochbuechern nachzukochen.

## Gameplay

Das Spiel verbindet klassische 2D-Plattformer-Mechaniken mit einem edukativen Sammelsystem:

- **Plattformen ueberwinden** -- Springe, ducke dich und weiche Feinden und Hindernissen aus
- **Zutaten sammeln** -- Finde mittelalterliche Zutaten, die ueber das Level verteilt sind
- **Rezepte kochen** -- Bringe alle benoetigten Zutaten zum Kessel, um das Rezept zu vollenden
- **Geschichte erleben** -- Erfahre durch Cutscenes und Item-Beschreibungen Wissenswertes ueber mittelalterliche Ernaehrung

## Steuerung

| Taste | Aktion |
|---|---|
| `A` / `D` oder Pfeiltasten | Bewegung links/rechts |
| `Leertaste` | Springen |
| `Shift` | Ducken |
| `E` | Mandeln schiessen (Munition) |
| `Q` | Questlog oeffnen (Rezeptuebersicht) |
| `ESC` | Pausenmenue |
| `Enter` | Cutscene ueberspringen |

## Level und Rezepte

Das Spiel umfasst 5 Level mit steigender Komplexitaet, jeweils basierend auf historischen Rezepten:

| Level | Rezept | Zutaten |
|---|---|---|
| 1 | Maisauce | 5 (Petersilie, Bohnenkraut, Mangold, Salbei, Schnittlauch) |
| 2 | Blanc Manger & Boehmische Erbsen | 9 (u.a. Huhn, Pfeffer, Erbsen, Speck, Reis) |
| 3 | Krumme Krapfen & Pflaumensauce | 13 (u.a. Pflaume, Rotwein, Ingwer, Zimt, Mehl) |
| 4 | Morcheln im Winter, Rotkraut & Erde und Schnee | 17 (u.a. Milch, Rindfleisch, Haselnuss, Apfel) |
| 5 | Pastete | 8 (u.a. Weizenmehl, Honig, Hefe, Rindfleisch) |

Insgesamt enthaelt das Spiel **54 einzigartige mittelalterliche Zutaten**, jede mit einer historischen Beschreibung ueber Herkunft, Verwendung und Bedeutung im Mittelalter.

## Spielablauf

```
Intro --> Hauptmenue --> Vorspann-Cutscene --> Level 1 --> Cutscene --> Level 2 --> ... --> Level 5 --> Abspann
```

Zwischen den Leveln erzaehlen Cutscenes die Geschichte von Meister Hanns weiter. Innerhalb der Level sorgen Checkpoints dafuer, dass der Fortschritt nicht verloren geht.

## Technologie

- **Engine:** Unity 2019.4.3f1 (LTS)
- **Sprache:** C#
- **Zielplattform:** WebGL, Windows
- **Aufloesung:** 1024x768 (Standard), 960x600 (Web)

### Verwendete Pakete

- Cinemachine (Kamerafuehrung)
- Timeline (Cutscenes)
- TextMesh Pro (Textdarstellung)
- A* Pathfinding Project (Pfadfindung fuer Gegner)
- 2D Tilemap (Level-Design)

## Projektstruktur

```
Assets/
  Scripts/              C#-Skripte (33 Dateien)
    Player/             Spielerbewegung, Waffen, Controller
    Enemy/              Gegner-KI und Patrol-Logik
    InventoryAndItems/  Inventar, Item-Datenbank (54 Items)
    Quest/              Questlog und Rezept-Tracking
    Dialog/             Dialog-System mit Typewriter-Effekt
    GameManager/        Spielzustand, Lebenszaehler, Checkpoints
    UI/                 Hauptmenue, Sound, Texteffekte
    OnTrigger/          Fallen und Schadenszonen
    Helper/             Hilfsfunktionen
  Scenes/               18 Szenen (5 Level, Cutscenes, Menue)
  Sprites/              Spieler, Gegner, Items, NPCs, Effekte
  Prefab/               Vorgefertigte Spielobjekte
  Animation/            Spieler- und Objekt-Animationen
  Tiles/                Tilemap-Assets fuer Level-Design
  Sound/                Musik und Soundeffekte
  Resources/            Laufzeit-geladene Assets
  Timeline/             Cutscene-Sequenzen
  UI/                   Menue-Hintergruende und Koch-UI
```

## Erste Schritte

1. [Unity 2019.4.3f1](https://unity.com/releases/editor/whats-new/2019.4.3) installieren (oder kompatible 2019.4 LTS-Version)
2. Repository klonen:
   ```bash
   git clone https://github.com/DHCraft/ScienceInk.git
   ```
3. Projekt in Unity oeffnen
4. Startszene: `Assets/Scenes/intro_before_menu.unity`
5. Play druecken

## Version

`0.1-alpha`

## Links

- **Projekt-Website:** [science-ink.uni-graz.at](https://science-ink.uni-graz.at/de/)
- **Institution:** [Zentrum fuer Informationsmodellierung, Universitaet Graz](https://informationsmodellierung.uni-graz.at/)
