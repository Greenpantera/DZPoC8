// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int MinSum(int [] array)
{
    int count=0;
    int i=0;
    int min = array[i];
    for (i=0; i<array.Length; i++)
     {
        if(min>array[i])
        {
           min = array[i]; 
          }
    } 
    return count+1;
}

void PrintOdnomernMassive(int [] massive)
{
    for(int i=0; i<massive.Length; i++)
    {
     Console.Write($"{massive[i]} ");
       }
}

int [] GetSum(int [,] massive)
{
    int [] array = new int [massive.GetLength(0)]; 
    for(int i=0; i<massive.GetLength(0); i++)
    {
         for(int j=0; j<massive.GetLength(1); j++)
        {
            array[i] += massive[i,j];
        }
         Console.WriteLine($"В строке {i} сумма чисел {array[i]} "); 
    }
    return array;
}

void PrintMassive(int [,] massive)
{
    for(int i=0; i<massive.GetLength(0); i++)
    {
       for(int j=0; j<massive.GetLength(1); j++)
       {
        Console.Write($"{massive[i,j]} ");
       }
       Console.WriteLine();
    }
   }

int [,] DoMassive(int rows, int columns, int minValue, int maxValue)
{
    int [,] result = new int [rows, columns];
    for(int i=0; i<rows; i++)
    {
       for(int j=0; j<columns; j++)
       {
           result[i,j] = new Random().Next(minValue, maxValue+1);
       }
}
return result;
}


int GetInfo (string message)
{
    Console.Write(message);
    int numN = Convert.ToInt32(Console.ReadLine ());
    return numN;
}


int rows = GetInfo("Введите количество строк: ");
int columns = GetInfo("Введите количество столбцов: ");
int [,] massive = DoMassive(rows, columns, 0, 9);
PrintMassive(massive);
int [] array = GetSum(massive);
PrintOdnomernMassive(array);
int i = MinSum(array);
Console.WriteLine($"Минимальная сумма чисел в строке {i}");
