namespace HW2_03_12;

internal class Task_1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter text: ");
        string user_input = Console.ReadLine();

        string[] words = user_input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //StringSplitOptions.RemoveEmptyEntries делит строку по символу ' '

        Console.WriteLine($"Word count: {words.Length}");
    }
}
