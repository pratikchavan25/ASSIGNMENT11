// See https://aka.ms/new-console-template for more information
// 11. Write a C# program to check whether a number is divisible by 5 and 11 or not ?

using System.ComponentModel.Design;

int num1;

Console.WriteLine(" enter a number");
num1 = Convert.ToInt32(Console.ReadLine());

if (num1%5 == 0 && num1%11 ==0)
{
    Console.WriteLine("it is divisible");
}
else
{
    Console.WriteLine("it is not divisible");
}