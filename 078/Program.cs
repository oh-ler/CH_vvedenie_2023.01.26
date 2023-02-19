//С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1. Использовать рекурсию.

void fi(int f1, int f2, int N)
{
   
if (N!=0)
{
    int f=0;
f=f1+f2;
f1=f2;
f2=f;
System.Console.WriteLine($"{f}   ");
fi (f1, f2, N-1);
}
}

int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(0);
fi(0,1,N-1);