Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 10000 && number <= 99999) {
    int first = number / 10000;
    int second = (number / 1000) % 10;
    int fourth = (number % 100) / 10;
    int fifth = number % 10;
    if (first == fifth && second == fourth) {
        Console.Write(number + " -> да" );
    }
    
    else 
    Console.Write(number + " -> нет"); 
}
else 
Console.Write("Вы ввели что-то не то");