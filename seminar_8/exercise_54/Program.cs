int[,] CreateMatrix(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1,10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Отсортированный массив");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] SortRowElementsFromMinToMax(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            int minIndex = k;
            
            for (int j = k + 1; j < array.GetLength(1); j++)
            {
                if (array[i, j] < array[i,minIndex]) minIndex = j;
            }
            if (minIndex != k)
            {
                int temp = array[i, k];
                array[i, k] = array[i, minIndex];
                array[i, minIndex] = temp;
            }
        }
    }
    return array;
}
Console.WriteLine("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateMatrix(m, n);
PrintArray(array);
array = SortRowElementsFromMinToMax(array);
PrintArray(array);