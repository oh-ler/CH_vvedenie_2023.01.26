﻿//Показать натуральные числа от 1 до N, N задано

void Loop(int i, int N)
{

    System.Console.Write($"{i}  ");
    if (i<N) Loop(i+1,N);
}
Loop (1,20);