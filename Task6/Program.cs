// Напишите программу, которая на вход принимает число и выдает, является ли четным (делится на 2 без остатка)


{
 
 int i;
 
 Console.Write("Введите число : ");
 
 i = int.Parse(Console.ReadLine());
 
 if (i % 2 == 0)
 
 {
 
    Console.Write("Введенное число является четным");
 
    Console.Read();
 
 }
 
 else
 
 {
 
    Console.Write("Введенное число нечетное");
 
    Console.Read();
 }
 }
