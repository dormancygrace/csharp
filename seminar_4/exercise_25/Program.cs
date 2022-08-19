int Exponentiation (int A, int B) {
    int result = Convert.ToInt32(Math.Pow(A, B));   
return result;
}

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write(Exponentiation(A, B));


