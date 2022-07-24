IEnumerable<int> Enumerator(int[] vs)
{
    if (vs.Length != 0)
    {

        for (int i = 0; i < vs.Length; i++)
        {
            if (vs[i] % 2 == 0)
            {
                yield return vs[i];
            }
        }
    }
    else
    {
        yield break;
    }
}

int[] num = { 1, 2, 3, 4, 5 };

foreach (var item in Enumerator(num))
{
    Console.WriteLine(item);
}