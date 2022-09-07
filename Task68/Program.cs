﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите натуральное число ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число ");
int n = Convert.ToInt32(Console.ReadLine());

int Ackerman(int m, int n)
{
    if (m > 4) Console.Write("Операция невозможна");
    if (m==0) return n + 1;
    else if (m>0 && n==0) return Ackerman(m-1,1);
    else if (m>0 && n>0) return Ackerman(m-1,Ackerman(m,n-1));
    else
return n + 1;
}
Console.WriteLine(Ackerman(m,n));