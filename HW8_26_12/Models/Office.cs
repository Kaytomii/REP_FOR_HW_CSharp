using HW8_26_12.Abstract_Class;
using HW8_26_12.Interface;

namespace HW8_26_12.Models;

public class Office
{
    private OfficeDevice[] devices;

    public Office(OfficeDevice[] devices)
    {
        this.devices = devices;
    }

    public void TurnOnAll()
    {
        foreach (var device in devices)
            device.TurnOn();
    }

    public void TurnOffAll()
    {
        foreach (var device in devices)
            device.TurnOff();
    }

    public void StartPrint()
    {
        foreach (var device in devices)
        {
            if (device is IPrintable printable)
                printable.Print();
        }
    }

    public void StartScan()
    {
        foreach (var device in devices)
        {
            if (device is IScannable scannable)
                scannable.Scan();
        }
    }

    public void StartCopy()
    {
        foreach (var device in devices)
        {
            if (device is ICopyable copyable)
                copyable.Copy();
        }
    }
}
