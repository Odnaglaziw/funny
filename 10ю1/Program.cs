using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using static System.Console;
using static System.Convert;
int[,] masive = new int[5,6];
Fill(masive, 99);
Print(masive);
WriteLine($"Кол-во ненулевых во втором столбце, больших 15: {Xexe(masive, 2, 15)}" +
    $"\nСреднее арифметическое нечётных элементов пятой строки: {Exex(masive, 5)}" +
    $"\nСреднее арифметическое элементов четвёртого столбца, кратных четырём: {X.Xaxa(masive, 4, 4)}");
Fill(masive,99);
Print(masive);
WriteLine($"Кол-во чётных: {Even(masive)}\nСреднее арифметическое, кратных пяти: {X.Xaxa(masive,5)}");
void Print(int[,] masive)
{
    int width = masive.GetLength(1);
    int height = masive.GetLength(0);   
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Write($"{masive[i, j],3}");
        }
        WriteLine();
    }
}
void Fill(int[,] masive, int limit)
{
    Random random = new Random();
    int width = masive.GetLength(1);
    int height = masive.GetLength(0);
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            masive[i, j] = random.Next(limit + 1);
        }
    }
}
int Exex(int[,] masive, int row)
{
    int sum = 0;
    int count = 0;
    int width = masive.GetLength(1);
    for (int i = 0; i < width; i++)
    {
        if (masive[row - 1, i] % 2 == 1)
        {
            sum += masive[row - 1, i];
            count++;
        }
    }
    sum = sum / count;
    return sum;
}

int Even(int[,] masive)
{
    int count = 0;
    int width = masive.GetLength(1);
    int height = masive.GetLength(0);
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            if (masive[i, j] % 2 == 0) count++;
        }
    }
    return count;
}
int Xexe(int[,] masive, int col, int larger)
{
    int count = 0;
    int height = masive.GetLength(0);
    for (int i = 0; i < height; i++)
    {
        if (masive[i, col - 1] != 0 && masive[i, col - 1] > larger)
        {
            count++;
        }
    }
    return count;
}

class X
{
    public static int Xaxa(int[,] masive, int multiples, int col)
    {
        int sum = 0;
        int count = 0;
        int height = masive.GetLength(0);
        for (int i = 0; i < height; i++)
        {
            if (masive[i, col - 1] != 0 && masive[i, col - 1] % multiples == 0)
            {
                sum += masive[i, col - 1];
                count++;
            }
        }
        if (count !=0 ) return sum / count;
        else return count;
    }
    public static int Xaxa(int[,] masive,int multiples)
    {
        int sum = 0;
        int count = 0;
        int height = masive.GetLength(0);
        int width = masive.GetLength(1);
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (masive[i, j] > 0 && masive[i, j] % multiples == 0)
                {
                    sum += masive[i, j];
                    count++;
                }
            }
        }
        return sum / count;
    }
}