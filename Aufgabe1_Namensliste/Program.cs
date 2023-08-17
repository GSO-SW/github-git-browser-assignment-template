// IHR NAME
// IHRE KLASSE

/// <summary>
/// SAS Zählergesteuerte Schleifen
/// Arbeitsauftrag 1 - Aufgabe 1
/// Namensliste
/// </summary>


using System.Text.Json;


Aufgabe_1.Aufgabe1();

public static class Aufgabe_1
{
    public static void Aufgabe1()
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