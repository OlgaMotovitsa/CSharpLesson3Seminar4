//Вид 4  // будем друг за другом компонавать строку с count раз
string Method4 (int count, string text)
{
    int i = 0;
    string result = String.Empty;

        while (i < count)
        {
            result= result + text;
            i++;
        }
        return result;
}

string res = Method4(10, "heff"+ " ");
System.Console.WriteLine(res);



// вместо цикла while заменяем на for 
