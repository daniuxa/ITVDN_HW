using HW15_Essential_Exceptions;

Calculator calculator = new Calculator();

try
{
    Console.WriteLine(calculator.Div(1, 0));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}