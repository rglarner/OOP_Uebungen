# OOP_Uebungen
Dieses Repository enthält Übungen zur objektorientierten Programmierung (OOP) in C#.
Es ist als Zusatzmaterial für die Vorlesung "Objektorientierte Programmierung" gedacht.
Ich empfehle, die Übungen selbständig und ohne KI Hilfe zu lösen.
## AB02 Klassen zur Datenspeicherung
### Länder (Teil 1)
Erstellen Sie eine Klasse zur Speicherung von Ländern. Die Klasse soll folgende Daten abspeichern können:
- Name des Landes (als String)
- ISO-Code (als String)
- Hauptstadt (als String)
- Fläche (als double)
- Einwohnerzahl (als int)
- Währung (als String)

Die Setter sollen gewisse Validierungen durchführen:
- Der Name des Landes darf nicht leer sein.
- Der ISO-Code muss genau 2 Zeichen lang sein.
- Die Hauptstadt darf nicht leer sein.
- Die Fläche muss größer als 0 sein.
- Die Einwohnerzahl muss größer oder gleich 0 sein.
- Die Währung darf nicht leer sein.
### Notizen (Teil 1)
Erstellen Sie eine Klasse zur Speicherung von Notizen. Die Klasse soll folgende Funktionalitäten bieten:
- Titel
- Inhalt
- Verfasser (als String)
- Erstellungsdatum (als DateTime))
- Änderungsdatum (als DateTime)

Das Erstellungsdatum soll automatisch gesetzt werden, wenn eine Notiz erstellt wird. Das Änderungsdatum soll aktualisiert werden, wenn der Inhalt öder Titel der Notiz geändert wird. Der Verfasser, Titel und Inhalt darf nicht leer sein. 
### Lagerverwaltung (Teil 1)
Erstellen Sie eine Klasse "Lagerplatz" zur Verwaltung von Lagerbeständen. Die Klasse soll folgende Funktionalitäten bieten:
- Name des Lagerplatzes (als String)
- Maximale Kapazität (als int)
- Name des gelagerten Produkts (als String)
- Aktueller Bestand (als int)
- Preis pro Einheit (als double)

Die Setter sollen gewisse Validierungen durchführen:
- Der Name des Lagerplatzes darf nicht leer sein.
- Die maximale Kapazität muss größer als 0 sein.
- Der Name des Produkts darf nicht leer sein.
- Der aktuelle Bestand muss zwischen 0 und der maximalen Kapazität liegen.
- Der Preis pro Einheit muss größer oder gleich 0 sein.

Es soll ein berechneter Wert geben, welcher den Gesamtwert des Lageplatzes angibt (Aktueller Bestand * Preis pro Einheit).
### Lagerverwaltung (Teil 2)
In einem weiteren Schritt soll eine Klasse "Artikel" erstellt werden, die folgende Funktionalitäten bietet:
- Name des Artikels (als String)
- Beschreibung (als String)
- Preis (als double)
- Artikelnummer (als String)
- Kategorie (als String)

Ersetzen Sie in der Klasse "Lagerplatz" den Namen des Produkts durch einen Artikel und passen Sie die Validierungen sowie die Berechnung des Gesamtwerts des Lagerplatzes entsprechend an.
### PRO Thema JSON
Speichern Sie eines der obigen Objekte in einer JSON-Datei und laden Sie es wieder. Nutzen Sie dafür die Bibliothek Newtonsoft.Json (Json.NET). Achten Sie darauf, dass die Daten korrekt serialisiert und deserialisiert werden.
## AB03 Klassen komplett
### Länder (Teil 2)
Erstellen Sie eine Klasse "Kontinent", die folgende Funktionalitäten bietet:
- Name des Kontinents (als String)
- Collection von Ländern
- eine Methode, die ein Land hinzufügt
- eine Methode, die ein Land entfernt anhand des ISO-Codes
- eine Methode, die alle Länder ausgibt
- eine Methode, die ein Land nach ISO-Code sucht und ausgibt, falls das Land nicht gefunden wird, soll eine entsprechende Fehlermeldung ausgegeben werden.

Wer will, kann noch eine Klasse "Welt" erstellen, die folgende Funktionalitäten bietet:
- Collection von Kontinenten
- eine Methode, die einen Kontinent hinzufügt
- eine Methode, die einen Kontinent entfernt anhand des Namens
- eine Methode, die alle Kontinente ausgibt
- eine Methode, die einen Kontinent nach Namen sucht und alle Länder ausgibt, falls der Kontinent nicht gefunden wird, soll eine entsprechende Fehlermeldung ausgegeben werden.
- eine Methode, die alle Länder nach Kontinenten sortiert ausgibt
- PRO: eine Methode, die alle Länder aller Kontinente nach Fläche sortiert ausgibt

