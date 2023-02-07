//Подсчитать сумму цифр в числе. Сделать подпрограмму.

double summa(int a)
{
    int b=0;
while (a!=0)
{
    b+=a%10;
    a/=10;
}
return b;
};

int a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(summa(a));







