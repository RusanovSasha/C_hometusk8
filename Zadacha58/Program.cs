//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.(посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int matrixSize = InputInt("Введите размерность матриц: ");
int[,] matrixFirst = new int[matrixSize, matrixSize];
int[,] matrixSecond = new int[matrixSize, matrixSize];
FillArrayRandomNumbers(matrixFirst);
FillArrayRandomNumbers(matrixSecond);
int[,] matrixCompos = new int[matrixSize, matrixSize];

for (int i = 0; i < matrixSize; i++)
{
    for (int j = 0; j < matrixSize; j++)
    {
        for (int k = 0; k < matrixSize; k++)
        {
            matrixCompos[i, j] = matrixCompos[i, j] + (matrixFirst[i, k] * matrixSecond[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray(matrixFirst);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(matrixSecond);
Console.WriteLine();
Console.WriteLine("Произведение двух матриц А*В");
PrintArray(matrixCompos);