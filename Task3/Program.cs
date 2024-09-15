// Задача 3: Вывод элементов массива в обратном порядке
// Описание: Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.

// Подсказка: Используйте рекурсию, чтобы выводить элементы массива начиная с
// последнего и до первого.

void Main()
{
    int sizeOfArray = ReadInt("Введите размер массива: ");
    int[] array = GenetateArray(sizeOfArray, 0, 10);
    PrintArray(array);
    PrintArrayReverse(array, sizeOfArray-1);

}

void PrintArrayReverse(int[] array, int i)
{
    if (i < 0) 
        return; 
    Console.Write(array[i]);
    if (i > 0) Console.Write(" ");
    PrintArrayReverse(array, i - 1);
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
        System.Console.Write(arrayForPrint[i] + " ");
    System.Console.WriteLine();
}

int[] GenetateArray(int size, int minRange, int maxRange)
{
    Random rnd = new Random();
    int[] tempArray = new int[size];
    for (int i = 0; i < tempArray.Length; i++)
        tempArray[i] = rnd.Next(minRange, maxRange +1);
    return tempArray;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
