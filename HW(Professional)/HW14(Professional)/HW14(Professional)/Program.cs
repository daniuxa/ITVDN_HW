/*Создайте массив чисел размерностью в 1 000 000 или более. Используя генератор случайных
чисел, проинициализируйте этот массив значениями. Создайте PLINQ запрос, который
позволит получить все нечетные числа из исходного массива.*/

int[] vs = new int[1000000];
Random random = new Random();
Parallel.For(0, vs.Length, i => vs[i] = random.Next(0, 100));

//ParallelQuery<int> parallelVs = vs.AsParallel().Where(x => x % 2 == 0);
ParallelQuery<int> parallelVs = from x in vs.AsParallel()
                                where x % 2 == 0
                                select x;

Parallel.ForEach(parallelVs, i => Console.Write(i + "  "));