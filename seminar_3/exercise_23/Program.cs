void FillArray(int[] result) 
{
    int length = result.Length;
    int index = 0;
    int count = 1;
    while (index < length) {
        result[index] = Convert.ToInt32(Math.Pow(count, 3));
        index++;
        count++;
        
    }
}
void PrintArray(int[] numbers) 
{
    int cou = numbers.Length;
    int position = 0;
    Console.Write(cou + " -> ");
    while (position < cou) {
         if (position < cou - 1) {
            Console.Write(numbers[position] + ", ");
            position++;
        }
        else if (position < cou) {
            Console.Write(numbers[position] + ".");
            position++;
        }       
    }
}
Console.Write("Введите число: ");
int baseN = Convert.ToInt32(Console.ReadLine());
int[] array = new int [baseN];
    FillArray(array);
    PrintArray(array);