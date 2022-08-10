Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int third = 0;
int calc = number;

if (number >= 100) {
    while (calc > 999) {
        calc = calc /10;
    }

    third = calc % 10;
    Console.Write(number+ " -> " + third);
}

else 
 Console.Write(number + " -> третьей цифры нет");
