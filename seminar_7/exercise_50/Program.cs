void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-10,10);
        }
    }
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

FillArray(array);

Console.Write("Введите строку элемента: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите столбец элемента: ");
int column = Convert.ToInt32(Console.ReadLine());

if (row <= array.GetLength(0) && column <= array.GetLength(1)) 
{
    Console.Write(array[row, column]);
}

else Console.Write("Такого элемента в массиве нет");

