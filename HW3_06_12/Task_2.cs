//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HW3_06_12;

//internal class Task_2
//{
//    static void Draw_Rectangle(int width, char symbol)
//    {
//        for (int i = 0; i < width; ++i)
//        {
//            for (int j = 0; j < width; ++j)
//            {
//                Console.Write(symbol + " ");
//            }

//            Console.WriteLine();
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("Enter square width: ");
//        int width = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine();

//        Console.Write("Enter symbol: ");
//        char symbol = Convert.ToChar(Console.ReadLine());

//        Console.WriteLine("Your square: ");
//        Draw_Rectangle(width, symbol);
//    }
//}
