﻿int a = 1; // початкове значення
int b = 100; // кінцеве значення
int c = 5; // число, на яке повинні бути кратні числа

for (int i = a; i <= b; i++)
{
    if (i % c == 0)
    {
        Console.Write(i + " "); 
    }
}


