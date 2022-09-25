// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите любые числа через пробел: ");
int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

PositiveNumber(numbers);

static void PositiveNumber(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0)
        {
            count++;  
        }
    }
    Console.WriteLine($"Среди введенных Вами чисел положительных: {count}");
}
