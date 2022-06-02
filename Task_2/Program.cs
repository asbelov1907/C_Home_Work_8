//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[] CreateArray()
{
    int[,] array = new int[5, 10];
    int sumLine = 0;
    Random randomaiser = new Random();
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomaiser.Next(1, 10);
            sumLine += array[i, j];
            Console.Write(array[i, j] + " ");
        }
        Console.Write(" -> Сумма равна " + sumLine);
        sumArray[i] = sumLine;
        sumLine = 0;
        Console.WriteLine();
    }
    return sumArray;
}

void MinSumArray(int[] sumArray)
{
    int minSum = sumArray[0];
    int minStrok = 1;
    for (int i = 1; i < sumArray.Length; i++)
    {
        if (sumArray[i] < minSum)
        {
            minSum = sumArray[i];
            minStrok = i + 1;
        }
    }
    Console.WriteLine("Номер строки (не иднекса) с минимальной суммой " + minSum + " равен " + minStrok);
}


int[] sumArray = CreateArray();
Console.WriteLine();
MinSumArray(sumArray);