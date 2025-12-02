//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HW1_02_12;

//internal class Task_4
//{
//    static void Main(string[] args)
//    {
//        int number_1, number_2;

//        Console.Write("Enter number 1: ");
//        number_1 = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter number 2: ");
//        number_2 = Convert.ToInt32(Console.ReadLine());

//        int start = number_1;
//        int end = number_2;

//        if (end < start)
//        {
//            int temp = start;
//            start = end;
//            end = temp;
//        }

//        for (int i = start; i <= end; i++)
//        {
//            if (i % 2 == 0)
//            {
//                Console.WriteLine($"Number {i} is paired");
//            }

//            else
//            {
//                Console.WriteLine($"Number {i} not paired");
//            }
//        }
//    }
//}
