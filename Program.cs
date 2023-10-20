// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int m, int n)
{
    int counter = 0;
    if (m == n)
        return 0;
    else
    {
        m++;
        counter = m + Sum(m, n);
        return counter;
    }
    
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = Sum(m, n);
Console.Write($"M = {m}; N = {n} -> {Sum(m - 1, n)}");