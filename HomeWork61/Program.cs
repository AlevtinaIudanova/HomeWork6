/*Показать двумерный массив размером m×n заполненный вещественными числами*/
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble();
            //Console.Write($"{matr[i, j]} ");
        }
    }
}

double[,] matrix = new double[3, 4];

//PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);

PrintArray(matrix);
