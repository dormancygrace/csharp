Console.Write("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 || day > 7) {
Console.Write("Вы ввели что-то не то");
}

if (day >= 1 && day <= 7 ) {
    if (day == 6 || day == 7) {
        Console.Write(day + " -> да");
    }
    else
    Console.Write(day + " -> нет");
}