### Notizen (Teil 2)
Bauen Sie die Klasse "Notizen" aus AB02 weiter aus. Fügen Sie folgende Funktionalitäten hinzu:
- Einen Wert: "geändert von" (als String)
- Geeignet Methoden zur Verkapselung der Daten (Erstellen, Bearbeiten, Auslesen)
- Der Verfasser, "geändert von" sowie die beiden Datumsangaben sollen nicht direkt verändert werden können.
- PRO: Der Benutzername des Verfassers soll automatisch aus dem System ermittelt werden, wenn eine Notiz erstellt wird. (Gleiches für "geändert von")

Zudem soll eine neue Klasse "Notizsammlung" erstellt werden, die folgende Funktionalitäten bietet:
- Enthält den Namen der Sammlung sowie eine "Collection" von Notizen
- eine Methode, die eine Notiz hinzufügt
- eine Methode, die eine Notiz entfernt anhand des Titels
- eine Methode, die alle Notizen ausgibt
- eine Methode, die eine Notiz nach Titel sucht und ausgibt
- eine Methode, die alle Notizen löscht, die älter als ein bestimmtes Datum sind
- PRO: eine Methode, die alle Notizen nach Erstellungsdatum sortiert ausgibt
### PRO Thema JSON
Serialisieren Sie eine der obigen Klassen (mit Collction) in eine JSON-Datei und laden Sie sie wieder. Achten Sie darauf, dass die Daten korrekt serialisiert und deserialisiert werden.
## AB04 Zusatzthemen
### Tickets mit Autoincrement (Klassenvariablen)
Implementiere eine Klasse Ticket, deren jede Instanz automatisch eine eindeutige, fortlaufende ID erhält: 1, 2, 3, ...
Anforderungen (Akzeptanzkriterien)
1. Die Klasse besitzt:
- eine statische Variable nextId (Startwert: 1), nicht öffentlich,
- eine Instanz-Eigenschaft Id (nur lesbar),
- weitere Felder/Eigenschaften wie Titel oder ErstelltAm.
2. Beim Konstruktoraufruf:
- wird Id auf den aktuellen Wert von nextId gesetzt,
- danach wird nextId um 1 erhöht.
- Id darf nachträglich nicht änderbar sein (read-only).
3. In Main:
- Erzeuge mindestens drei Objekte und gib deren Id und optional Titel aus.
- Die ausgegebenen IDs müssen fortlaufend und eindeutig sein.
### Mini‑CLI mit Flags (Parameter beim Start)
Implementiere eine Konsolenanwendung, die einen Text verarbeitet.
Die App akzeptiert optionale Flags und einen Pflicht‑Text (positional, letzter Parameter):  
Unterstützte Flags:
- `-h` / `--help`  
Zeigt die Usage an und beendet das Programm.
- `-r N` / `--repeat N`  
Gibt den Text N-mal aus (N ≥ 1).
- `-u` / `--upper`  
Gibt den Text in Grossbuchstaben aus.
- `-l` / `--lower`  
Gibt den Text in Kleinbuchstaben aus.
Regeln  
1. Es gibt genau ein Pflichtargument: den auszugebenden Text.
2. Werden --upper und --lower gleichzeitig angegeben → Fehlermeldung + Usage.
3. Fehlt der Text oder ist N von --repeat ungültig → Fehlermeldung + Usage.
4. Flags dürfen in beliebiger Reihenfolge vorkommen.

Beispiele
`app.exe "Hallo Welt"`
→ Ausgabe: Hallo Welt
`app.exe -u -r 3 "Hallo"`
→ Ausgabe:
HALLO  
HALLO  
HALLO  
`app.exe --lower "Schön"`
→ Ausgabe: schön
`app.exe -r 0 "Test"`
→ Fehler + Usage
`app.exe -u --lower "Konflikt"`
→ Fehler + Usage

Definition in EBNF:  
`app [-h|--help] [-u|--upper|-l|--lower] [-r N|--repeat N] <text>`

### Logger (Enum)
1. Definiere ein enum LogLevel mit den Werten:
- Info
- Warn
- Error
2. Implementiere eine Methode `Log` welche den Text farbig ausgibt:
- Info → Weiss
- Warn → Gelb
- Error → Rot 
3. Teste das Programm, indem du mehrere Nachrichten mit unterschiedlichen Levels ausgibst, z. B.:
```
Log("System gestartet", LogLevel.Info);
Log("Speicherplatz knapp", LogLevel.Warn);
Log("Verbindung verloren!", LogLevel.Error);
```

## AB05 Vererbung
### AB05 – Aufgabe: Vererbung & Polymorphie mit „Artikel“

> **Kurzkontext:** In AB05 geht es um Generalisierung/Spezialisierung, Überschreiben (`virtual`/`override`) und sinnvolle Zugriffsmodifikatoren. In dieser Übung modellieren Sie einen Shop mit einer **Superklasse `Artikel`** und drei **Subklassen**: `NonFood`, `Food`, `Gutschein`.

---

