Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

int count = 1;

    while (count <= a) {
        if (count % 2 == 0 && count < a) {
            Console.Write(count);   
        }
        if (count % 2 == 0 && count == a) {
            Console.Write(count + ".");
            count++;
        }
        if (a <= 1) {
            Console.Write("вы ввели cлишком маленькое число");
        }
        if (count % 2 != 0 && count == a) {
            Console.Write(".");
            count++;
        }
        if (count % 2 != 0 && count < a && count > 1) {
            Console.Write(", ");
            count++;
        }
       
        else 
        count++;    
    }