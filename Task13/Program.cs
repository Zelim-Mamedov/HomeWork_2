// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdNumber(int digit)
{
    while (digit > 999 || digit < -999)
        digit = digit / 10;
    int totalResult = Math.Abs(digit % 10);
    return (totalResult);

}

Console.Clear();
Console.WriteLine("Будем выводить третью цифру введенного числа! ");
Console.Write("Введите число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
int inputNumber = ThirdNumber(anyNumber);
if (anyNumber > 99 || anyNumber < -99)
    Console.WriteLine($"{anyNumber} -> {inputNumber}");
    else
    Console.WriteLine($"{anyNumber} -> третьей цифры нет");



// ВТОРОЙ СПОСОБ:
// Просто сохранил это здесь для образца!

// Console.Clear();
// Console.WriteLine("Будем выводить третью цифру введенного числа! ");
// Console.Write("Введите число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2)
//     Console.WriteLine($"{anyNumber} -> " + anyNumberText[2]);
// else
//     Console.WriteLine($"{anyNumber} -> третьей цифры нет");