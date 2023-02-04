// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int number = numberRequest("Введите трехзначное число: ");
if (number/100>=1)
{
    int secondDigit = getSecondDigit(number);
    Console.WriteLine ($"Вторая цифра чила {number} = {secondDigit}");
}
else
{
     Console.WriteLine ($"Число не трехзначное");
}

int numberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int getSecondDigit (int number)
{
    int secondDigit = (number%100)/10;
    return secondDigit;
}