// Задача 5. Напиши программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.
Console.Clear(); // Clear the console berofe starting.
Console.WriteLine("This program writes out the last digit of your three-digit number.");
Console.Write("Please ender your three-digit number: ");
int Number = Convert.ToInt32(Console.ReadLine());
int NumberOfDigit=0;
double Buffer = Number;
while (Buffer>1)// Find number of digit
   {
    Buffer=Buffer/10;
    NumberOfDigit++;
   }
if (NumberOfDigit ==3)
   {
    int Result = Number%10; // Find the remainder of the division
    Console.WriteLine("The last digit of "+ Number+ " is " +Result);
   }
else
   {
    Console.WriteLine("Attention! "+ Number + " is not a three-digit number!" );
   }


