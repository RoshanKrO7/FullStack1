using System;
using System.Collections;
using System.Collections.Generic;

public interface ISpaceStation
{
    string Name { get; set; }
    int Capacity { get; set; }
    void Launch();
}

public class InternationalSpaceStation : ISpaceStation
{
    public string Name { get; set; }
    public int Capacity { get; set; }

    public InternationalSpaceStation(string name, int capacity)
    {
        Name = name;
        Capacity = capacity;
    }

    public void Launch()
    {
        Console.WriteLine($"Launching International Space Station: {Name} and Total Capacity of astronauts: {Capacity}");
    }
}

public class MirSpaceStation : ISpaceStation
{
    public string Name { get; set; }
    public int Capacity { get; set; }

    public MirSpaceStation(string name, int capacity)
    {
        Name = name;
        Capacity = capacity;
    }

    public void Launch()
    {
        Console.WriteLine($"Launching Mir Space Station: {Name} and Total Capacity of astronauts: {Capacity}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<ISpaceStation> spaceStations = new List<ISpaceStation>();

        spaceStations.Add(new InternationalSpaceStation("ISS", 10));
        spaceStations.Add(new MirSpaceStation("Mir", 5));

        foreach (ISpaceStation spaceStation in spaceStations)
        {
            spaceStation.Launch();
        }

        Dictionary<string, ISpaceStation> spaceStationDictionary = new Dictionary<string, ISpaceStation>();

        spaceStationDictionary.Add("ISS", new InternationalSpaceStation("ISS", 10));
        spaceStationDictionary.Add("Mir", new MirSpaceStation("Mir", 5));

        foreach (KeyValuePair<string, ISpaceStation> kvp in spaceStationDictionary)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        ArrayList spaceStationArrayList = new ArrayList();

        spaceStationArrayList.Add(new InternationalSpaceStation("ISS", 10));
        spaceStationArrayList.Add(new MirSpaceStation("Mir", 5));

        foreach (ISpaceStation spaceStation in spaceStationArrayList)
        {
            Console.WriteLine(spaceStation);
        }

        Hashtable spaceStationHashtable = new Hashtable();

        spaceStationHashtable.Add("ISS", new InternationalSpaceStation("ISS", 10));
        spaceStationHashtable.Add("Mir", new MirSpaceStation("Mir", 5));

        foreach (DictionaryEntry entry in spaceStationHashtable)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
    }
}
