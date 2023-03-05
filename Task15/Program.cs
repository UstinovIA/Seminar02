// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day <= 7)
{
    string output = Weekend(day) ? "Да" : "Нет";
    Console.WriteLine(output);
}
else
{
    Console.WriteLine("Введенно некорректное значение");
}

bool Weekend(int numberDay)
{
    if (numberDay <= 5) return false;
    else return true;
}