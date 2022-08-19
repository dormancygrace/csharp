Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int op = 0;

if (number < 0) {
    number = number * -1;
 }

    while (number > 0)
            {
 
                op = op + number % 10;
                number = number / 10;
 
            }
 Console.Write(op);

