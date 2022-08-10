/*Создайте консольное приложение, которое в различных потоках сможет получить доступ к 2-м
файлам. Считайте из этих файлов содержимое и попытайтесь записать полученную
информацию в третий файл. Чтение/запись должны осуществляться одновременно в каждом
из дочерних потоков. Используйте блокировку потоков для того, чтобы добиться корректной
записи в конечный файл.*/

object locker = new Object();

void ReadFromFile(string FileName)
{
    string Text = File.ReadAllText(FileName);
    lock (locker)
    {
        using (StreamWriter writer = new StreamWriter("FileIn.txt", true))
        {
            writer.WriteLine(Text);
        }
    }
}

Thread thread1 = new Thread(() => { ReadFromFile("FileOut1.txt"); });
Thread thread2 = new Thread(() => { ReadFromFile("FileOut2.txt"); });

thread1.Start();
thread2.Start();
