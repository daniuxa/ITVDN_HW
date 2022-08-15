/*Создайте метод, который позволит выполнять над коллекцией целых чисел простейшие
преобразования, возвращая в качестве результата новую коллекцию данных.
Используя возможности функционального программирования, выполните над коллекцией
следующие операции:
- Увеличьте каждое значение в 2 раза
- Замените каждое нечетное значение ближайшим четным (по возрастанию)*/


List<int> vs = new List<int>();
vs.Add(0);
vs.Add(1);
vs.Add(2);
vs.Add(3);
vs.Add(4);

IEnumerable<int> enumerable = vs.Method(0,
                            (col, cur) => { return cur % 2 == 0 ? col[cur] * 2 : col[cur + 1] * 2; },
                            (col, cur) => cur > col.Count - 1,
                            cur => cur + 1);
foreach (var item in enumerable)
{
    Console.WriteLine(item);
}

static class Extension
{
    public static IEnumerable<int> Method <TCollection, TCursor>(this TCollection collection,
                                                                                         TCursor cursor,
                                                                                         Func<TCollection, TCursor, int> getCurrent,
                                                                                         Func<TCollection, TCursor, bool> isFinished,
                                                                                         Func<TCursor, TCursor> advanceCursor)
    {
        while (!isFinished(collection, cursor))
        {
            yield return getCurrent(collection, cursor);
            cursor = advanceCursor(cursor);
        }
    }
}


