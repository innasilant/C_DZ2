/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.Clear();

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int thirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
Console.WriteLine(thirdRank(number));

if (number < 100)
    Console.WriteLine("третьей цифры в числе нет");