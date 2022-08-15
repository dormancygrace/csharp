double LengthBetweenPoints (int x1, int y1, int z1, int x2, int y2, int z2) {
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}
Console.Write("Введите координату точки A по оси x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки A по оси y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки A по оси z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = LengthBetweenPoints(x1,y1,z1,x2,y2,z2);
Console.Write(result);