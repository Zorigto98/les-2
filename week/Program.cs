Console.WriteLine("Введите номер дня недели");
int date = Convert.ToInt32(Console.ReadLine());

if (date == 6 || date == 7) Console.WriteLine("Выходной день");
else Console.WriteLine("Рабочий день");