/*Напишите приложение для поиска заданного файла на диске. Добавьте код, использующий
класс FileStream и позволяющий просматривать файл в текстовом окне. В заключение
добавьте возможность сжатия найденного файла.*/

/*string? NameOfDirectory = "";

Console.Write("Enter the name of directory: ");
NameOfDirectory = Console.ReadLine();

DirectoryInfo directoryInfo = new DirectoryInfo(NameOfDirectory!);

if (directoryInfo.Exists)
{
    foreach (var item in directoryInfo.GetDirectories())
    {
        Console.WriteLine(item.Name);
    }
}*/

using System.IO.Compression;
using System.Text;

string fileName = Console.ReadLine()!;


using (FileStream fstream = File.OpenRead(fileName))
{
    // выделяем массив для считывания данных из файла
    byte[] buffer = new byte[fstream.Length];
    // считываем данные
    await fstream.ReadAsync(buffer, 0, buffer.Length);
    // декодируем байты в строку
    string textFromFile = Encoding.Default.GetString(buffer);
    Console.WriteLine($"Текст из файла: {textFromFile}");

    Console.WriteLine("Archive it");

    FileStream destination = File.Create(@"D:\archive.zip");

    using (GZipStream compressor = new GZipStream(destination, CompressionMode.Compress))
    {
        fstream.Position = 0;
        int theByte = fstream.ReadByte();
        while (theByte != -1)
        {
            compressor.WriteByte((byte)theByte);
            theByte = fstream.ReadByte();
        }
    }

    destination.Close();
}






