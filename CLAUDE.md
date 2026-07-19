# CLAUDE.md - Meister Hanns' Quest

## Projekt-Kontext

Edukativer 2D-Plattformer (Unity 2019.4.3f1, C#) fuer das ScienceInk-Projekt der Universitaet Graz. Thema: mittelalterliche Kochkunst. Spieler sammelt historische Zutaten und kocht Rezepte.

## Architektur

### Szenen-Reihenfolge (Build Index)

0. `intro_before_menu` → 1. `Menu` → 2. `0_cutscene_prelude` → 3. `cutscene_intro` → 4. `Level_1` → 5. `cutscene_lvl1_lvl2` → 6. `level_2` → ... → 13. `level_5` → 14. `cutscene_outro`

Ungerade Build-Indices = Cutscenes, gerade = spielbare Level (ab Index 4).

### Kern-Systeme

- **PlayerManager.cs** ist der zentrale Hub: Verwaltet Score, Mandel-Munition, Schiessen. Haengt am Player-Prefab.
- **PlayerMovement.cs** + **CharacterController2D.cs**: Bewegung ist zweigeteilt. `PlayerMovement` liest Input, `CharacterController2D` steuert die Physik (Rigidbody2D). Aenderungen an der Bewegung immer in beiden Dateien pruefen.
- **ItemDatabase.cs**: Enthaelt ALLE 54 Zutaten hardcoded in `BuildDatabase()`. Items sind nach Level gruppiert. Item-IDs muessen zum Pickup-Script im Level passen.
- **Inventory.cs** / **UIInventory.cs**: Laufzeit-Inventar. `Pickup.cs` am Sammel-Objekt triggert das Hinzufuegen.
- **LiveCounter.cs**: 3-Herzen-System. Referenziert direkt UI-GameObjects (heart1, heart2, heart3). Statische Variable `health`.
- **GameManager.cs**: Pause-Logik (ESC). Setzt `Time.timeScale`.
- **nextLevelTrigger.cs**: Prueft ob alle Rezept-Zutaten gesammelt sind, laedt naechste Szene via Build-Index.

### Gegner-System

- **Patrol_easy.cs**: Raycast-basierte Bodenerkennung, Flip bei Kante. `health`-Variable fuer Bullet-Damage.
- **EnemyScript.cs**: Kollisions-Schaden am Spieler.
- Gegner-Typen: Bird, Slug (als Prefabs unter `Assets/Prefab/`).

### Dialog-System

- **Dialog.cs**: Typewriter-Effekt, Array von Saetzen. Wird per Trigger aktiviert.
- Saetze werden im Unity-Inspector konfiguriert, nicht im Code.

## Konventionen

### Namensgebung

- Klassen: PascalCase (`PlayerManager`, `ItemDatabase`)
- Methoden: PascalCase (`PlayGame`, `GetItemByID`)
- Variablen: camelCase (`currentHealth`, `moveSpeed`)
- Item-Sprites: Dateiname muss exakt dem `title`-String in ItemDatabase entsprechen (z.B. `Petersilie.png` ↔ `"Petersilie"`)

### Neues Level hinzufuegen

1. Neue Unity-Szene erstellen, Player-Prefab platzieren
2. Items in `ItemDatabase.cs` → `BuildDatabase()` ergaenzen (neuer Kommentarblock `// Rezept Level X`)
3. Rezept-Anforderungen in `QuestLogManager.cs` fuer das Level definieren
4. `nextLevelTrigger.cs` am Kessel-Objekt: Build-Index der naechsten Szene setzen
5. Cutscene-Szene erstellen und in Build Settings einordnen
6. Item-Sprites unter `Assets/Sprites/Items/` ablegen (Name = Item-Titel)

### Neue Zutat hinzufuegen

1. Sprite erstellen: `Assets/Sprites/Items/{Name}.png` (Name = exakter Titel)
2. Eintrag in `ItemDatabase.cs` → `BuildDatabase()`: `new Item(id, "Name", "Beschreibung", slotIndex)`
3. Pickup-Objekt in der Szene platzieren, `Pickup.cs` zuweisen, Item-ID setzen
4. Im QuestLogManager als benoetigte Zutat eintragen

### Neuen Gegner hinzufuegen

1. Sprite unter `Assets/Resources/Enemies/` ablegen
2. Prefab erstellen mit: `Patrol_easy.cs` (Patrol), `EnemyScript.cs` (Schaden), Collider2D, Rigidbody2D
3. Layer auf "Enemy" setzen (fuer Bullet-Kollision in `BulletScript.cs`)

## Haeufige Fallstricke

- **Item-ID-Konflikte**: IDs in `ItemDatabase` sind NICHT global eindeutig -- sie wiederholen sich pro Level (z.B. "Petersilie" existiert mit ID 0 und ID 5). Das System funktioniert, weil pro Level nur die relevanten Items geladen werden.
- **Build-Index-Abhaengigkeit**: `nextLevelTrigger.cs` nutzt `SceneManager.GetActiveScene().buildIndex + 1`. Aenderungen an der Szenen-Reihenfolge in Build Settings brechen die Level-Progression.
- **Statische Variablen**: `LiveCounter.health` und `CheckpointScript`-Positionen sind statisch und ueberleben Szenen-Wechsel. Bei Bugs nach Szenen-Uebergaengen hier pruefen.
- **Time.timeScale**: Wird im Pause-Menue auf 0 gesetzt. `MainMenu.Awake()` setzt es zurueck auf 1. Wenn nach einem Neustart nichts funktioniert: timeScale pruefen.
- **Sprite-Namen**: Muessen exakt mit dem Item-Titel in `ItemDatabase` uebereinstimmen. Gross-/Kleinschreibung beachten.

## Build und Test

- Unity 2019.4.3f1 (LTS) verwenden
- Startszene: `Assets/Scenes/intro_before_menu.unity` (Build Index 0)
- WebGL-Build: Player Settings → Resolution 960x600
- Standalone: Resolution 1024x768
- Kein externer Build-Prozess, kein package.json -- alles laeuft ueber den Unity Editor

## Offene Architektur-Themen

- Item-Datenbank ist komplett hardcoded (kein JSON/ScriptableObjects) -- bei Erweiterung auf viele Items wird `BuildDatabase()` unuebersichtlich
- Kein Unit-Test-Framework eingebunden
- Einige Root-Verzeichnisse (`Tiles/`, `Palettes/`, `Animation/`) duplizieren Assets-Unterordner
