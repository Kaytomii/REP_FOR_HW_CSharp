//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HW11.BackpackClass;

//public class Backpack
//{
//    public string Color { get; set; }
//    public string Brand { get; set; }
//    public string Material { get; set; }
//    public double Weight { get; set; }
//    public double Capacity { get; set; }

//    public List<BackpackItem> Items { get; private set; } = new List<BackpackItem>();

//    public event Action<BackpackItem> ItemAdded;
//    public event Action<BackpackItem> ItemRemoved;
//    public event Action<BackpackItem> ItemChanged;

//    public void Fill(string color, string brand, string material, double weight, double capacity)
//    {
//        Color = color;
//        Brand = brand;
//        Material = material;
//        Weight = weight;
//        Capacity = capacity;
//    }

//    public void AddItem(BackpackItem item)
//    {
//        if (GetUsedVolume() + item.Volume > Capacity)
//            throw new Exception("Backpack capacity exceeded");

//        Items.Add(item);
//        ItemAdded?.Invoke(item);
//    }

//    public void RemoveItem(BackpackItem item)
//    {
//        if (Items.Remove(item))
//            ItemRemoved?.Invoke(item);
//    }

//    public void ChangeItem(BackpackItem oldItem, BackpackItem newItem)
//    {
//        double usedWithoutOld = GetUsedVolume() - oldItem.Volume;

//        if (usedWithoutOld + newItem.Volume > Capacity)
//            throw new Exception("Backpack capacity exceeded");

//        Items.Remove(oldItem);
//        Items.Add(newItem);

//        ItemChanged?.Invoke(newItem);
//    }

//    private double GetUsedVolume()
//    {
//        double total = 0;
//        foreach (var item in Items)
//            total += item.Volume;
//        return total;
//    }
//}
