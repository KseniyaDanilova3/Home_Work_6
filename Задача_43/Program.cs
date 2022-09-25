// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффициенты 1-ой прямой");
Console.Write("k1= ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("b1= ");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициенты 2-ой прямой");
Console.Write("k2= ");
int k2 = int.Parse(Console.ReadLine()!);
Console.Write("b2= ");
int b2 = int.Parse(Console.ReadLine()!);

solution(k1, b1, k2, b2);

void solution(double k1, double b1, double k2, double b2)
{
    if ((k1 == k2) && (b1 == b2))
    {
        Console.WriteLine("Прямые совпадают");
    } 
    else if (k1 == k2) 
    Console.WriteLine("Прямые параллельны"); 
    else 
    {   
        double x = (b1 - b2) / (k2 - k1);
        double y = (k2 * b1 - k1 * b2) / (k2- k1);
         Console.WriteLine($"Точка пересечения двух прямых: ({x}, {y})"); 
    }
}  
