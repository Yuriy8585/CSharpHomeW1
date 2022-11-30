//Напиите программу которая на вход принимает одно число N, а выводит значения все целые числа от -N до N

Console.Write("Enter int N = ");
int N = int.Parse(Console.ReadLine());
int a = 2;
while (a < N+1)
{
 Console.Write(" " + a + " ");
 a = a + 2;
}

 if (N % 2 == 0)
 
 {
    Console.Write(" ДА Введенное число является четным");
 
    Console.Read();

 }