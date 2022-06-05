// Заполните спирально массив 4 на 4.


int[,] CreateArray()
{
    int[,] array = new int[4,4];
    Random randomaizer = new Random();
    array[0,0] = randomaizer.Next(1,10);
    array[0,1] = randomaizer.Next(1,10);
    array[0,2] = randomaizer.Next(1,10);
    array[0,3] = randomaizer.Next(1,10);
    array[1,3] = randomaizer.Next(1,10);
    array[2,3] = randomaizer.Next(1,10);
    array[3,3] = randomaizer.Next(1,10);
    array[3,2] = randomaizer.Next(1,10);
    array[3,1] = randomaizer.Next(1,10);
    array[3,0] = randomaizer.Next(1,10);
    array[2,0] = randomaizer.Next(1,10);
    array[1,0] = randomaizer.Next(1,10);
    array[1,1] = randomaizer.Next(1,10);
    array[1,2] = randomaizer.Next(1,10);
    array[2,2] = randomaizer.Next(1,10);
    array[2,1] = randomaizer.Next(1,10);
   return array;
}
void PrintArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine("");
    }
}

int[,] array = CreateArray();
PrintArray(array);

