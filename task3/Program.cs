//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
int dayofweek = numberRequest("Введите порядковое число дня недели: ");
if (dayofweek <= 0 || dayofweek > 7)
{    
    Console.WriteLine ("Ошибка: Такого количества дней в неделе нет!");
}
else if (dayofweek > 5) 
{
    Console.WriteLine ("Ответ: Выходной день.");
}
else
{
    Console.WriteLine ("Ответ: Будний день.");
}

int numberRequest(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
