Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2, не равное числу 1: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 3, не равное числу 2 и числу 1: ");
int num3 = int.Parse(Console.ReadLine());
if (num1 > num2 && num1 >num3)
{
    Console.WriteLine($"Максимальное число  {num1} ");
}
if (num2 > num1 && num2 >num3)
{
    Console.WriteLine($"Максимальное число  {num2} ");
}
if (num3 > num2 && num3 >num1)
{
    Console.WriteLine($"Максимальное число  {num3} ");
}