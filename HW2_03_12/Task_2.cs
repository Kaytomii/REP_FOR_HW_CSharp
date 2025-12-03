//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.ExceptionServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace HW2_03_12;

//internal class Task_2
//{
//    static void Main(string[] args)
//    {
//        const byte M = 10;
//        const byte N = 8;

//        int[] arr_1 = new int[M] {4, 5, 6, 7, 10, 11, 100, 90, 34, 43 };
//        int[] arr_2 = new int[N] {3, 7, 54, 10, 20, 90, 30, 11 };

//        int[] arr_3 = new int[arr_1.Length];

//        byte count = 0;

//        for (int i = 0; i < arr_1.Length; ++i)
//        {
//            for (int j = 0; j < arr_2.Length; ++j)
//            {
//                if (arr_1[i] == arr_2[j])
//                {
//                    bool alreadyAdded = false;

//                    for (int k = 0; k < count; ++k)
//                    {
//                        if (arr_3[k] == arr_1[i])
//                        {
//                            alreadyAdded = true;
//                            break;
//                        }
//                    }

//                    if (!alreadyAdded)
//                    {
//                        arr_3[count] = arr_1[i];
//                        count++;
//                    }
//                }
//            }
//        }

//        Console.WriteLine("Element without repeats: ");

//        for (int i = 0; i < count; ++i)
//        {
//            Console.WriteLine(arr_3[i]);
//        }
//    }
//}
