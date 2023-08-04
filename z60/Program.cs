// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void PrintMassive(int [, ,] massive)
{
    for(int i=0; i<massive.GetLength(0); i++)
    {
       for(int j=0; j<massive.GetLength(1); j++)
       {
            for(int k=0; k<massive.GetLength(2); k++)
            {
            Console.Write($"{massive[i,j,k]}({i},{j},{k}) ");
            }
       }
       Console.WriteLine();
    }
   }

void GetArray(int[,,] result)
{
    int[] temp = new int[result.GetLength(0) * result.GetLength(1) * result.GetLength(2)];
    if (temp.Length <= 90)
    {
        for (int i = 0; i < temp.GetLength(0); i++)
        {
            temp[i] = new Random().Next(10, 100);
            if (i >= 1)
            {
                for (int j = 0; j < i; j++)
                {
                    while (temp[i] == temp[j])
                    {
                        temp[i] = new Random().Next(10, 100);
                        j = 0;
                    }
                }
            }
        }

        int count = 0;
        for (int x = 0; x < result.GetLength(0); x++)
        {
            for (int y = 0; y < result.GetLength(1); y++)
            {
                for (int z = 0; z < result.GetLength(2); z++)
                {
                    result[x, y, z] = temp[count];
                    count++;
                }
            }
        }
    }
}

int [, ,] DoMassive(int a, int b, int c, int minValue, int maxValue)
{
    int [, ,] result = new int [a, b, c];
    for(int i=0; i<a-1; i++)
    {
       for(int j=0; j<b-1; j++)
       {
            for(int k=0; k<c-1; k++)
             {
             result[i,j,k] = new Random().Next(minValue, maxValue+1);
             }
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


int a = GetInfo("Введите A: ");
int b = GetInfo("Введите B: ");
int c = GetInfo("Введите C: ");
int [, ,] massive = DoMassive(a, b, c, 10, 99);
GetArray(massive);
PrintMassive(massive);

