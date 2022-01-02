// Проверить является ли первое число квадратом второго
int SquareOfNumber(int number1)
{
    int Result = number1*number1;
    return Result;
}
int number1 = 9;
int number2 = 3;
int number3 = SquareOfNumber(number2);
Console.Write("First number: ");
Console.WriteLine(number1);
Console.Write("Second number: ");
Console.WriteLine(number2);
if(number1 == number3){
    Console.WriteLine("The first number is the square of the second");
}
else 
   Console.WriteLine("The first number isn't the square of the second");
