﻿Console.Clear();
int n = new Random().Next(10,100);
int n1 = n / 10;
int n2 = n % 10;
Console.WriteLine($"Число: {n}");
if (n1>n2) {
    Console.WriteLine(n1);
}
else
if (n2>n1) 
{
     Console.WriteLine(n2);
}
else 
 Console.WriteLine("=");
