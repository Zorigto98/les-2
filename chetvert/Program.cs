Console.WriteLine("Введите номер четверти");
int chetvert = Convert.ToInt32(Console.ReadLine());

switch (chetvert)
{
    case 1: Console.WriteLine("x(0, oo); y(0, oo)"); break;
    case 2: Console.WriteLine("x(0, -oo); y(0, oo)");  break;
    case 3: Console.WriteLine("x(0, -oo); y(0, -oo)");  break;
    case 4: Console.WriteLine("x(0, oo); y(0, -oo)");  break;
    default: console.WriteLine("Некорректное значение");
}