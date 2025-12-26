using HW8_26_12.Abstract_Class;
using HW8_26_12.Models;

namespace HW8_26_12
{
    internal class Task_1
    {
        static void Main(string[] args)
        {
            OfficeDevice[] devices =
        {
            new Printer("HP Printer"),
            new Scanner("Canon Scanner"),
            new Copier("Xerox Copier"),
            new Mfu("Epson MFU")
        };

            Office office = new Office(devices);

            office.TurnOnAll();
            office.StartPrint();
            office.StartScan();
            office.StartCopy();
            office.TurnOffAll();
        }
    }
}
