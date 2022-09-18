// Integer numbers from -N to N
Console.WriteLine("Введите целое чило: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = -num; i <= num; i++)
{
    Console.Write($"{i},");
}
