// Программа принимает цыфру дня недели, и проверяет, является ли этот день выходным

Console.Clear();

Console.WriteLine("Введите номер дня недели:");
int number = int.Parse(Console.ReadLine()!);

if (number > 5 && number < 8)
    {
        Console.WriteLine ($"Да, {number}-ой день недели - выходной!");
    }
 else if (number >= 1 && number < 6)
    {
        Console.WriteLine ($"Нет, {number} - рабочий день недели!");
    }
else if (number > 7)
{
    Console.WriteLine ($"В неделе всего 7 дней!");
}