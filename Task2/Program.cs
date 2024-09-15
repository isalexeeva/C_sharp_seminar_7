// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 2: Функция Аккермана
// Описание: Напишите программу для вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// Пример:
// ● Вход: m = 2, n = 3
// ● Выход: A(m, n) = 29
// ● Вход: m = 1, n = 4
// ● Выход: A(m, n) = 7

// Подсказка: Реализуйте рекурсивную функцию Аккермана, основываясь на её
// определении:
// ● A(0,n)=n+1A(0, n) = n + 1A(0,n)=n+1
// ● A(m,0)=A(m−1,1)A(m, 0) = A(m - 1, 1)A(m,0)=A(m−1,1)
// ● A(m,n)=A(m−1,A(m,n−1))A(m, n) = A(m - 1, A(m, n - 1))A(m,n)=A(m−1,A(m,n−1))



void Main()
{
    int m = ReadInt("Введите число m: ");
    int n = ReadInt("Введите число n: ");
    
    System.Console.WriteLine($"A({m}, {n}) = {Ackermann(m, n)}");
}

int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else if (m > 0 && n > 0)
        return Ackermann(m - 1, Ackermann(m, n - 1));
    return 0; 
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
