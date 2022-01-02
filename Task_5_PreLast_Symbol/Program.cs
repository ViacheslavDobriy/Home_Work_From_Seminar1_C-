// Показать вторую цифру трёхзначного числа
double PreLastSymbolFunc(double number)
{
    double PreLastSymbol = Math.Round((number - 5)/10,0)%10;
    return PreLastSymbol;
}
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
double number = Convert.ToInt32(Console.ReadLine());
bool ResultOfCheck = CheckFunction(number);
if(ResultOfCheck==true)
{
    double Result = PreLastSymbolFunc(number);
    Console.WriteLine(Result);
}