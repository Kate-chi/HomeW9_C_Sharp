/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.Write(FindSumNaturalNumbers(numA, numB));

int FindSumNaturalNumbers(int a, int b)
{
    if(a == b)
    {
        return b;
    }
    else if(a < b)
    {
        return a + FindSumNaturalNumbers(a + 1, b);
    }
    else
    {
        return a + FindSumNaturalNumbers(a - 1, b);
    }
}
