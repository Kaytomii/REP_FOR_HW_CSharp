//namespace HW9
//{
//    internal class task_1
//    {
//        public delegate bool Check(int n);

//        static bool IsEven(int n) { return n % 2 == 0; }

//        static bool IsOdd(int n) { return n % 2 != 0; }

//        static bool IsPrime(int n)
//        {
//            if (n < 2) return false;
//            for (int i = 2; i <= Math.Sqrt(n); i++)
//                if (n % i == 0) return false;
//            return true;
//        }

//        static bool IsFibonacci(int n)
//        {
//            return IsSquare(5 * n * n + 4) || IsSquare(5 * n * n - 4);
//        }

//        static bool IsSquare(int x)
//        {
//            int s = (int)Math.Sqrt(x);
//            return s * s == x;
//        }

//        static List<int> Get(int[] arr, Check check)
//        {
//            List<int> result = new List<int>();
//            foreach (int n in arr)
//                if (check(n)) result.Add(n);
//            return result;
//        }

//        static void Print(List<int> list)
//        {
//            foreach (int n in list)
//                Console.Write(n + " ");
//            Console.WriteLine();
//        }

//        static void Main()
//        {
//            int[] numbers = { 1, 2, 3, 4, 5, 8, 13, 21, 34 };

//            List<int> evens = Get(numbers, IsEven);
//            List<int> odds = Get(numbers, IsOdd);
//            List<int> primes = Get(numbers, IsPrime);
//            List<int> fibs = Get(numbers, IsFibonacci);

//            Print(evens);
//            Print(odds);
//            Print(primes);
//            Print(fibs);
//        }

//    }
//}
