// Задача 26: Напишите программу, которая принимает на вход число
// и выдает количество цифр в числе.
// 78 -> 2
Console.Clear();

static int GetCountNum(int num)
{
    Console.WriteLine(num);
    int count = 0;
    while (num > 0)
    {
        count++;
        num /= 10;
    }
    return count;
}

Console.WriteLine(GetCountNum(new Random().Next(1000, 100000)));
