# OOP_Uebungen
Dieses Repository enth�lt �bungen zur objektorientierten Programmierung (OOP) in C#.
Es ist als Zusatzmaterial f�r die Vorlesung "Objektorientierte Programmierung" gedacht.
Ich empfehle, die �bungen selbst�ndig und ohne KI Hilfe zu l�sen.
## AB02
### Notizen
Erstellen Sie eine Klasse zur Speicherung von Notizen. Die Klasse soll folgende Funktionalit�ten bieten:
- Titel
- Inhalt
- Verfasser (als String)
- Erstellungsdatum (als DateTime))
- ge�ndert von (als String)
- �nderungsdatum (als DateTime)

Das Erstellungsdatum soll automatisch gesetzt werden, wenn eine Notiz erstellt wird. Das �nderungsdatum soll aktualisiert werden, wenn der Inhalt �der Titel der Notiz ge�ndert wird.
## AB03
### Notizen
Bauen Sie die Klasse "Notizen" aus AB02 weiter aus. F�gen Sie folgende Funktionalit�ten hinzu:
- eine Methode, die den Inhalt der Notiz ausgibt
- Der Ersteller und der letzte Bearbeiter sollen nicht ver�ndert werden k�nnen.

Zudem soll eine neue Klasse "Kalender" erstellt werden, die folgende Funktionalit�ten bietet:
- Enth�lt den Kalendernamen sowie eine "Collection" von Notizen
- eine Methode, die eine Notiz hinzuf�gt
- eine Methode, die eine Notiz entfernt anhand des Titels
- eine Methode, die alle Notizen ausgibt
- eine Methode, die eine Notiz nach Titel sucht und ausgibt
- eine Methode, die alle Notizen l�scht, die �lter als ein bestimmtes Datum sind
- PRO: eine Methode, die alle Notizen nach Erstellungsdatum sortiert ausgibt

