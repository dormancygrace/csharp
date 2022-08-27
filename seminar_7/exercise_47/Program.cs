void FillArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-10,10) + new Random().NextDouble();
            array[i,j] = Math.Round(array[i,j] * 10) /10;
        }
    }
}
void PrintArray (double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    Console.WriteLine();
    }
}  

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];
FillArray(array);
PrintArray(array);


