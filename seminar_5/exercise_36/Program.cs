void FillArray(int[] input) 
{  
    int length = input.Length;
    for (int i = 0; i < length; i++) {
        input[i] = new Random().Next(-214748364,214748364);
        if (i == length - 1) {
                Console.Write(input[i] + " -> ");
                break;
        }
            else {
                Console.Write(input[i] + ", ");
            } 
    }
}
void FindOddIndexSum(int[] array) {
    int length = array.Length;
    int sum = 0;
    for (int i = 0; i < length; i++ ) {
        if (i % 2 == 0) {
            sum = sum + array[i];
        } 
    }
    Console.Write(sum); 
}
Console.Write("Введите желаемое число элементов массива: ");
int index = Convert.ToInt32(Console.ReadLine());
int [] array = new int [index];
FillArray(array);
FindOddIndexSum(array); 