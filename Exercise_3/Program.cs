/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29 !!!равно 9 а не 29 по таблице!!!*/ 

Console.Write("Задайте число m - ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте число n - ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"m = {m}, ");
Console.Write($"n = {n} -> ");

Console.Write($"A({m},{n}) = {AcerFun(m,n)}");

static int AcerFun(int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 && n == 0) return AcerFun(m - 1, 1);
    if(m > 0 && n > 0) return AcerFun(m - 1, AcerFun(m, n - 1));
    return AcerFun(m,n);
}