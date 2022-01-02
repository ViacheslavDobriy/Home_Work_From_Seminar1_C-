// Проверить является ли первое число квадратом второго
int SquareOfNumber(int number1)
{
    int Result = number1*number1;
    return Result;
}
void CheckOfSquare(int number1, int number2)
{
    if(number1 == number2)
    Console.WriteLine("The first number is the square of the second");
else 
   Console.WriteLine("The first number isn't the square of the second");
}
Console.Write("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int square = SquareOfNumber(number2);
CheckOfSquare(number1,square);

