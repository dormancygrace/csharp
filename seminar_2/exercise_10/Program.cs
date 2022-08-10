Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int third = 0;

if (number > 100 && number < 999) {
third = (number / 10) % 10;
Console.Write(third);
}

else 
Console.Write("Вы ввели что-то не то");
