// Программа, которая выводит 3 цифру 3-значного числа
Console.WriteLine("Hello! This is my next programm, as usually enter new integer number with 3 symbols");
int LastSymbolFunc(int number)
{
    int LastSymbol = number % 10;
    return LastSymbol;
}
int number = Convert.ToInt32(Console.ReadLine());
int Result = LastSymbolFunc(number);
Console.WriteLine(Result);



