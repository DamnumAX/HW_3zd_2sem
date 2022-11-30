Console.Write("Введите число от 1 до 7:");
int num = int.Parse(Console.ReadLine());

if (num >= 1 && num <= 7)
{
if (num == 6 | num == 7) Console.WriteLine("Ура, сегодня выходной!");
else Console.WriteLine("Иди на работу, сегодня не выходной!");
}
else Console.WriteLine("В неделе 7 дней! В следующий раз, введите число от 1 до 7");