//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int[,] MakeArraySpiral(int arraySize)
{
    int[,] array = new int[arraySize, arraySize];
    int x = 0;
    int y = 0;
    int up = 0;
    int down = arraySize - 1;
    int left = 0;
    int right = arraySize - 1;

    string way = "right";
    int lenghtArray = arraySize * arraySize;
    int i = 0;
    while (i < lenghtArray)
    {
        if (way == "right")
        {
            array[y, x] = i;
            if (x == right)
            {
                way = "down";
                up++;
            }
            else
            {
                x++;
                i++;
            }
        }
        if (way == "down")
        {
            array[y, x] = i;
            if (y == down)
            {
                way = "left";
                right--;
            }
            else
            {
                y++;
                i++;
            }
        }
        if (way == "left")
        {
            array[y, x] = i;
            if (x == left)
            {
                way = "up";
                down--;
            }
            else
            {
                x--;
                i++;
            }
        }
        if (way == "up")
        {
            array[y, x] = i;
            if (y == up)
            {
                way = "right";
                left++;
            }
            else
            {
                y--;
                i++;
            }
        }
    }
    return (array);
}

void PrintArray(int[,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    for (int j = 0; j < x; j++)
    {
        for (int i = 0; i < y; i++)
        {
            if (array[j, i] < 10) { Console.Write($"0{array[j, i]} "); }
            else { Console.Write($"{array[j, i]} "); }
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.WriteLine("Введите мерность массива");

int size = int.Parse(Console.ReadLine());

int[,] arr = MakeArraySpiral(size);

Console.Clear();
Console.WriteLine("Был создан массив");
PrintArray(arr);