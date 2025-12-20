namespace HW7_20_12.Classes;

public enum Week
{
    Monday = 0,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public class TemperatureArray
{
    private const int DAYSINTWEEK = 7;
    private double[] _temperature = new double[DAYSINTWEEK];

    public double this[Week day]
    {
        get => _temperature[(int)day];
        set => _temperature[(int)day] = value;
    }

    public double getAverageTemperature()
    {
        double sum = 0;
        foreach (var temp in _temperature)
        {
            sum += temp;
        }
        return sum / DAYSINTWEEK;
    }
}
