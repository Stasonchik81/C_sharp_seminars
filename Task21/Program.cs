// distance between two points
Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
int[] point1 = new [] {x1, y1};
int[] point2 = new [] {x2, y2};

double getDistance(int[]p1, int[]p2)
{
    double result = Math.Round(Math.Sqrt(Math.Pow(p2[0] - p1[0], 2) + Math.Pow(p2[1] - p1[1], 2)), 2);
    return result;
}
double distance1 = getDistance(point1, point2);
Console.WriteLine($"Distance between two points: {distance1}");