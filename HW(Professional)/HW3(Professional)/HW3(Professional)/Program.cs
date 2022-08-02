string name = @"D:\Folder";
DirectoryInfo dirInfo;

for (int i = 0; i < 10; i++)
{
    dirInfo = new DirectoryInfo(name + i);
    if (!dirInfo.Exists)
    {
        dirInfo.Create();
    }
}

Console.ReadKey();

for (int i = 0; i < 10; i++)
{
    dirInfo = new DirectoryInfo(name + i);
    if (dirInfo.Exists)
    {
        dirInfo.Delete();
    }
}

