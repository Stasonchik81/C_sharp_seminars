// List of square number
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void printListSquares(int num)
{
    for (int i = 1; i <= num; i++)
    {
        if(i == num)Console.Write($"{Math.Pow(i, 2)}");
        else Console.Write($"{Math.Pow(i, 2)},");
    }
}

printListSquares(number);