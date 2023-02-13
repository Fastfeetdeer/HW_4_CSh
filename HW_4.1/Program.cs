// // ДЗ 4.1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Инициализация программы");
int Method1(int a, int b)
{
    int method = 1;
    for (int i = 0; i < b; i++)
    {
        method *= a;
    }
    return method;
}

bool ValidStep(int step)
{
    if(step < 0)
    {
        Console.WriteLine("Степень должна быть натуральным числом");
        return false;
    }
    return true;
}
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень");
int b = int.Parse(Console.ReadLine());

Console.WriteLine($"Число {a} в степени {b}, равно:");

if (ValidStep(b))
{
    Console.WriteLine($"{Method1(a, b)}");
}
Console.WriteLine("Программа завершила работу");