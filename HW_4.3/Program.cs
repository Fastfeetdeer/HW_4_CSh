// ДЗ 4.3.  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Инициализация программы");
int [] GetArray(int Length, int min, int max)
{
    int [] array = new int [Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void WriteArray(int [] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}, ");
    Console.WriteLine("]");
}

Console.WriteLine("Введите длинну массива");
int Length = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальное значение массива");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечное значение массива");
int max = int.Parse(Console.ReadLine());

int [] array = GetArray(Length, min, max);
WriteArray(array);

Console.WriteLine("Программа завершила работу");
