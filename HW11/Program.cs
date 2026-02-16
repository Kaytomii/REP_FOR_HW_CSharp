//using HW11.BackpackClass;
//namespace HW11;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Backpack backpack = new Backpack();

//        backpack.Fill("Black", "Nike", "Nylon", 1.0, 10);

//        backpack.ItemAdded += (item) =>
//        {
//            Console.WriteLine("Added: " + item.Name);
//        };

//        backpack.ItemRemoved += (item) =>
//        {
//            Console.WriteLine("Removed: " + item.Name);
//        };

//        backpack.ItemChanged += (item) =>
//        {
//            Console.WriteLine("Changed to: " + item.Name);
//        };

//        try
//        {
//            var notebook = new BackpackItem { Name = "Notebook", Volume = 2 };
//            var bottle = new BackpackItem { Name = "Bottle", Volume = 3 };
//            var thermos = new BackpackItem { Name = "Thermos", Volume = 4 };

//            backpack.AddItem(notebook);
//            backpack.AddItem(bottle);
//            backpack.ChangeItem(bottle, thermos);
//            backpack.RemoveItem(notebook);

//            backpack.AddItem(new BackpackItem { Name = "Huge Jacket", Volume = 20 });
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Exception: " + ex.Message);
//        }

//    }
//}
