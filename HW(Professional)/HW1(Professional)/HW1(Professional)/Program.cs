IEnumerable<int> ExtraTask(int[] items)
{
    for (int i = 0; i < items.Length; i = i + 2)
    {
        yield return items[i] * items[i];
    }
}

int[] vs = new int[] { 1, 2, 3, 4, 5 };

foreach (var item in ExtraTask(vs))
{
    Console.WriteLine(item);
}
