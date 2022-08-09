/*Создайте свой класс, объекты которого будут занимать много места в памяти (например, в
коде класса будет присутствовать большой массив) и реализуйте для этого класса,
формализованный шаблон очистки.*/

using HW9_Professional_;

GC.GetTotalAllocatedBytes();
Console.WriteLine(GC.GetTotalMemory(false) / (1024*1024));
MyClass myClass1 = new MyClass();
Console.WriteLine(GC.GetTotalMemory(false) / (1024 * 1024));
MyClass myClass2 = new MyClass();
Console.WriteLine(GC.GetTotalMemory(false) / (1024 * 1024));
MyClass myClass3 = new MyClass();
Console.WriteLine(GC.GetTotalMemory(false) / (1024 * 1024));
Console.ReadKey();
