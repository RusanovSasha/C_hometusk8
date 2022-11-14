//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void FindLine(int[,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int minLine = -1; // Будем хранить номер строки с максимальной суммой
    int minLineSum = -1; // Будем хранить сумму элементов минимальной строки
    int thisLineSum; // Будем хранить сумму элементов текущей строки
    for (int i = 0; i < x; i++)
    {
        thisLineSum = 0;
        for (int j = 0; j < y; j++)
        {
            thisLineSum += array[i, j];
        }

        if ((minLine == -1) || (minLineSum > thisLineSum))
        {
            minLineSum = thisLineSum;
            minLine = i;
        }
    }
    Console.WriteLine($"с наименьшей суммой элементов: {minLine + 1} строка "); // выводим значени +1, так как то, что для пользователя 1 строка, для массива 0-вая. Согласно примера, счет нумерации строк при выводе должен идти с 1, а не 0.
}

Console.Clear();


// объявляем количество строк и столбцов в переменной. При необходимости эти значения можно изменять.

int m = 4;
int n = 3;

Console.WriteLine($"Создаем двумерный прямоугольный массив {m} x {n}:");

int[,] arr = MakeArray(m, n);

PrintArray(arr);

FindLine(arr);
