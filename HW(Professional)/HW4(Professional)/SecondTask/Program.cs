/*Напишите программу, которая бы позволила вам по указанному адресу web-страницы
выбирать все ссылки на другие страницы, номера телефонов, почтовые адреса и сохраняла
полученный результат в файл.*/

using System.Linq;
using System.Text.RegularExpressions;

string SitePattern = @"href='(?<link>\S+)'";
string PhonePattern = @"[(]\d{3}[)] \d{3}-\d{2}-\d{2}|[+]\d{12}";
string EmailPattern = @"[a-z0-9]+@[a-z]+.[a-z]+";

List<string> Phones = new List<string>();
List<string> Sites = new List<string>();
List<string> Emails = new List<string>();

Regex regexSite = new Regex(SitePattern);
Regex regexPhone = new Regex(PhonePattern);
Regex regexEmail = new Regex(EmailPattern);


string text;
using (StreamReader reader = new StreamReader("text.txt"))
{
    text = reader.ReadToEnd();
}

string[] words = text.Split('\n');
foreach (string word in words)
{
    if (regexSite.IsMatch(word))
    {
        Sites.Add(word);
    }
    else if (regexPhone.IsMatch(word))
    {
        Phones.Add(word);
    }
    else if (regexEmail.IsMatch(word))
    {
        Emails.Add(word);
    }
}

Console.ReadKey();
