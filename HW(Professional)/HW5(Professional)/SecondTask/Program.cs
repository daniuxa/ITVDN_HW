/*Создайте приложение, которое выводит на экран всю информацию об указанном .xml файле.*/

using System.Xml;

string? FileName;

FileName = Console.ReadLine();

if (FileName == null)
{
    return;
}

XmlDocument xDoc = new XmlDocument();
xDoc.Load(FileName);

XmlElement? xRoot = xDoc.DocumentElement;
//MyContacts
if (xRoot != null)
{
    //Contact
    foreach (XmlElement xnode in xRoot)
    {
        Console.WriteLine($"{xnode.Name} = {xnode.InnerText}");
        foreach (XmlAttribute item in xnode.Attributes)
        {
            Console.WriteLine($"{item.Name} = {item.Value}");
        }
    }
}
