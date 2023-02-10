// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число а");
int a = int.Parse(Console.ReadLine ()!);
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число c");
int c = int.Parse(Console.ReadLine()!);
if (a > b && a > c)
Console.WriteLine("max = " + a); 
else if (b > c)
Console.WriteLine("max = " + b); 
else
Console.WriteLine("max = " + c);