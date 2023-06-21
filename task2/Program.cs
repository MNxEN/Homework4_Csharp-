// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

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
int SumDigitsNumber(int number)     // Определяет сумму цифр числа
{
    int sum = 0;
    for (int i = 0; number > i; i++)
    {
        int digit = number % 10;
        sum = sum + digit;
        number /= 10;
    }
    return sum;
}
int number = Prompt("Введите целое число:");
int sum = SumDigitsNumber(number);
System.Console.WriteLine($"Сумма цифр числа '{number}' равна '{sum}'");
