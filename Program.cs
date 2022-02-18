// Найти сумму чисел одномерного массива, стоящих на нечётной позиции.

Console.Clear();

Random rnd = new Random();

Console.Write("На сколько элементов задаём массив? ");
int elem = int.Parse(Console.ReadLine());
int[] array = new int[elem];

for (int i = 0; i < elem; i++)
{
    array[i] = rnd.Next(1, 10);
    Console.Write(array[i] + "\t");
}

int sum = 0;
for (int j = 1; j < elem; j+=2)
{
    sum = sum+=array[j];
}

Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетной позиции - {sum}");