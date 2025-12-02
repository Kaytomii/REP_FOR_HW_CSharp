using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_02_12;

internal class Task_2
{
    static void Main(string[] args)
    {
        float percentage = 0f;
        int number = 0;

        Console.Write("Enter number: ");
        number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter percent: ");
        percentage = Convert.ToSingle(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Error: number must be grater than 0");
        }

        else
        {
            if (percentage < 0 || percentage > 100)
            {
                Console.WriteLine("Error: percentqge must be between 0 and 100");
            }

            else
            {
                float sum = (percentage * number) / 100;

                Console.WriteLine($"{percentage} percentage from {number} = {sum}");
            }
                
        }
            
    }
}
