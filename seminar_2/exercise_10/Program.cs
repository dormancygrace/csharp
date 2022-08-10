Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int second = 0;

if (number > 100 && number < 999) {
second = (number / 10) % 10;
Console.Write(second);
}

else 
Console.Write("Вы ввели что-то не то");
