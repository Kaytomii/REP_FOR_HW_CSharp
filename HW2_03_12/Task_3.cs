//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HW2_03_12;

//internal class Task_3
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter text: ");
//        string? input = Console.ReadLine();

//        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

//        for (int i = 0;  i < words.Length; i++)
//        {
//            char[] chars = words[i].ToCharArray(); //ToCharArray создает новый массив символов
//            Array.Reverse(chars);
//            words[i] = new string(chars);
//        }

//        string result = string.Join(" ", words); // Join обьединяет все елементы массива с указанным разделителем

//        Console.WriteLine($"Original text: {input}");
//        Console.WriteLine($"Reversed text: {result}");
//    }
//}
