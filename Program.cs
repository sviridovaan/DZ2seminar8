//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
void ShowArray(int [,] array)
{
    for (int i = 0; i<array.GetLength(0) ; i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int [,] array = new int [rows, columns]; 
    for (int i = 0; i<rows ; i++)
    {
        for (int j = 0; j<columns; j++)
        {
            array [i,j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return array;
}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = EnterNumber("Введите значение m: ");
int n = EnterNumber("Введите значение n: ");

int [,] matrix= CreateRandomArray(m, n, 1, 5);
Console.WriteLine("Рандомная матрица: ");
ShowArray(matrix);

void SumRowsReturn(int [,] matrix)
{
    int minsum = 0;
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        if (i == 0)
        {
            minsum = sum;
        }
        if (sum<minsum)
        {
            minsum = sum;
            index = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов {index+1}");
}
SumRowsReturn(matrix);