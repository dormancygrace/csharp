Console.Write($"Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int diff = n - m;

if (diff < 0)
{
    Console.Write($"Натуральных чисел нет");
}

if (diff == 0)
{
    Console.Write($"M = {m}; N = {n}. -> {m}");
}


if (diff > 0)
{
    Console.Write($"M = {m}; N = {n}. -> ");
    for (int i = m; i <= n; i++)
    {
        if (i < n)
        {
            Console.Write($"{i}, ");
        }
        else Console.Write($"{i}");
        
    }
    


}