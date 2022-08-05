Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

int count = 0;

    while (count <= a) {
        if (count % 2 == 0) {
            Console.Write(count);
        }
        else Console.Write(" , ");
        count += 1;    
    }