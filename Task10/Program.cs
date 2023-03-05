// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
string output = SecondDigit(number) >= 0 ? $"Вторая цифра числа {number} -> {SecondDigit(number)}" : "Введено не трехзначное число";
Console.WriteLine(output);

int SecondDigit(int num)
{
    if (num < 0) num = -num;
    if (num >= 100 && num < 1000)
    {
        return (num % 100) / 10;
    }
    else
    {
        return -1;
    }
}