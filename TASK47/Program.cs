// Задает двумерный массив размером m×n,
// заполненный случайными вещественными числами.
Console.WriteLine("Введите кол-во строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());

double[,] gatArray(int mLocal, int nLocal)
{
    double[,] result = new double[mLocal, nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            Random rnd = new Random();
            double arr = rnd.NextDouble()*((10)-(-10))+(-10);
            result[i, j] = arr;
        }
    }
    return result;
}

void printArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
printArray(gatArray(m, n));