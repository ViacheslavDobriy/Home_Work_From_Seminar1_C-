// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int GenerateNumber()
{
    int number = new Random().Next(10,100);
    return number;
}
int RandomNumber = GenerateNumber();
Console.WriteLine(RandomNumber);
