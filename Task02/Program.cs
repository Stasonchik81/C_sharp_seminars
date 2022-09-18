// name of week day
string[] days = new[] { "monday", "tuesday", "wensday", "thirsday", "friday", "satueday", "sunday" };

Console.Write("Введите номер дня недели: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 & num < 7) Console.WriteLine($"Сегодня {days[num - 1]}!");

else Console.Write("Такого дня не существует");

