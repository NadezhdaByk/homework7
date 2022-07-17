// программа, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
Console.WriteLine("Введите кол-во строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, которое надо найти");
int num = Convert.ToInt32(Console.ReadLine());

int[,] gatArray(int mLocal, int nLocal)
{
    int[,] result = new int[mLocal, nLocal];
    for (int i = 0; i < mLocal; i++)
    {
        for (int j = 0; j < nLocal; j++)
        {
            result[i, j] = new Random().Next(0,9);
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
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindNumInArray(int [,] inArray, int findNum)
{
    int a=0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray [i,j] == findNum) {
                Console.Write($"число {findNum} находится в {i} строчке {j} столбце");
                a = 1;
            }
        }
    }
    if (a!=1){Console.Write($"числа {findNum} в массиве нет");}
}
int [,] array = gatArray(m,n);
printArray(array);
FindNumInArray(array,num);