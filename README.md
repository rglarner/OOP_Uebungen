# OOP_Uebungen
Dieses Repository enthält Übungen zur objektorientierten Programmierung (OOP) in C#.
Es ist als Zusatzmaterial für die Vorlesung "Objektorientierte Programmierung" gedacht.
Ich empfehle, die Übungen selbständig und ohne KI Hilfe zu lösen.
## AB02
### Notizen
Erstellen Sie eine Klasse zur Speicherung von Notizen. Die Klasse soll folgende Funktionalitäten bieten:
- Titel
- Inhalt
- Verfasser (als String)
- Erstellungsdatum (als DateTime))
- geändert von (als String)
- Änderungsdatum (als DateTime)

Das Erstellungsdatum soll automatisch gesetzt werden, wenn eine Notiz erstellt wird. Das Änderungsdatum soll aktualisiert werden, wenn der Inhalt öder Titel der Notiz geändert wird.
## AB03
### Notizen
Bauen Sie die Klasse "Notizen" aus AB02 weiter aus. Fügen Sie folgende Funktionalitäten hinzu:
- eine Methode, die den Inhalt der Notiz ausgibt
- Der Ersteller und der letzte Bearbeiter sollen nicht verändert werden können.

Zudem soll eine neue Klasse "Kalender" erstellt werden, die folgende Funktionalitäten bietet:
- Enthält den Kalendernamen sowie eine "Collection" von Notizen
- eine Methode, die eine Notiz hinzufügt
- eine Methode, die eine Notiz entfernt anhand des Titels
- eine Methode, die alle Notizen ausgibt
- eine Methode, die eine Notiz nach Titel sucht und ausgibt
- eine Methode, die alle Notizen löscht, die älter als ein bestimmtes Datum sind
- PRO: eine Methode, die alle Notizen nach Erstellungsdatum sortiert ausgibt

