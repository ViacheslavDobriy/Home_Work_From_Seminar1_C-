Console.WriteLine("Hello, User! Enter any integer number, and I will show you segment of numbers from -Your_Number till +Your_Number");
int number = Convert.ToInt32(Console.ReadLine());
int Updated_number=number*(-1);
while(Updated_number<number+1){
    Console.Write(" ");
    Console.Write(Updated_number);
    Updated_number++;
}
Console.WriteLine();
Console.WriteLine("Done! Look at this");