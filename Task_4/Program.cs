// : Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



int[,,] CreateArray()
{
    int[,,] array = new int[4, 4, 4];
    int tempArray;
    Random randomaiser = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int m = 0; m < array.GetLength(2); m++)
           {
               while(true)
               {
                tempArray = randomaiser.Next(10, 100);
                
                    if (BoolArray(array, tempArray))
                    {
                        array[i, j, m] = tempArray;
                    
                        break;
                    }
               }
              
               Console.Write(array[i, j, m] + " (" + i + "," + j + "," + m + ") " );
           }
             Console.WriteLine("");
            
        }
         Console.WriteLine("");
       
    }
    return array;
}

bool BoolArray(int[,,] array, int indexArray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
           for (int m = 0; m < array.GetLength(2); m++)
           {
                
                    if (array[i,j,m] == indexArray)
                    {
                    return false;

                    }
               
           }
        }
    }
    return true;


}



int[,,] array = CreateArray();