// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Чтобы был красивый вывод произведения матриц (все двузначные) взял диапозон чисел от 4 до 9

int[,] CreateArray()
{
    int[,] array = new int[5, 10];
    Random randomaiser = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomaiser.Next(4, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();


    }
    return array;
}

void ProductOfMatrix(int[,] matrix1, int[,] matrix2)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {

            Console.Write(matrix1[i, j] * matrix2[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Матрица 1 - >");
int[,] matrix1 = CreateArray();
Console.WriteLine();
Console.WriteLine("Матрица 2 - >");
int[,] matrix2 = CreateArray();
Console.WriteLine();
Console.WriteLine("Произведение матриц - >");
ProductOfMatrix(matrix1, matrix2);
