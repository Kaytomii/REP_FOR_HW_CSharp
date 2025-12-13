using System.Net.Http.Headers;

namespace HW5_13_12;

public class Employer
{
    private decimal salary;
    private byte age;
    public string EmployerName { get; set; }

    public Employer(decimal salary, byte age, string name)
    {
        EmployerSalary = salary;
        EmployerAge = age;
        EmployerName = name;
    }

    public Employer(decimal salary)
    {
        EmployerSalary = salary;
    }

    public byte EmployerAge
    {
        get
        {
            return age;
        }

        set
        {
            if (value > 120)
            {
                throw new ArgumentOutOfRangeException("Go out");
            }

            age = value;
        }
    }

    public decimal EmployerSalary
    {
        get
        {
            return salary;
        }

        set
        {
            if (value <= 0)
            {
                throw new SalaryMustBeGreaterThanZero("Please find a normal job");
            }

            salary = value;
        }
    }

    public void Print_Information()
    {
        Console.WriteLine($"Employer name: {EmployerName}");
        Console.WriteLine($"Employer salary: {EmployerSalary}");
        Console.WriteLine($"Employer age: {EmployerAge}");
    }

    public static Employer operator +(Employer obj, decimal x)
    {
        Employer emp = new Employer(obj.salary +  x);
        return emp;
    }

    public static Employer operator -(Employer obj, decimal x)
    {
        Employer emp = new Employer(obj.salary - x);
        return emp;
    }

    public static bool operator ==(Employer emp_1, Employer emp_2)
    {
        if (emp_1.salary == emp_2.salary)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public static bool operator !=(Employer emp_1, Employer emp_2)
    {
        if (emp_1.salary != emp_2.salary)
        {
            return true;
        }

        return false;
    }
}
