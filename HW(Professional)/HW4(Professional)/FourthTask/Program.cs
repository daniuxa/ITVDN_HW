/*Создайте текстовый файл-чек по типу «Наименование товара – 0.00 (цена) грн.» с
определенным количеством наименований товаров и датой совершения покупки. Выведите на
экран информацию из чека в формате текущей локали пользователя и в формате локали en-
US.*/

using System.Text.RegularExpressions;
using System.Globalization;

string text;
string pattern = @"^(?<ProdName>\S+);Amount (?<AmountProd>\S+);Price (?<PriceProd>\S+) UAH$";
Regex regex = new Regex(pattern);
using (StreamReader streamReader = new StreamReader("text4.txt"))
{
    while ((text = streamReader.ReadLine()) != null)
    {
        Match m = regex.Match(text);
        Console.WriteLine(m.Groups["ProdName"] + " " + m.Groups["AmountProd"] + " " + m.Groups["AmountProd"] + " " + Decimal.Parse(m.Groups["PriceProd"].ToString(), CultureInfo.GetCultureInfo("uk-UA")).ToString(CultureInfo.CurrentCulture));
        Console.WriteLine(m.Groups["ProdName"] + " " + m.Groups["AmountProd"] + " " + Decimal.Parse(m.Groups["PriceProd"].ToString(), CultureInfo.GetCultureInfo("uk-UA")).ToString(CultureInfo.GetCultureInfo("en-US")));
    }
}