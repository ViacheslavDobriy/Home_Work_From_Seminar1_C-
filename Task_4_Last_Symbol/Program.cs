// Программа, которая выводит 3 цифру 3-значного числа
Console.WriteLine("Hello! This is my next programm, as usually enter new integer number with 3 symbols");
int LastSymbolFunc(int number)
{
    int LastSymbol = number % 10;
    return LastSymbol;
}
bool CheckFunction(int number)
{
    int result = number / 100;
    if(result >= 10)
    {
    Console.WriteLine("Вы ввели не трехзначное число");
    return false;
    }
    else if(result < 1)
    {
    Console.WriteLine("Вы ввели не трехзначное число");
    return false;
    }
    else return true;
}
int number = Convert.ToInt32(Console.ReadLine());
bool ResultOfCheck = CheckFunction(number);
if(ResultOfCheck==true)
{
    int Result = LastSymbolFunc(number);
    Console.WriteLine(Result);
}


