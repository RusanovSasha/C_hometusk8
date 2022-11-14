//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] MakeArray(int x, int y)
{
    int[,] result = new int[x, y];
    Random rnd = new Random();
    for (int j = 0; j < x; j++)
        for (int i = 0; i < y; i++)
        {
            result[j, i] = rnd.Next(10);
        }
    return result;
}

void PrintArray(int[,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    for (int j = 0; j < x; j++)
    {
        for (int i = 0; i < y; i++)
        {
            Console.Write($"{array[j, i]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortArray(int[,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int temp;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y - 1; j++)
        {
            for (int z = 0; z < y - 1; z++)
            {
                if (array[i, z] < array[i, z + 1])
                {
                    temp = array[i, z];
                    array[i, z] = array[i, z + 1];
                    array[i, z + 1] = temp;
                }
            }
        }
    }
    return array;
}

Console.Clear();
Console.WriteLine("Создаем двумерный массив m x n.");

Console.WriteLine();
Console.WriteLine("Введите значение m");
int m = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Введите значение n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Создаем двумерный массив {m} на {n}");

int[,] arr = MakeArray(m, n);

Console.Clear();
Console.WriteLine("Был создан массив");
PrintArray(arr);

Console.WriteLine();
Console.WriteLine("Массив после сортировки");
arr = SortArray(arr);
PrintArray(arr);
