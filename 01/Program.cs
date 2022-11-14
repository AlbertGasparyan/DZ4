// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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

int count = 0;
foreach (int el in array)
{
    if (el % 2 == 0)
    {
        count += 1;
    }
}
if(count>0)
{
    System.Console.Write($"В массиве количество чётных числе = "+count);
}    

