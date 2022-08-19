void FillArray(int[] input) 
{  
    int index = 0;
    int length = input.Length;
    for (; index < length; index++) {
        input[index] = new Random().Next(100,999);

    } 
    
}
void FindEven(int[] array) {
    int index = 0;
    int length = array.Length;
    
    for (; index < length; index++ ) {
        while (array[index] % 2 == 0) {
            if (index == length - 1) {
                Console.Write(array[index] + ". ");
                break;
            }
            else {
                Console.Write(array[index] + ", ");
                break;
                }
        }
        
    }
}
Console.Write("Введите желаемое число элементов массива: ");
int index = Convert.ToInt32(Console.ReadLine());
int [] array = new int [index];
FillArray(array);
FindEven(array); 