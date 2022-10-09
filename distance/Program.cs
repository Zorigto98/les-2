Console.WriteLine("Какое пространство? Двумерное или треххмерноею. 2 или 3");
int prostranstvo = Convert.ToInt32(Console.ReadLine());

if (prostranstvo==2)
{
    Console.WriteLine("Введите координаты");
    Console.Write("Ax ");
    int Ax = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ay ");
    int Ay = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты");
    Console.Write("Bx ");
    int Bx = Convert.ToInt32(Console.ReadLine());
    Console.Write("By ");
    int By = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Math.Sqrt(Math.Pow(Bx-Ax, 2) + Math.Pow(By-Ay, 2)));
}

if (prostranstvo==3)
{
    Console.WriteLine("Введите координаты");
    Console.Write("Ax ");
    int Ax = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ay ");
    int Ay = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координаты");
    Console.Write("Az ");
    int Az = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты");
    Console.Write("Bx ");
    int Bx = Convert.ToInt32(Console.ReadLine());
    Console.Write("By ");
    int By = Convert.ToInt32(Console.ReadLine());
    Console.Write("Bz ");
    int Bz = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Math.Sqrt(Math.Pow(Bx-Ax, 2) + Math.Pow(By-Ay, 2) + Math.Pow(Bz-Az, 2)));
}