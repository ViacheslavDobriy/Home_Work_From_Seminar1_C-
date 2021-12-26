Console.WriteLine("Hello! You are welcome in programm Day of the Week");
Console.WriteLine("Enter day's number of the week");
string Number=Console.ReadLine();
string Days_Name="";
if(Number=="1"){
    Days_Name="Monday";
    Console.Write("Today is the ");
    Console.WriteLine(Days_Name);
}
else if(Number=="2"){
    Days_Name="Tuesday";
    Console.Write("Today is the ");
    Console.WriteLine(Days_Name);
}
else if(Number=="3"){
    Days_Name="Wednesday";
    Console.Write("Today is the ");
    Console.WriteLine(Days_Name);
}
else if(Number=="4"){
    Days_Name="Thursday";
    Console.Write("Today is the ");
    Console.WriteLine(Days_Name);
}
else if(Number=="5"){
    Days_Name="Friday";
    Console.Write("Today is the ");
    Console.WriteLine(Days_Name);
}
else if(Number=="6"){
    Days_Name="Saturday";
    Console.Write("Today is the ");
    Console.WriteLine(Days_Name);
}
else if(Number=="7"){
    Days_Name="Sunday";
    Console.Write("Today is the ");
    Console.WriteLine(Days_Name);
}
else {Console.WriteLine("You entered illegal number");}