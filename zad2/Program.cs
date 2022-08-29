Console.Write($"Введите число 1: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.Write($"Введите число 2: ");
int num2 = Convert.ToInt32 (Console.ReadLine());
if (num2 > num1) 
{
    Console.WriteLine($"max = {num2}");
}
if (num1 > num2) 
{
    Console.WriteLine($"max = {num1}");
}
else 
{
    Console.WriteLine($"Неверно введены значения, или значения равны");
}