// Проверить является ли первое число квадратом второго
int SquareOfNumber(int number1)
{
    int Result = number1*number1;
    return Result;
}
Console.Write("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = SquareOfNumber(number2);
if(number1 == number3){
    Console.WriteLine("The first number is the square of the second");
}
else 
   Console.WriteLine("The first number isn't the square of the second");
