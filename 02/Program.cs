// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

System.Console.Clear();
System.Console.Write("[");
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        System.Console.Write($"{res[i]} ");
    }
    return res;
}

int[] array = GetArray(5, 99, 999);

int sumN = 0;

for (int i = 0; i < array.Length; i = i + 2)
{
    sumN = array[i] + sumN;
}
System.Console.WriteLine("]");
System.Console.WriteLine();
System.Console.WriteLine($"Сумма нечётных позиций массива = " + sumN);