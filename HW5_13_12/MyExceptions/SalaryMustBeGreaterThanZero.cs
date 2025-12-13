namespace HW5_13_12;

internal class SalaryMustBeGreaterThanZero:Exception
{
    public SalaryMustBeGreaterThanZero(string message) : base(message) { }
}
