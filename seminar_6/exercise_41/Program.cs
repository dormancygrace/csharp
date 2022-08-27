Console.Write("Введите числа: ");
string? s = Console.ReadLine();

int[] array = s.Split(',', ' ').Select(n => Convert.ToInt32(n)).ToArray();
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
    if (i == array.Length - 1) {
                Console.Write(array[i] + " => ");
    }
    else Console.Write(array[i] + ", ");
}
 
Console.WriteLine($"{count}");
