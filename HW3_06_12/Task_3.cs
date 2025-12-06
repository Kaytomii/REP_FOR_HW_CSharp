//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HW3_06_12;

//internal class Task_3
//{
//    static bool isPalidrome(int number)
//    {
//        string str = number.ToString();

//        for (int i = 0; i < str.Length / 2; ++i)
//        {
//            if (str[i] != str[str.Length - 1 - i])
//            {
//                return false;
//            }
//        }

//        return true;
//    }
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter number: ");
//        int number = Convert.ToInt32(Console.ReadLine());

//        bool result = isPalidrome(number);
//        Console.WriteLine($"Number is palidrome: {result}");
//    }
//}
