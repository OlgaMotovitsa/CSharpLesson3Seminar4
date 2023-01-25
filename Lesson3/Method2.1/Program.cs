// Вид 2.1 (например несколько аргументов)
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

// Method21(msg: "Текст", count: 4); ------- Другая запись ответа и не обязательно в ответе все писать по порядку