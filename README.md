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
### Parameter beim Start
### Enum
