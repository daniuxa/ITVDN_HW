/*Из файла TelephoneBook.xml (файл должен был быть создан в процессе выполнения
дополнительного задания) выведите на экран только номера телефонов.*/

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
        foreach (XmlAttribute item in xnode.Attributes)
        {
            Console.WriteLine($"{item.Name} = {item.Value}");
        }
    }
}