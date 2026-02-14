//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HW9
//{
//    internal class task_2
//    {
//        public delegate int StringOperation(string text);

//        static int CountVowels(string text)
//        {
//            int count = 0;
//            string vowels = "aeiouAEIOU";
//            foreach (char c in text)
//                if (vowels.Contains(c)) count++;
//            return count;
//        }

//        static int CountConsonants(string text)
//        {
//            int count = 0;
//            string vowels = "aeiouAEIOU";
//            foreach (char c in text)
//                if (char.IsLetter(c) && !vowels.Contains(c)) count++;
//            return count;
//        }

//        static int GetLength(string text)
//        {
//            return text.Length;
//        }

//        static void Main()
//        {
//            string input = "Hello";

//            StringOperation op1 = CountVowels;
//            StringOperation op2 = CountConsonants;
//            StringOperation op3 = GetLength;

//            Console.WriteLine(op1(input));
//            Console.WriteLine(op2(input));
//            Console.WriteLine(op3(input));
//        }

//    }
//}
