//Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите цифру, обозначающую день недели и узнаем является ли этот день выходным: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
        Console.WriteLine($"{dayNumber} -> да");
    else if (dayNumber < 1 || dayNumber > 7)
        Console.WriteLine("Не верный ввод!");
    else 
        Console.WriteLine($"{dayNumber} -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);