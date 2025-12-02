//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HW1_02_12;

//internal class Task_3
//{
//    static void Main(string[] args)
//    {
//        int number;
//        Console.Write("Enter number: ");
//        number = Convert.ToInt32(Console.ReadLine());

//        int digitsCount = 0;
//        int temp = number;

//        while (temp > 0)
//        {
//            digitsCount++;
//            temp /= 10;
//        }

//        temp = number;
//        int sum = 0;

//        while (temp > 0)
//        {
//            int digit = temp % 10;
//            sum += (int)Math.Pow(digit, digitsCount);
//            temp /= 10;
//        }

//        if (sum == number)
//        {
//            Console.WriteLine($"{number} is an Armstrong number.");
//        }

//        else
//        {
//            Console.WriteLine($"{number} is not an Armstrong number.");
//        }

//    }
//}