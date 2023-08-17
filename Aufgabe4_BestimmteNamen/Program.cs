// IHR NAME
// IHRE KLASSE

/// <summary>
/// SAS Zählergesteuerte Schleifen
/// Arbeitsauftrag 1 - Aufgabe 4
/// Bestimmte Namen
/// </summary>

using System.Text.Json;


Aufgabe_4.Aufgabe4();

public static class Aufgabe_4
{
    public static void Aufgabe4()
    {


        //Der Pfad beim Debuggen
        string jsonString = File.ReadAllText(@"..\..\..\Namelist.json");

        //Der Pfad beim Ausführen
        //jsonString = File.ReadAllText(@"Namelist.json");

        //Daten werden in ein String gespeichert
        var jsonArray = JsonSerializer.Deserialize<string[]>(jsonString);

        //Ausgabe aller Namen ???
        Console.WriteLine(jsonArray);

    }
}