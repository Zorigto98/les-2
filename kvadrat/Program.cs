Console.WriteLine("Введите первое число");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
double b = Convert.ToInt32(Console.ReadLine());

if (Math.Pow(a,2) == b)
{
    Console.WriteLine("Является квадратом");
}
else Console.WriteLine("Не является квадратом");