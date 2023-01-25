/* 
Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int InputInt(string mess)
{
    System.Console.Write($"{mess}: ");
    string? inputVal = Console.ReadLine();
    int result = Convert.ToInt32(inputVal);
    return result;
}

bool Validate(int number)
{
    if (number < 1000 && number > 99)
    {
        return true;
    }
    System.Console.WriteLine("Число не трёхзначное!");
    return false;
}

int number = InputInt("Введите трёхзначное число");
if (Validate(number))
{
    number = number / 10;
    number = number % 10;
    System.Console.WriteLine($"Вторая цифра числа - {number}");
}