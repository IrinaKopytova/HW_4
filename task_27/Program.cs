// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int  K(int number)
{
    int k = 0;
    int n = 0;
    while (number > 0)
    {
        k = number - number % 10 ;
        n = n + (number - k);
        number = number/10;
    }
    return n;
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int n = K(N);
Console.WriteLine(n);