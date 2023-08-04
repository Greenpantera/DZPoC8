// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] MatrixMultiplication(int[,] massiveA, int[,] massiveB)
    {       
        if (massiveA.GetLength(1) != massiveB.GetLength(0))
        {
            throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }

       int [,] massiveC = new int[massiveA.GetLength(0), massiveB.GetLength(1)];

        for (int i = 0; i < massiveA.GetLength(0); i++)
        {
            for (var j = 0; j < massiveB.GetLength(1); j++)
            {
                massiveC[i, j] = 0;

                for (int k = 0; k < massiveA.GetLength(1); k++)
                {
                    massiveC[i, j] += massiveA[i, k] * massiveB[k, j];
                }
            }
        }

        return massiveC;
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


int rows = GetInfo("Введите количество строк матрицы А: ");
int columns = GetInfo("Введите количество столбцов матрицы А: ");
int r = GetInfo("Введите количество строк матрицы В: ");
int c = GetInfo("Введите количество столбцов матрицы В: ");
int [,] massiveA = DoMassive(rows, columns, 0, 9);
PrintMassive(massiveA);
Console.WriteLine();
int [,] massiveB = DoMassive(r, c, 0, 9);
PrintMassive(massiveB);
Console.WriteLine();
Console.WriteLine("Произведение матриц будет:");
int [,] massiveC = MatrixMultiplication(massiveA, massiveB);
PrintMassive(massiveC);


