/*Используя возможности класса Expression, сформируйте выражение, реализующее
следующее математическое выражение: y = 2 * (x – 3) + x – 4.*/

using System.Linq.Expressions;

ParameterExpression x = Expression.Parameter(typeof(int), "x");

var cons1 = Expression.Constant(2);
var cons2 = Expression.Constant(3);
var cons3 = Expression.Constant(4);

var fst = Expression.Subtract(x, cons2);
var snd = Expression.Multiply(fst, cons1);
var trd = Expression.Add(snd, x);
var frth = Expression.Subtract(trd, cons3);

var expression = Expression.Lambda<Func<int, int>>(frth, x);
Console.WriteLine(expression);

Func<int, int> func = expression.Compile();

Console.WriteLine(func(3));