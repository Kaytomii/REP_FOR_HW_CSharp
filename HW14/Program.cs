//using HW14.Class;

//namespace HW14;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Phone[] phones =
//        {
//            new Phone { Name = "Galaxy S21", Manufacturer = "Samsung", Price = 800, ReleaseDate = new DateTime(2021, 1, 10) },
//            new Phone { Name = "iPhone 12", Manufacturer = "Apple", Price = 900, ReleaseDate = new DateTime(2020, 10, 15) },
//            new Phone { Name = "Redmi Note 10", Manufacturer = "Xiaomi", Price = 150, ReleaseDate = new DateTime(2021, 3, 5) },
//            new Phone { Name = "Pixel 5", Manufacturer = "Google", Price = 700, ReleaseDate = new DateTime(2020, 9, 30) },
//            new Phone { Name = "Nokia 3310", Manufacturer = "Nokia", Price = 50, ReleaseDate = new DateTime(2000, 9, 1) }
//        };

//        Console.WriteLine("Total phones: " + phones.Count());

//        Console.WriteLine("Price > 100: " + phones.Count(p => p.Price > 100));

//        Console.WriteLine("Price 400–700: " + phones.Count(p => p.Price >= 400 && p.Price <= 700));

//        Console.WriteLine("Phones by Samsung: " + phones.Count(p => p.Manufacturer == "Samsung"));

//        var minPricePhone = phones.MinBy(p => p.Price);
//        Console.WriteLine("Min price phone: " + minPricePhone.Name + " — " + minPricePhone.Price);

//        var maxPricePhone = phones.MaxBy(p => p.Price);
//        Console.WriteLine("Max price phone: " + maxPricePhone.Name + " — " + maxPricePhone.Price);

//        var oldest = phones.MinBy(p => p.ReleaseDate);
//        Console.WriteLine("Oldest phone: " + oldest.Name + " (" + oldest.ReleaseDate.ToShortDateString() + ")");

//        var newest = phones.MaxBy(p => p.ReleaseDate);
//        Console.WriteLine("Newest phone: " + newest.Name + " (" + newest.ReleaseDate.ToShortDateString() + ")");

//        Console.WriteLine("Average price: " + phones.Average(p => p.Price));
//    }

//}
