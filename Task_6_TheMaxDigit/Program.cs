// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
double GenerateNumber()
{
    double number = new Random().Next(10,100);
    return number;
}
double SeparateDigit(double WholeNumber)
{
    double SecondDigit = WholeNumber%10;
    double FirstDigit = Math.Round((WholeNumber-5)/10,0);
    if(SecondDigit>FirstDigit) return SecondDigit;
    else if(SecondDigit<FirstDigit) return FirstDigit;
    else 
    {
        Console.WriteLine("Две одинаковых цифры в двухзначном числе - {0}", FirstDigit);
        return FirstDigit;
    }
}
Console.WriteLine("Сгенерировано следующее число");
double RandomNumber = GenerateNumber();
Console.WriteLine(RandomNumber);
double ResultOfChecking=SeparateDigit(RandomNumber);
Console.WriteLine(ResultOfChecking);
