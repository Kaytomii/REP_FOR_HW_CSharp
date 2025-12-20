namespace HW7_20_12.Classes;

public class Product
{
    private string? title;
    private int count;
    private decimal price;

    public Product(string? title, int count, decimal price)
    {
        this.title = title;
        this.count = count;
        this.price = price;
    }

    public Product(int count)
    {
        this.count = count;
    }
    public string? Title
    {
        get => title; 
        set => this.title = value;
    }

    public int Count
    {
        get => count;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Count cannot be negative");
            }

            count = value;
        }
    }

    public decimal Price
    {
        get => price;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be negative");
            }  

            price = value;
        }
    }

    public static Product operator +(Product p, int amount)
    {
        Product prod = new Product(p.count + amount);
        return prod;
    }

    public static Product operator -(Product p, int amount)
    {
        Product prod = new Product(p.count - amount);
        return prod;
    }

    public static bool operator ==(Product p1, Product p2)
    {
        if (p1.price == p2.price)
        {
            return true;
        }

        return false;
    }

    public static bool operator !=(Product p1, Product p2)
    {
        if (p1.price != p2.price)
        {
            return true;
        }

        return false;
    }

    public static bool operator >(Product p1, Product p2)
    {
        return p1.Count > p2.Count;
    }

    public static bool operator <(Product p1, Product p2)
    {
        return p1.Count < p2.Count;
    }
}
