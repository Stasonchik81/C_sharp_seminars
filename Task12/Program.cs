// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.WriteLine("Введите два числа: ");
int first = Convert.ToInt32(Console.ReadLine());
int second = Convert.ToInt32(Console.ReadLine());

bool isMultiple(int num1, int num2)
{
    return num1 % num2 == 0;
}

if (!isMultiple(first, second)) Console.WriteLine($"Не кратно, остаток - {first % second}");
else Console.WriteLine("Кратно!");