using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW15.Classes;

public class Play : IDisposable
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

    private bool disposed = false;

    public Play(string title, string author, string genre, int year)
    {
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Title} — {Author}, {Genre}, {Year}");
    }

    public void Dispose()
    {
        if (!disposed)
        {
            disposed = true;
            GC.SuppressFinalize(this);
        }
    }

    ~Play()
    {
        Console.WriteLine($"Destructor called for: {Title}");
    }
}

