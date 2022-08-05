Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = int.Parse( Console.ReadLine()!);

Console.Write("Введите третье число: ");
int c = int.Parse( Console.ReadLine()!);

    if (a > b && a > c) {
        Console.Write("max = ");
        Console.Write(a);
    }
    else if (b > a && b > c) {
        Console.Write("max = ");
        Console.Write(b);
    }
    else if (c > a && c > b) {
        Console.Write("max = ");
        Console.Write(c);
    }
