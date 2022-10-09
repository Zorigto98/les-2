Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10000 && num <100000)
{
    int firstDig = num/10000;
    int fifthDig = num%10;

    Console.WriteLine(firstDig);
    Console.WriteLine(fifthDig);

    if (firstDig == fifthDig)
    {
        int secondDig = (num/1000)%10;
        int fourthDig = (num/10)%10;

        Console.WriteLine(secondDig);
        Console.WriteLine(fourthDig);

        if (secondDig == fourthDig) Console.WriteLine("Число палиндром");
        else Console.WriteLine("Число не палиндром");
    }
    else Console.WriteLine("Число не палиндром");
}