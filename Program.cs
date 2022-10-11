// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int FindDegree(int a, int b)
{
int result = a;
for (int i = 1; i < b; i++)
{
    result = result * a;
}
return result;
}

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = FindDegree (a,b);

Console.WriteLine($"Число {a} в степени {b} равно {result}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int FindSumDigits(int num)
{
    int sum = 0;
    
    while(num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }

    return sum;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {num} равна {FindSumDigits(num)}");
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreateArray(int n)
{
    int [] arr = new int[n];
    for (int i = 0; i < n; i++)
{
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        arr[i] = num;
}
return arr;
}

void PrintArray(int [] arr)
{
    Console.Write($"[");
    for (int i = 0; i < arr.Length; i++)
    Console.Write($"{arr[i]}, ");
    Console.WriteLine($"\b\b]");
 
}

PrintArray(CreateArray(8));


