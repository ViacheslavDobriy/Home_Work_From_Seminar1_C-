Console.WriteLine("I have number 128. Try to enter any number and I'll show you if your number is multiple to mine or not");
int User_Number = Convert.ToInt32(Console.ReadLine());
int Remains = 128 % User_Number;
if (Remains==0){
    Console.WriteLine("Your number is multiple to 128");
}
else {Console.WriteLine($"Your number is not multiple to 128, remains is {Remains}");
}