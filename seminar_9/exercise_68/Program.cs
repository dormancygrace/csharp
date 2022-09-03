long Akkerman (long m, long n)
            {
                if (m == 0)
                {
                    return n + 1;
                }

                if (m > 0 && n == 0)
                {
                    return Akkerman(m - 1, 1);
                } 
                
                if (m > 0 && n > 0)
                {
                    return Akkerman(m - 1, Akkerman(m, n - 1));
                } 
                
                return Akkerman(m,n);
            }


Console.Write($"Введите M: ");
long m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите N: ");
long n = Convert.ToInt32(Console.ReadLine());

if (m >= 0 && n >= 0) 
{
Console.Write($"m = {m}, n = {n} -> A({m},{n}) = {Akkerman(m,n)}");
}
else
Console.Write($"Одно или оба числа < 0");