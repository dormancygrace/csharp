void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-10,10);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
void PrintArray (int[,] array)
{
    double result = 0.0;
    // int rows = array.GetLength(0);
    double[] sum = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[j] += array[i,j];
            Console.WriteLine("Сумма = " + sum[j]);
        }
    }
    Console.WriteLine();
    

    for (int k = 0; k < array.GetLength(0); k++)
    {
        result = sum[k] / array.GetLength(0);
        Console.Write(result + ", ");
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);


