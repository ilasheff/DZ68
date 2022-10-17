/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29*/

Console.WriteLine("Введите начальное число M:");
int num_M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int num_N = Convert.ToInt32(Console.ReadLine());

int AckermannFunction (int num_M, int num_N)
{
    if (num_M == 0) return num_N + 1;
    if (num_M != 0 && num_N == 0) return AckermannFunction(num_M - 1, 1);
    if (num_M > 0 && num_N > 0) return AckermannFunction(num_M - 1, AckermannFunction(num_M, num_N - 1));
return AckermannFunction(num_M, num_N);
}

Console.WriteLine($"Функция Аккермана для чисел A({num_M},{num_N}) = {AckermannFunction(num_M, num_N)}");