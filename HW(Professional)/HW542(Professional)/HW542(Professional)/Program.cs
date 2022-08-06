using Microsoft.Win32;
using System.Drawing;

string? Color;

ChangeColor(ReadFromRegistry());

Console.WriteLine("Sample Text");

Color = Console.ReadLine();

if (Color == null)
{
    return;
}

ChangeColor(Color);

Console.WriteLine("Sample Text");

RegistryKey myKey = Registry.CurrentUser;
RegistryKey myDir = myKey.OpenSubKey("ATest", true);
if (myDir == null)
{

    try
    {
        myDir = myKey.CreateSubKey("ATest", true);

    }
    catch (Exception e)
    {
        // Если возникает проблема - выводим сообщение о ней на экран.
        Console.WriteLine(e.Message);
    }
}

myDir.SetValue("Color", Color);


static ConsoleColor ClosestConsoleColor(byte r, byte g, byte b)
{
    ConsoleColor ret = 0;
    double rr = r, gg = g, bb = b, delta = double.MaxValue;

    foreach (ConsoleColor cc in Enum.GetValues(typeof(ConsoleColor)))
    {
        var n = Enum.GetName(typeof(ConsoleColor), cc);
        var c = System.Drawing.Color.FromName(n == "DarkYellow" ? "Orange" : n); // bug fix
        var t = Math.Pow(c.R - rr, 2.0) + Math.Pow(c.G - gg, 2.0) + Math.Pow(c.B - bb, 2.0);
        if (t == 0.0)
            return cc;
        if (t < delta)
        {
            delta = t;
            ret = cc;
        }
    }
    return ret;
}

string ReadFromRegistry()
{
    string Color;
    RegistryKey key = Registry.CurrentUser;
    RegistryKey myDir = key.OpenSubKey("ATest");

    Color = myDir.GetValue("Color").ToString();
    return Color;
}

void ChangeColor(string Color)
{
    ColorConverter colorConverter = new ColorConverter();
    Color color = (Color)colorConverter.ConvertFromString(Color);
    var ccolor = ClosestConsoleColor(color.R, color.G, color.B);
    Console.ForegroundColor = ccolor;
}
