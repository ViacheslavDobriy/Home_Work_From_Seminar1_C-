// Программа, которая переводит введенный номер дня недели с клавиатуры в название дня недели
Console.WriteLine("Hello! You are welcome in programm Day of the Week");
Console.WriteLine("Enter day's number of the week");
int Number=Convert.ToInt32(Console.ReadLine());
string[] Days_Name = new string[7];
Days_Name[0]="Monday";
Days_Name[1]="Tuesday";
Days_Name[2]="Wednesday";
Days_Name[3]="Thursday";
Days_Name[4]="Friday";
Days_Name[5]="Saturday";
Days_Name[6]="Sunday";
string ResultNameDay = " ";
for(int i = 0; i<7; i++)
{
    if(Number==i+1)
    {
        ResultNameDay=Days_Name[i];
        Console.Write("Today is the ");
        Console.WriteLine(ResultNameDay);
    }
}