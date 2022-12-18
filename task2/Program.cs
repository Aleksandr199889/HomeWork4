// Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе, которые являются делителями этого числа.

//452 -> 6
//82 -> 2
//9012 -> 3
//1234 / 10, 123 % 10, 123 / 10, 12 % 10, 12 / 

Console.Write("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int n = N;
int sum = 0;
for (int i = 0; i <= n; i++)
{
    int c = n % 10;
    if (c!=0)
    {
        if (N%c==0)
        {
            sum = sum + c;
        }
    }
    else
    {
        Console.WriteLine("деление на ноль");
    }
    n = n / 10;
}
Console.WriteLine(sum);