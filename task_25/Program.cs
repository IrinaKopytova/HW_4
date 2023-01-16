// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int  N(int A, int B)
{
    int n = 1;
    for (int i = 1; i <= B; i++)
    {
        n = n * A;
    }
    return n;
}

Console.WriteLine("Введите число A: ");
int nA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int nB = Convert.ToInt32(Console.ReadLine());
int n = N(nA, nB);
Console.WriteLine(n);
