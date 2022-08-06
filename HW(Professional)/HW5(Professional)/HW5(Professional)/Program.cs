using System.Xml;

/*Создайте.xml файл, который соответствовал бы следующим требованиям:
- имя файла: TelephoneBook.xml
- корневой элемент: “MyContacts”
- тег “Contact”, и в нем должно быть записано имя контакта и атрибут “TelephoneNumber”
со значением номера телефона.*/

using (XmlWriter writer = XmlWriter.Create("text1.xml"))
{
    writer.WriteStartDocument();                  // Заголовок XML - <?xml version="1.0"?>
    writer.WriteStartElement("MyContacts");
    writer.WriteStartElement("Contact");
    writer.WriteAttributeString("TelephoneNumber", "0636792120");
    writer.WriteValue("Tom");
    writer.WriteEndElement();
    writer.WriteEndElement();
}