#### Lernziele
- Gemeinsame Daten/Verhalten in einer **Superklasse** bündeln (Generalisierung).
- Unterschiede in **Subklassen** modellieren (Spezialisierung).
- **Statische Member** sinnvoll einsetzen (zentrale Lager-/Reporting-Funktionen).
- **Polymorph** über eine gemeinsame Typbasis arbeiten (Liste von `Artikel`).
- Transparente Konsolen-Logs: Jede Methode meldet **eine Zeile**, was gerade passiert.

---

#### Vorgaben (fachliche Spezifikation)

##### Superklasse: `Artikel`
**Eigenschaften**
- `Id : string` (eindeutig)
- `Name : string`
- `Beschreibung : string`
- `Preis : decimal`
- `Einheit : string` (z. B. „Stk“, „kg“)
- **Lagerverwaltung über Klasseneigenschaft**: zentrale Lagerstatistik (z. B. `static` Map von `Id` → aktuelle Menge)

**Methoden**
- **Konstruktor mit Parametern**: nimmt u. a. `Id` und eine Startmenge entgegen und **erhöht den Lagerbestand** für diese `Id`.
- `Verkaufen(int menge)`: **reduziert** den Lagerbestand dieser `Id`.  
- Jede Methode schreibt **eine Zeile** auf die Konsole (z. B. `"[Artikel] +5 auf Lager (Id=..., neu=...)"`, `"[Artikel] -1 verkauft (Id=..., neu=...)"`).

---

##### Unterklasse 1: `NonFood : Artikel`
**Eigenschaften**
- `Garantie : bool`
- `GarantiedauerMonate : int` (**Klassenvariable/static**, für alle Non-Food gleich)
- `Garantieende : DateTime?` (pro Instanz)

**Spezialverhalten**
- `Verkaufen(int menge)`:  
  - Setzt bei erfolgreichem Verkauf (und falls `Garantie == true`) das `Garantieende` auf **Verkaufsdatum + GarantiedauerMonate**.
  - Ruft anschließend die **Basismethode** auf.
  - Schreibt **eine Zeile**: z. B. `"[NonFood] Garantie bis 2026-09-01 aktiviert (Id=...)"`.

---

##### Unterklasse 2: `Food : Artikel`
**Eigenschaften**
- `Ablaufdatum : DateTime` (pro Instanz)

**Spezialverhalten**
- `static void AusgabeAbgelaufen()`:  
  - Gibt **alle abgelaufenen Food-Artikel** (heute > `Ablaufdatum`) in einer formatierten Liste aus.  
  - Schreibt **eine Zeile pro Fund** (z. B. `"[Food] Abgelaufen: Id=..., Name=..., bis=..."`).  
  - Tipp: Halten Sie alle Food-Instanzen in einer **statischen Liste** der Klasse `Food` (Registry).

---

##### Unterklasse 3: `Gutschein : Artikel`
**Eigenschaften**
- `Restwert : decimal`
- `Ablaufdatum : DateTime` (wird im **Konstruktor** auf **heute + 5 Jahre** gesetzt)

**Konstruktor**
- Ruft **`base(...)`** auf (inkl. Startmenge) und setzt danach `Ablaufdatum = DateTime.Today.AddYears(5)`.

**Statische Methoden**
- `static void AnzeigeAbgelaufeneGutscheine()`  
  - Gibt alle **abgelaufenen Gutscheine** (heute > `Ablaufdatum`) je **eine Zeile** aus.
- `static void AnzeigeSummeOffeneGutscheine()`  
  - Summiert `Restwert` aller **nicht abgelaufenen** Gutscheine und gibt die Summe als **eine Zeile** aus.

---

#### Technische Anforderungen & Hinweise
- Verwenden Sie **sinnvolle Zugriffsmodifikatoren** (`public` für API, `protected`/`private` für intern).
- Mindestens **eine Methode** in `Artikel` als `virtual` kennzeichnen und in einer Subklasse **überschreiben**.
- Jede Methode schreibt **genau eine Zeile** ins Log (Konsole).
- Prüfen Sie in `Verkaufen` auf ausreichenden Lagerbestand (bei Mangel Fehlermeldung).
- Für die statischen Reports (`Food`, `Gutschein`) benötigen die Klassen eine **statische Registry** der erzeugten Instanzen.

---

#### Program.cs (Demonstration)
- Legen Sie **jeweils eine Instanz** von `NonFood`, `Food`, `Gutschein` an.
- Führen Sie exemplarische **Operationen** aus:  
  - Non-Food: verkaufen → Garantieende setzen.  
  - Food: verkaufen → `Food.AusgabeAbgelaufen()`.  
  - Gutschein: Restwert reduzieren → `AnzeigeAbgelaufeneGutscheine()` & `AnzeigeSummeOffeneGutscheine()`.
- Erstellen Sie eine `List<Artikel>` und fügen Sie alle Objekte hinzu. Rufen Sie eine **gemeinsame Methode** polymorph auf.
