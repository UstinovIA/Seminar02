// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
if (number > 99 && number < 1000)
{
    Console.WriteLine($"Вторая цифра числа -> {SecondDigit(number)}");
}
else
{
    Console.WriteLine("Введено не трехзначное число");
}

int SecondDigit(int num)
{
    return (num % 100) / 10;
}