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
int Remains = RemainFunction(firstUserNumber, secondUserNumber);
if (Remains==0){
    Console.WriteLine("{0} кратно {1}", secondUserNumber, firstUserNumber);
}
else {Console.WriteLine($"{secondUserNumber} не кратно {firstUserNumber}, остаток от деления равен {Remains}");
}