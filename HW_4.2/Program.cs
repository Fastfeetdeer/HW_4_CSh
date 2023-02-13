// ДЗ 4.2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Инициализация программы");
int SumOfDig(int a)
{
    int sumdig = 0;
    while ( a > 0 )
    {
        sumdig += a % 10;
        a = a / 10;
    }
    return sumdig;
}

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма чисел в цифре {a} = {SumOfDig(a)}");
Console.WriteLine("Программа завершила работу");