/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Write("Задайте число M - ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте число N - ");
int N = Convert.ToInt32(Console.ReadLine());

void SumNumbers()
{
    int Sum = 0;
    
    Console.Write($"M = {M}; N = {N}. ->");
    while (M <= N)
    {
        Sum += M++;
    }
    Console.Write($" {Sum}");
}
SumNumbers();