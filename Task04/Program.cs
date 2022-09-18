// Last digit of number
Console.WriteLine("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num % 10;
Console.WriteLine($"Последняя цифра - {result}.");
