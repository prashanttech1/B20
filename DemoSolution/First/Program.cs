// See https://aka.ms/new-console-template for more information
using First;

Console.WriteLine("Hello, World!");

Console.WriteLine("Edited");

Console.WriteLine("Enter 1 st value");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter 2 nd value");
int b = int.Parse(Console.ReadLine());

Calculator c = new Calculator();
c.Add(a,  b);

Console.ReadLine();
