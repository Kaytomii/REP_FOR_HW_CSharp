namespace HW4_09_12;
using Models;
internal class Task_1
{
    static void Main(string[] args)
    {
        Magazine magazine = new();
        magazine.Fill_Magazine();
        Console.WriteLine("===========MAGAZINE===========");
        magazine.Print_Magazine();
    }
}
