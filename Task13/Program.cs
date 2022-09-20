// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool isMultiple(int num1, int num2)
{
    return num1 % num2 == 0;
}
// Console.WriteLine(isMultiple(num, 7));
// Console.WriteLine($"{7*13}");

if (isMultiple(num, 7) && isMultiple(num, 23)) Console.WriteLine($"{num} кратно 7 и 23 одновременно");
else Console.WriteLine("Не кратно!");
