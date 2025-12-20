//namespace HW7_20_12;
//using Classes;
//internal class Task_1
//{
//    static void Main(string[] args)
//    {
//        const int DAYS_WEEK = 7;
//        TemperatureArray temperature = new TemperatureArray();
//        Random rnd = new Random();

//        for (int i = 0; i < DAYS_WEEK; ++i)
//        {
//            temperature[(Week)i] = rnd.Next(-10, 40);
//        }

//        Console.WriteLine("Temperature of week: ");
//        for (int i = 0; i < DAYS_WEEK; ++i)
//        {
//            Console.WriteLine($"Day {i}: {temperature[(Week)i]}");
//        }

//        double average_temperature = Math.Round(temperature.getAverageTemperature(), 2);
//        Console.WriteLine($"Average temperature: {average_temperature}");
//    }
//}
