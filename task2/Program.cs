// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6
//8985663532 
Console.WriteLine("Введите число : ");
string input = Console.ReadLine();
validateNumber(input);
printThirdCharacter(input);

void validateNumber(string input)
{
    Convert.ToInt32(input);
}

void printThirdCharacter(string input)
{
    if (input.Length < 3) {
        Console.WriteLine ("Третьей цифры нет.");
        return;
    }
    Console.WriteLine ($"Третья цифра чила {input} = {input[2]}");
}