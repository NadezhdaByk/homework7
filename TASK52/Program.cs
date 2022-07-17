// Задает двумерный массив из целых чисел. 
// Находит среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Введите кол-во строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] gatArray(int mLocal, int nLocal)
{
    int[,] result = new int[mLocal, nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            result[i, j] = new Random().Next(0,99);
        }
    }
    return result;
}
void printArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}

double [] MeanColumn(int [,] inArray)
{
    double [] sum = new double [inArray.GetLength(1)];
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double summ=0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            summ = summ + inArray [i,j];
        }
        sum[j]=summ/inArray.GetLength(0);
    }
    return sum;
}

int [,] array = gatArray(m,n);
printArray(array);
Console.WriteLine();
Console.WriteLine(string.Join(", ",MeanColumn(array)));