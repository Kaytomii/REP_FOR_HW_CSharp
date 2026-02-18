using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12.ShopApp;

public class Category<T> : IEnumerable<Product<T>>
{
    private List<Product<T>> products = new List<Product<T>>();

    public void Add(Product<T> product)
    {
        products.Add(product);
    }

    public IEnumerator<Product<T>> GetEnumerator()
    {
        return products.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerable<Product<T>> FilterByPrice(double min, double max)
    {
        return products.Where(p => p.Price >= min && p.Price <= max);
    }

    public IEnumerable<Product<T>> FilterByLastDays(int days)
    {
        DateTime limit = DateTime.Now.AddDays(-days);
        return products.Where(p => p.AddedDate >= limit);
    }
}
