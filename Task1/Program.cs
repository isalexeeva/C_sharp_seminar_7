// Задача 1: Вывод натуральных чисел в промежутке от M до N
// Описание: Напишите программу, которая выведет все натуральные числа в
// промежутке от M до N. Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: M = 1, N = 5
// ● Выход: 1, 2, 3, 4, 5
// ● Вход: M = 4, N = 8
// ● Выход: 4, 5, 6, 7, 8

// Подсказка: Используйте рекурсивный метод, который выводит текущее значение и
// вызывает себя с увеличенным значением до достижения конечного значения.



void Main()
{
    int m = ReadInt("Введите число M: ");
    int n = ReadInt("Введите число N: ") + 1;
    if (m < 1 || n < 1)
    {
        System.Console.WriteLine("Ввели некорректное число");
    }
    PrintNaturals(m, n);
}


void PrintNaturals(int m, int n)
{
    if (m > n) return;
    if (m < n) Console.Write(m + ", ");
    PrintNaturals(m + 1, n);
}



int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
