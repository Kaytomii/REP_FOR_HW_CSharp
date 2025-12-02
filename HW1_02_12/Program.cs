namespace HW1_02_12;

internal class Program
{
    static void Main(string[] args)
    {
        int user_input;

        
        Console.Write("Please, enter number between 1-100: ");
        user_input = Convert.ToInt32(Console.ReadLine());

        if (user_input < 1 || user_input > 100)
        {
            Console.WriteLine("Error try again");
        }

        else
        {
            if (user_input % 3 == 0 && user_input % 5 == 0)
                Console.WriteLine("Fizz Buzz");

            else if (user_input % 3 == 0)
                Console.WriteLine("Fizz");

            else if (user_input % 5 == 0)
                Console.WriteLine("Buzz");

            else
                Console.WriteLine($"Number you input: {user_input}");
        }
    }
}
