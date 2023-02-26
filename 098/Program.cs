//98. Показать треугольник Паскаля
//*Сделать вывод в виде равнобедренного треугольника

 int n = 10;
    int[,] arr = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            if (j == 0 || j == i)
            {
                arr[i, j] = 1;
            }
            else
            {
                arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j];
            }
        }
    }
    for (int i = 0; i < n; i++)
    {
        for (int k = n - i; k > 0; k--)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }