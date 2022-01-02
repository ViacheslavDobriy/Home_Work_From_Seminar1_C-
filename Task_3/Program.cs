// Программа,которая должна вывести числа от -N до N
Console.WriteLine("Hello, User! Enter any integer number, and I will show you segment of numbers from -Your_Number till +Your_Number");
int AlternativeNumber(int AnyNumber)
{
    int Result = AnyNumber*(-1);
    return Result;
}
void OutPutSegment(int number, int number_)
{
    while(number_<number+1)
    {
         Console.Write(" ");
         Console.Write(number_);
         number_++;
    }
}
int number = Convert.ToInt32(Console.ReadLine());
int Updated_number=AlternativeNumber(number);
OutPutSegment(number, Updated_number);
Console.WriteLine();
Console.WriteLine("Done! Look at this");