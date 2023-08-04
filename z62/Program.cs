// Напишите программу, которая заполнит спирально массив 4 на 4. 




void GetMassive (int rows, int columns)
        {
            int[,] mas = new int[rows, columns];
            int k = 1; 
            int t = 0;
            int i = 0; 
            int j = 0;
            while (k <= rows * columns)
            {
                for (i = t; i < columns; i++)
                    mas[i, j] = k++;
                j = columns - 1;
                for (i = t + 1; i < rows; i++)
                    mas[j, i] = k++;
                j = rows - 1;
                for (i = columns - 2; i >= t; i--)
                    mas[i, j] = k++;
                 j = t;
                for (i = rows - 2; i > t; i--)
                    mas[j, i] = k++;
                j = rows - 3;
                 for (i = 1; i < columns-2; i++)
                    mas[i, j] = k++;
                 j = columns-2;
                for (i = t+1; i < rows-1; i++)
                    mas[j, i] = k++;
                j = rows-2;               
                for (i = columns - 3; i >= t+1; i--)
                    mas[i, j] = k++;
                 j = t;                
                columns--;
                rows--;
                t++;
                j = t;
            }
            for (i = 0; i < mas.GetLength(0); i++)
            {
                for (j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write("{0,2} ", mas[i, j]);
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
GetMassive (rows, columns);

