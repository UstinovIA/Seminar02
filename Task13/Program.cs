// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string output = ThirdDigit(number)>=0 ? $"Третья цифра {number} -> {ThirdDigit(number)}" : "Третьей цифры нет";
Console.WriteLine(output);

int ThirdDigit(int num)
{
    if (num < 0) num = -num;
    if (num >= 100)
    {
        while (num >= 1000)
        {
            num /= 10;
        }
        return num % 10;
    }
    else
    {
        return -1;
    }
}
