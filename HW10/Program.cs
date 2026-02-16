//using Newtonsoft.Json;
//namespace HW10;

//internal class Program
//{
//    static Magazine EnterMagazineInfo()
//    {
//        Magazine magazine = new Magazine();

//        Console.Write("Enter magazine title: ");
//        magazine.Title = Console.ReadLine();

//        Console.Write("Enter publisher name: ");
//        magazine.Publisher = Console.ReadLine();

//        Console.Write("Enter release date (any format): ");
//        magazine.ReleaseDate = Console.ReadLine();

//        Console.Write("Enter page count: ");
//        magazine.PageCount = int.Parse(Console.ReadLine());

//        return magazine;
//    }
//    static string SerializeMagazine(Magazine magazine)
//    {
//        return JsonConvert.SerializeObject(magazine, Formatting.Indented);
//    }

//    static Magazine DeserializeMagazine(string json)
//    {
//        return JsonConvert.DeserializeObject<Magazine>(json);
//    }

//    static void SaveToFile(string json, string path)
//    {
//        File.WriteAllText(path, json);
//    }

//    static string LoadFromFile(string path)
//    {
//        return File.ReadAllText(path);
//    }

//    static void Main(string[] args)
//    {
//        Magazine magazine = EnterMagazineInfo();

//        Console.WriteLine("\nDisplaying information:");
//        magazine.PrintInfo();

//        string json = SerializeMagazine(magazine);
//        Console.WriteLine("\nSerialized JSON:");
//        Console.WriteLine(json);

//        string filePath = "magazine.json";
//        SaveToFile(json, filePath);
//        Console.WriteLine($"\nMagazine saved to file: {filePath}");

//        Console.WriteLine("\nLoading magazine from file...");
//        string loadedJson = LoadFromFile(filePath);

//        Magazine deserializedMagazine = DeserializeMagazine(loadedJson);

//        Console.WriteLine("\nDeserialized magazine:");
//        deserializedMagazine.PrintInfo();

//    }
//}
