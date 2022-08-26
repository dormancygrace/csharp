void FillArray(double[] input) 
{  
    int length = input.Length;
    for (int i = 0; i < length; i++) {
        input[i] = new Random().Next(-214748364,214748364) + new Random().NextDouble();
    }
}

double[] SortArray(double[] array, int leftIndex, int rightIndex)
{
    var i = leftIndex;
    var j = rightIndex;
    var pivot = array[leftIndex];
    while (i <= j)
    {
        while (array[i] < pivot)
        {
            i++;
        }
        
        while (array[j] > pivot)
        {
            j--;
        }
        if (i <= j)
        {
            double temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            i++;
            j--;
        }
    }
    
    if (leftIndex < j)
        SortArray(array, leftIndex, j);
    if (i < rightIndex)
        SortArray(array, i, rightIndex);
    return array;
}

Console.Write("Введите желаемое число элементов массива: ");
int index = Convert.ToInt32(Console.ReadLine());
double [] array = new double [index];
FillArray(array);
SortArray(array, 0, array.Length - 1);
double max = array[array.Length - 1];
double min = array[0];
for (int i = 0; i < array.Length; i++) {
    Console.WriteLine(array[i]);
}
Console.WriteLine("Разность = " + (max - min));