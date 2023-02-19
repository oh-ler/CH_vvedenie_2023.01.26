//Показать натуральные числа от N до 1, N задано

void Loop(int i, int N)
{
    int n=N;
    System.Console.Write($"{n}   ");
    if (i+1<N+i) Loop(i+1, N-1);
}

Loop (1,10);