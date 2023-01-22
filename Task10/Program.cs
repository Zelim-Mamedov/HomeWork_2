// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

// -------------------------------------------------------------------
int SecondNumber(int digit)
{
    while (digit >= 100)
        digit /= 10;
    int totalResult = digit % 10;
    return (totalResult);
}

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int inputNumber = SecondNumber(num);
if (num > 99 || num < -99)
    Console.WriteLine($"{num} -> {inputNumber}");
else
    Console.WriteLine("Вы ввели меньше трёх цифр! ");