// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[5, 10] - Длина массива.
// array,0 - 0 это индекс строки, с которой начинается сортировка. Он пригодился для рекурсии в 57 строчке кода.
// Как итог программа выводит сначала созданный рандомно массив, а потом сортирует его и выводит повторно.
// Интересное задание, теперь я осознанно понял зачем нужна рекурсия:) 
int[,] array = new int[5, 10];
    CreateArray();
    Console.WriteLine();
    SortArray(array,0);

int[,] CreateArray()
{
    
    Random randomaiser = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomaiser.Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();


    }
    return array;
}

void SortArray(int[,] array, int oneNumber)
{
    if(oneNumber<array.GetLength(0))
    {
        int min = array[oneNumber,0];
        int index = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            min=array[oneNumber,i];
            for (int j = 1+index; j < array.GetLength(1); j++)
            {
                if (array[oneNumber, j] < min)
                    {
                        min = array[oneNumber, j];
                        array[oneNumber,j] = array[oneNumber,index];
                        array[oneNumber,index] = min;
                        
                    
                    }
            }
            index += 1;
            Console.Write(min + " ");
        }
        

    }
    else return;
    Console.WriteLine();
    SortArray(array,oneNumber+1);
}


