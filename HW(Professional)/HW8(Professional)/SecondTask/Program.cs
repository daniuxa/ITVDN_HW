/*Создайте класс, поддерживающий сериализацию. Выполните сериализацию объекта этого
класса в формате XML. Сначала используйте формат по умолчанию, а затем измените его
таким образом, чтобы значения полей сохранились в виде атрибутов элементов XML.*/

using SecondTask;
using System.Xml.Serialization;

MyClass myClass = new MyClass(1, 2);
MyClass myClass1;
XmlSerializer serializer = new XmlSerializer(typeof(MyClass));

using (FileStream stream = new FileStream("test2.xml", FileMode.OpenOrCreate))
{
    serializer.Serialize(stream, myClass);
}

using (FileStream stream = new FileStream("test2.xml", FileMode.OpenOrCreate))
{
    myClass1 = serializer.Deserialize(stream) as MyClass;
}

myClass1?.MyMethod();