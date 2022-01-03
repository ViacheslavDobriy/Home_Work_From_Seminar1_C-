// Найти третью цифру числа или сообщить, что её нет
bool CheckFunction(double number)
{
    double result = number / 100;
    if(result < 1)
    {
    Console.WriteLine("Вы ввели менее 3 цифр");
    return false;
    }
    else return true;
}
double DeleteFunc(double number)
{
    double ThirdDigit = Math.Round((number-50)/100,0)%10;
    return ThirdDigit;
}
double number = Convert.ToInt32(Console.ReadLine());
bool ResultOfCheck = CheckFunction(number);
if(ResultOfCheck==true)
{
    double ResultOfFunc = DeleteFunc(number);
    if(ResultOfFunc>=10)
    {
        ResultOfFunc = ResultOfFunc%10;
        Console.WriteLine(ResultOfFunc);
    }
    else
    {
        Console.WriteLine(ResultOfFunc);
    }
}


