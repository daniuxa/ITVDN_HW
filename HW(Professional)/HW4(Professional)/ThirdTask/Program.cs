/*Напишите шуточную программу «Дешифратор», которая бы в текстовом файле могла бы
заменить все предлоги на слово «ГАВ!».*/

using System.Text.RegularExpressions;

string content;
string pattern = @"(\sна\s|\sв\s|\sза\s|\sоколо\s)";
string replace = " Гав ";
Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

using (StreamReader streamReader = new StreamReader("text3.txt"))
{
    content = streamReader.ReadToEnd();
}

Console.WriteLine(regex.Replace(content, replace)); 