// Удалить вторую цифру трёхзначного числа
bool CheckFunction(double number)
{
    double result = number / 100;
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
double DeleteFunc(double number)
{
    double FirstDigit = Math.Round((number-50)/100,0)%10;
    double ThirdDigit = number%10;
    double NewNumber = FirstDigit*10 + ThirdDigit;
    return NewNumber;
}
double number = Convert.ToInt32(Console.ReadLine());
bool ResultOfCheck = CheckFunction(number);
if(ResultOfCheck==true)
{
    double Result = DeleteFunc(number);
    Console.WriteLine(Result);
}
