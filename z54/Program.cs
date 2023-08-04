// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] MinNum(int [,] massive)
{
for(int i=0; i<massive.GetLength(0); i++) 
    {
       for(int j=0; j<massive.GetLength(1); j++)
        {
            for(int k=0; k<massive.GetLength(1)-j-1; k++) 
            {
              if (massive[i,k] >massive[i, k+1]) 
                {
                int temp = massive[i,k];
                massive[i,k] =  massive[i,k+1];
                massive[i,k+1] = temp;  
                }
            }           
        }
    }
    return massive;
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
Console.WriteLine();
MinNum(massive);
PrintMassive(massive);
