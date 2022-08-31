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
    int rows = array.GetLength(0);
    int[] sum = new int[rows];
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] += array[j,i];
            Console.WriteLine("Сумма = " + sum[i]);
        }
    }
    Console.WriteLine();
    

    for (int k = 0; k < rows; k++)
    {
        result = sum[k] / rows;
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


