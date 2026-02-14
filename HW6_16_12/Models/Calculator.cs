//using System;

//namespace HW6_16_12.Models
//{
//    public struct Calculator
//    {
//        public void Run()
//        {
//            while (true)
//            {
//                Console.WriteLine("    Calculator    ");
//                Console.WriteLine("0 - Exit");
//                Console.WriteLine("1 - Decimal -> Binary");
//                Console.WriteLine("2 - Binary -> Decimal");
//                Console.Write("Your choice: ");

//                if (!byte.TryParse(Console.ReadLine(), out byte choice))
//                {
//                    Console.WriteLine("Invalid choice");
//                    continue;
//                }

//                if (choice == 0)
//                {
//                    Console.WriteLine("Bye bye");
//                    break;
//                }

//                Console.Write("Enter the number: ");
//                string? input = Console.ReadLine();

//                try
//                {
//                    switch (choice)
//                    {
//                        case 1:
//                            int decNumber = checked(int.Parse(input));
//                            Console.WriteLine($"Decimal: {decNumber} Binary: {Convert.ToString(decNumber, 2)}");
//                            break;

//                        case 2:
//                            int binToDec = unchecked(Convert.ToInt32(input, 2));
//                            Console.WriteLine($"Binary: {input} -> Decimal: {binToDec}");
//                            break;

//                        default:
//                            Console.WriteLine("Invalid menu option");
//                            break;
//                    }
//                }
//                catch (FormatException)
//                {
//                    Console.WriteLine("Invalid number format");
//                }
//                catch (OverflowException)
//                {
//                    Console.WriteLine("Number is out of range for type int");
//                }
//            }
//        }
//    }
//}