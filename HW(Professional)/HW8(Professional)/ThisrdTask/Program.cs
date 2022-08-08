/*Создайте новое приложение, в котором выполните десериализацию объекта из предыдущего
примера. Отобразите состояние объекта на экране.*/

using SecondTask;
using System.Xml.Serialization;

MyClass myClass;

XmlSerializer serializer = new XmlSerializer(typeof(MyClass));
using (FileStream stream = new FileStream(@"C:\Users\saliv\source\repos\HW8(Professional)\SecondTask\bin\Debug\net6.0\test2.xml", FileMode.OpenOrCreate))
{
    myClass = serializer.Deserialize(stream) as MyClass;
}

myClass?.MyMethod();
