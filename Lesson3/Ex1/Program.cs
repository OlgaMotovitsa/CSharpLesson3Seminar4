// Вид 1
void Method1()
{
    System.Console.WriteLine("Афтор . . .");
}
Method1();











// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
 // Method2(msg: "Текст сообщения");
// Вид 2 (например несколько аргументов)
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);