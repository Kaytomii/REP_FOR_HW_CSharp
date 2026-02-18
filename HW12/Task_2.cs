//using HW12.ShopApp;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HW12
//{
//    internal class Task_2
//    {
//        static void Main(string[] args)
//        {
//            Category<string> electronics = new Category<string>();

//            electronics.Add(new Product<string>("Laptop", "Gaming Laptop", 1500));
//            electronics.Add(new Product<string>("Mouse", "Wireless Mouse", 40));
//            electronics.Add(new Product<string>("Keyboard", "Mechanical Keyboard", 120));

//            Console.WriteLine("All products:");
//            foreach (var p in electronics)
//                Console.WriteLine($"{p.Name} — {p.Price}");

//            Console.WriteLine("\nProducts priced 50–200:");
//            foreach (var p in electronics.FilterByPrice(50, 200))
//                Console.WriteLine($"{p.Name} — {p.Price}");

//            Console.WriteLine("\nProducts added in last 1 day:");
//            foreach (var p in electronics.FilterByLastDays(1))
//                Console.WriteLine($"{p.Name} — {p.AddedDate}");

//        }
//    }
//}
