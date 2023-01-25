// Задача 24: Напишите программу, которая принимает на вход число (А)
// и выдает сумму чисел от 1 до А
// 7 -> 28

int num1 = new Random().Next(1,7);
Console.WriteLine(num1);

Console.WriteLine(GetSum(num1));

static int GetSum(int num)
{
    int res = 0;
    for(int i = 1; i <= num; i++)
    {
        res += i;
    }
    return res;
}


// Console.WriteLine($"{num1} -> {GetSum(num1)}"); вместо 6 строки