using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.ShopApp;

public class Product<T>
{
    public T Item { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public DateTime AddedDate { get; set; }

    public Product(T item, string name, double price)
    {
        Item = item;
        Name = name;
        Price = price;
        AddedDate = DateTime.Now;
    }
}
