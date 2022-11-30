//Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.Write("Enter Number a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter Number b = ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.Write("Max");
Console.WriteLine(a);


}
else (a < b)
{
    Console.Write("Max");
Console.WriteLine(b);

}
