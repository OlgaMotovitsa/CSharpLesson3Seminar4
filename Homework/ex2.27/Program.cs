// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число");

int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num1} -> {GetSum(num1)}");

static int GetSum(int num)
{
    int res = 0;
    for(int i = 1; i <= num; i++)
    {
        res += i;
    }
    return res;
}
