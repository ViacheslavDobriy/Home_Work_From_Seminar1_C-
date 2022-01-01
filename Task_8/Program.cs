// Кратно ли одно заданное число, введенному числу
Console.WriteLine("Задайте число, относительно которого будем проверять кратность введенного числа");
int firstUserNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, которое будем проверять на кратность");
int secondUserNumber = Convert.ToInt32(Console.ReadLine());
int RemainFunction(int number1, int number2)
{
    int result = number1 % number2;
    return result;
}
void CheckMultiple(int remain, int number1, int number2)
{
    if (remain==0)
    Console.WriteLine("{0} кратно {1}", number2, number1);
    else 
    Console.WriteLine($"{number2} не кратно {number1}, остаток от деления равен {remain}");
}
int Remains = RemainFunction(firstUserNumber, secondUserNumber);
CheckMultiple(Remains, firstUserNumber, secondUserNumber);
