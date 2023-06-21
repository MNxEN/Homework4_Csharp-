// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// (*) В 3-й задаче Доп сложность. Ввод с консоли “введите количество элементов массива”, 
// “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedStr = Console.ReadLine();
    int value;
    if (int.TryParse(inputedStr, out value))
    {
        return value;
    }
    System.Console.WriteLine($"Извините, но '{inputedStr}' не является целым числом");
    Environment.Exit(0);
    return 0;
}
int[] GenerateArray(int len, int min, int max)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.Write("]");
}

int countVal = Prompt("Введите количество элементов массива:");
int minVal = Prompt("Введите минимальное значение элемента массива:");
int maxVal = Prompt("Введите максимальное значение элемента массива:");

int[] numbers = GenerateArray(countVal, minVal, maxVal);

PrintArray(numbers);
