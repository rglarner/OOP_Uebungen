# OOP_Uebungen
Dieses Repository enth�lt �bungen zur objektorientierten Programmierung (OOP) in C#.
Es ist als Zusatzmaterial f�r die Vorlesung "Objektorientierte Programmierung" gedacht.
Ich empfehle, die �bungen selbst�ndig und ohne KI Hilfe zu l�sen.
## AB02 Klassen zur Datenspeicherung
### L�nder (Teil 1)
Erstellen Sie eine Klasse zur Speicherung von L�ndern. Die Klasse soll folgende Daten abspeichern k�nnen:
- Name des Landes (als String)
- ISO-Code (als String)
- Hauptstadt (als String)
- Fl�che (als double)
- Einwohnerzahl (als int)
- W�hrung (als String)

Die Setter sollen gewisse Validierungen durchf�hren:
- Der Name des Landes darf nicht leer sein.
- Der ISO-Code muss genau 2 Zeichen lang sein.
- Die Hauptstadt darf nicht leer sein.
- Die Fl�che muss gr��er als 0 sein.
- Die Einwohnerzahl muss gr��er oder gleich 0 sein.
- Die W�hrung darf nicht leer sein.
### Notizen (Teil 1)
Erstellen Sie eine Klasse zur Speicherung von Notizen. Die Klasse soll folgende Funktionalit�ten bieten:
- Titel
- Inhalt
- Verfasser (als String)
- Erstellungsdatum (als DateTime))
- �nderungsdatum (als DateTime)

Das Erstellungsdatum soll automatisch gesetzt werden, wenn eine Notiz erstellt wird. Das �nderungsdatum soll aktualisiert werden, wenn der Inhalt �der Titel der Notiz ge�ndert wird. Der Verfasser, Titel und Inhalt darf nicht leer sein. 
### Lagerverwaltung (Teil 1)
Erstellen Sie eine Klasse "Lagerplatz" zur Verwaltung von Lagerbest�nden. Die Klasse soll folgende Funktionalit�ten bieten:
- Name des Lagerplatzes (als String)
- Maximale Kapazit�t (als int)
- Name des gelagerten Produkts (als String)
- Aktueller Bestand (als int)
- Preis pro Einheit (als double)

Die Setter sollen gewisse Validierungen durchf�hren:
- Der Name des Lagerplatzes darf nicht leer sein.
- Die maximale Kapazit�t muss gr��er als 0 sein.
- Der Name des Produkts darf nicht leer sein.
- Der aktuelle Bestand muss zwischen 0 und der maximalen Kapazit�t liegen.
- Der Preis pro Einheit muss gr��er oder gleich 0 sein.

Es soll ein berechneter Wert geben, welcher den Gesamtwert des Lageplatzes angibt (Aktueller Bestand * Preis pro Einheit).
### Lagerverwaltung (Teil 2)
In einem weiteren Schritt soll eine Klasse "Artikel" erstellt werden, die folgende Funktionalit�ten bietet:
- Name des Artikels (als String)
- Beschreibung (als String)
- Preis (als double)
- Artikelnummer (als String)
- Kategorie (als String)

Ersetzen Sie in der Klasse "Lagerplatz" den Namen des Produkts durch einen Artikel und passen Sie die Validierungen sowie die Berechnung des Gesamtwerts des Lagerplatzes entsprechend an.
### PRO Thema JSON
Speichern Sie eines der obigen Objekte in einer JSON-Datei und laden Sie es wieder. Nutzen Sie daf�r die Bibliothek Newtonsoft.Json (Json.NET). Achten Sie darauf, dass die Daten korrekt serialisiert und deserialisiert werden.
## AB03 Klassen komplett
### L�nder (Teil 2)
Erstellen Sie eine Klasse "Kontinent", die folgende Funktionalit�ten bietet:
- Name des Kontinents (als String)
- Collection von L�ndern
- eine Methode, die ein Land hinzuf�gt
- eine Methode, die ein Land entfernt anhand des ISO-Codes
- eine Methode, die alle L�nder ausgibt
- eine Methode, die ein Land nach ISO-Code sucht und ausgibt, falls das Land nicht gefunden wird, soll eine entsprechende Fehlermeldung ausgegeben werden.

Wer will, kann noch eine Klasse "Welt" erstellen, die folgende Funktionalit�ten bietet:
- Collection von Kontinenten
- eine Methode, die einen Kontinent hinzuf�gt
- eine Methode, die einen Kontinent entfernt anhand des Namens
- eine Methode, die alle Kontinente ausgibt
- eine Methode, die einen Kontinent nach Namen sucht und alle L�nder ausgibt, falls der Kontinent nicht gefunden wird, soll eine entsprechende Fehlermeldung ausgegeben werden.
- eine Methode, die alle L�nder nach Kontinenten sortiert ausgibt
- PRO: eine Methode, die alle L�nder aller Kontinente nach Fl�che sortiert ausgibt

### Notizen (Teil 2)
Bauen Sie die Klasse "Notizen" aus AB02 weiter aus. F�gen Sie folgende Funktionalit�ten hinzu:
- Einen Wert: "ge�ndert von" (als String)
- Geeignet Methoden zur Verkapselung der Daten (Erstellen, Bearbeiten, Auslesen)
- Der Verfasser, "ge�ndert von" sowie die beiden Datumsangaben sollen nicht direkt ver�ndert werden k�nnen.
- PRO: Der Benutzername des Verfassers soll automatisch aus dem System ermittelt werden, wenn eine Notiz erstellt wird. (Gleiches f�r "ge�ndert von")

Zudem soll eine neue Klasse "Notizsammlung" erstellt werden, die folgende Funktionalit�ten bietet:
- Enth�lt den Namen der Sammlung sowie eine "Collection" von Notizen
- eine Methode, die eine Notiz hinzuf�gt
- eine Methode, die eine Notiz entfernt anhand des Titels
- eine Methode, die alle Notizen ausgibt
- eine Methode, die eine Notiz nach Titel sucht und ausgibt
- eine Methode, die alle Notizen l�scht, die �lter als ein bestimmtes Datum sind
- PRO: eine Methode, die alle Notizen nach Erstellungsdatum sortiert ausgibt
### PRO Thema JSON
Serialisieren Sie eine der obigen Klassen (mit Collction) in eine JSON-Datei und laden Sie sie wieder. Achten Sie darauf, dass die Daten korrekt serialisiert und deserialisiert werden.
## AB04 Zusatzthemen
### Tickets mit Autoincrement (Klassenvariablen)
Implementiere eine Klasse Ticket, deren jede Instanz automatisch eine eindeutige, fortlaufende ID erh�lt: 1, 2, 3, ...
Anforderungen (Akzeptanzkriterien)
1. Die Klasse besitzt:
- eine statische Variable nextId (Startwert: 1), nicht �ffentlich,
- eine Instanz-Eigenschaft Id (nur lesbar),
- weitere Felder/Eigenschaften wie Titel oder ErstelltAm.
2. Beim Konstruktoraufruf:
- wird Id auf den aktuellen Wert von nextId gesetzt,
- danach wird nextId um 1 erh�ht.
- Id darf nachtr�glich nicht �nderbar sein (read-only).
3. In Main:
- Erzeuge mindestens drei Objekte und gib deren Id und optional Titel aus.
- Die ausgegebenen IDs m�ssen fortlaufend und eindeutig sein.
### Parameter beim Start
### Enum
