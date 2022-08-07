/*Создайте пользовательский атрибут AccessLevelAttribute, позволяющий определить
уровень доступа пользователя к системе. Сформируйте состав сотрудников некоторой фирмы
в виде набора классов, например, Manager, Programmer, Director. При помощи атрибута
AccessLevelAttribute распределите уровни доступа персонала и отобразите на экране
реакцию системы на попытку каждого сотрудника получить доступ в защищенную секцию.*/

using HW7_Professional_;

Manager manager = new Manager();
Director director = new Director();
Programmer programmer = new Programmer();

Type typeManager = typeof(Manager);
Type typeDirector = typeof(Director);
Type typeProgrammer = typeof(Programmer);

AccessLevelAttribute attribute = (AccessLevelAttribute)typeManager.GetCustomAttributes(typeof(Attribute), false)[0];

if (attribute.accessLevel == AccessLevel.High)
{
    Console.WriteLine("Access allowed for Manager");
}
else
{
    Console.WriteLine("Access denied for Manager");
}

attribute = (AccessLevelAttribute)typeDirector.GetCustomAttributes(typeof(Attribute), false)[0];

if (attribute.accessLevel == AccessLevel.High)
{
    Console.WriteLine("Access allowed for Director");
}
else
{
    Console.WriteLine("Access denied for Director");
}

attribute = (AccessLevelAttribute)typeProgrammer.GetCustomAttributes(typeof(Attribute), false)[0];

if (attribute.accessLevel == AccessLevel.High)
{
    Console.WriteLine("Access allowed for Programmer");
}
else
{
    Console.WriteLine("Access denied for Programmer");
}


