//Найти сумму цифр числа

int Lo(int N)
{
    if (N!=0)
     return (Lo(N/10) + N%10);
   else return (0);
}

System.Console.WriteLine(Lo (12345));
