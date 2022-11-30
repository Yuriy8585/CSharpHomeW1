// Напишите программу, которая на вход принимает число и выдает, является ли четным (делится на 2 без остатка)

Console.Write("Enter int N = ");
int N = int.Parse(Console.ReadLine());

int a = 0;
double b = 0;

a = N%10;
b = N/10;

Console.Write("Last number");
Console.WriteLine(a);
Console.Write("Previous Numbers" + " " + b);

