// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке

int GetSum(int start, int end)
{
    if (start > end)
        return 0;

    return start + GetSum(start + 1, end);
}

int M = 1;
int N = 15;

int sum = GetSum(M, N);

Console.WriteLine($"Сумма натуральных элементов от {M} до {N} равна {sum}");