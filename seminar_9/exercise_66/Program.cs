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
    Console.Write($"Всего одно число, сумму не вычислить");
}


if (diff > 0)
{
    int result = 0;
    
    for (int i = m; i <= n; i++)
    {
        result += i;
    }

    Console.Write($"M = {m}; N = {n}. -> {result}");
}