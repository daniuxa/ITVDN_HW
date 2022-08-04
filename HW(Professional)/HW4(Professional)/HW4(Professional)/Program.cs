/*Напишите консольное приложение, позволяющие пользователю зарегистрироваться под
«Логином», состоящем только из символов латинского алфавита, и пароля, состоящего из
цифр и символов.*/
using System.Text.RegularExpressions;

string LoginPattern = @"^[A-Za-z]+$";
string PasswordPattern = @"^[A-Za-z0-9]+$";
Regex regex = new Regex(LoginPattern);

string login;
string password;
do
{
    Console.Write("Enter the login: ");
    login = Console.ReadLine();
    if (login == null || regex.IsMatch(login) == false)
    {
        Console.WriteLine("Incorrect input of login\nTry another time");
    }
    else
    {
        break;
    }
} while (true);

regex = new Regex(PasswordPattern);

do
{
    Console.Write("Enter the password: ");
    password = Console.ReadLine();
    if (password == null || regex.IsMatch(password) == false)
    {
        Console.WriteLine("Incorrect input of password\nTry another time");
    }
    else
    {
        break;
    }
} while (true);

Console.WriteLine($"Login: {login}\nPassword: {password}");