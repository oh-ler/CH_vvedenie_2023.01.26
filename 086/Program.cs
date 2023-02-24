//86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.
string a=Console.ReadLine();
int i=0;
int b=0;
if (i<a.Length)
{
    if (a[i]=='a')
    {
    b=b+1;
    }
    i=i+1;
}
System.Console.WriteLine(b);