# GitHub-Einführung für SchülerInnen

Herzlich willkommen zu diesem GitHub-Tutorial! 😊

In der heutigen digitalen Welt ist das Verständnis von Versionierung und Kollaboration bei der Softwareentwicklung unerlässlich. Egal, ob du ein angehender Entwickler, ein Schüler, der an einem Projekt arbeitet, oder einfach nur neugierig bist, dieses Tutorial wird dir die Grundlagen von GitHub näherbringen.

GitHub ist nicht nur ein Werkzeug für professionelle Entwickler. Es kann auch für Schulprojekte, Gruppenarbeiten oder persönliche Projekte genutzt werden. Es hilft dir, deinen Code zu organisieren, Änderungen zu verfolgen und mit anderen zusammenzuarbeiten.

In diesem Tutorial lernst du:

+ Wie du Änderungen an deinem Code "commitest" und diese auf GitHub hochlädst.
+ Wie du eine neue "Branch" erstellst, um an neuen Features oder Änderungen zu arbeiten, ohne den Hauptcode zu beeinflussen.
+ Und schließlich, wie du einen "Pull-Request" erstellst, um vorgeschlagene Änderungen mit deinem Team zu besprechen und sie schließlich in den Hauptcode zu integrieren.
Lass uns beginnen!

---

### 1. Repository-Erstellung
**Was sind Repositorys?**   
Ein Repository (oft einfach "Repo" genannt) ist im Kontext von GitHub ein Speicherort oder Container, in dem alle Dateien für ein bestimmtes Projekt gespeichert werden. Es enthält alle Versionen dieser Dateien, sodass Sie Änderungen über die Zeit verfolgen können. Das ermöglicht es mehreren Personen, an einem Projekt zu arbeiten und ihre Änderungen auf eine organisierte und kollaborative Weise zu verwalten.

In Bezug auf GitHub Classroom:

Wenn Sie diesen Leitfaden durchlaufen, nehmen wir an, dass Sie bereits ein Repository über GitHub Classroom erstellt haben. GitHub Classroom ist ein Tool, das speziell entwickelt wurde, um den Unterrichtsprozess für Lehrer und Schüler zu vereinfachen. Wenn Sie über einen Link in GitHub Classroom ein Repository erstellen, wird es automatisch auf "internal" gestellt. Das bedeutet, dass das Repository privat bleibt und nur von den eingeladenen Personen eingesehen werden kann.

Die Erstellung von Repositorys und deren detaillierte Konfiguration sind ein eigenes großes Thema und werden in einem kommenden Tutorial ausführlich behandelt. Für jetzt ist es ausreichend zu wissen, dass Sie ein Arbeitsumfeld haben, in dem Sie Ihre Codeänderungen sicher speichern können.

---

### 2. Schritt für Schritt: Änderungen committen

**Ziel**:
Ihr sollt lernen, wie man einfache Fehler in Dokumentationsdateien korrigiert und diese Änderungen in ein Git-Repository einpflegt.

**Ausgangssituation**:
```
Project
|-- documentation.md
|--hello-world.cs
README.md
```
- [ ] 1. **Datei Ändern**
  + In der **'hello-worl.cs'** Datei gibt es einen Schreibfehler, den ihr korrigieren sollt.  Korrigiert den Text, indem ihr **"Morld"** durch **"World"** ersetzt.
- [ ] 2. **Änderung übernehmen**   
  + Committen Sie Ihre Änderung indem Sie auf den **"Commit changes..."** - Button clicken.   
    ![Commit changes button](https://github.com/GSO-SW/public_content_gso/blob/a0a27f20e215e2e1ee2b3d24cb645f8ce2cb8a25/Tutorial-Cred/GitHub-Tutorial/commit-changes.PNG)   
  + Geben Sie in einem Commit **immer** ein Commit-Text an, welcher beschreibt, welche Änderung gemacht wurde.
![Commit changes message](https://github.com/GSO-SW/public_content_gso/blob/a0a27f20e215e2e1ee2b3d24cb645f8ce2cb8a25/Tutorial-Cred/GitHub-Tutorial/Commit-documentation.PNG)   
- [ ] 3. **Commits ansehen**
    + Clicken Sie auf commits und sehen sie alle commits auf main ein.
    + Clicken Sie auf ihren letzten Commit und sehen Sie die Änderung ein.
    + Hinterlassen Sie einen Kommentar
      der könnte folgendermaßen aussehen:
      ``` # Meine erster GitHub Commit :100:``` Die Formatierung geschied bei GitHub immer im [Markdown](https://docs.github.com/github/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax)-Format.
    + Kopieren Sie den Link zur Zeile mit dem Code:
     ```csharp Console.WriteLine("Hello World");```
      und fügen Sie siesen under die 
- [ ] 

In eurem Projektverzeichnis befindet sich folgende Struktur:
---

### Aufgabe 3: Präsentation der Plakate

Teilen Sie einzelne Bereiche des Plakats in Ihrer Gruppe auf und stellen Sie diese der Klasse vor. :busts_in_silhouette:**Gruppenarbeit**  | :clock130: **10 min**

> :information_source: **Hinweise**:exclamation:
> + Zu jedem Plakat gibt die Klasse Feedback zu den Aspekten **Verständlichkeit**, **Gestaltung**, **Inhaltliche Vollständigkeit**.
> + Machen Sie sich Notizen wenn die anderen gruppen Präsentieren.
> + Die beiden Plakate mit den meisten Stimmen werden in der Klasse aufgehangen. 

---

### Aufgabe 4: Bestimmte Namen

Verändern Sie das Programm so, dass der Benutzer nach einem oder mehreren Namen in der Liste suchen kann. Falls der Name nicht in der Liste vorhanden ist, soll eine Fehlermeldung erscheinen. :bust_in_silhouette:**Einzelarbeit**  | :clock130: **20 min**

> :information_source: **Hinweise**:exclamation:
> + Committen und pushen Sie ihre Arbeit oder fügen Sie diese über die Github Oberfläche in Ihr Repository ein.


# :100: Erfolgskriterien
  
+ Eingesetzten Quellcode kommentieren
+ Quellcode schreiben der lesbar ist und mit Hilfe einer logischen Folge das Problem löst
+ Programmausgabe die korrekt, lesbar und richtig formatiert ist 
