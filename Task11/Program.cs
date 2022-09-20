// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int rndNum = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерировано число - {rndNum}");

int removeSecondDigit(int num)
{
    int first = num / 100;
    int third = num % 10;
    int result = first * 10 + third;
    return result;
}

Console.WriteLine($"Результат - {removeSecondDigit(rndNum)}");
