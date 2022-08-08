/*Создайте пользовательский тип (например, класс) и выполните сериализацию объекта этого
типа, учитывая тот факт, что состояние объекта необходимо будет передать по сети.*/

using HW8_Professional_;
using System.Runtime.Serialization.Formatters.Soap;

MyClass myClass = new MyClass(1, 2);

using (FileStream stream = new FileStream("test1.xml", FileMode.OpenOrCreate))
{
    SoapFormatter formatter = new SoapFormatter();
    formatter.Serialize(stream, myClass);
}

using (FileStream stream = new FileStream("test1.xml", FileMode.OpenOrCreate))
{
    SoapFormatter formatter = new SoapFormatter();
    myClass = formatter.Deserialize(stream) as MyClass;
}

myClass?.MyMethod();
