Console.WriteLine("Введите число : ");
double num = int.Parse(Console.ReadLine());
while (num >= 2 || num <= -2)
{
    num = num / 2; 
}
Console.WriteLine($"Введено четное число ? ");
if(num==1 || num==-1)
{
    Console.WriteLine($"да ");
}
else
{
    Console.WriteLine($"нет ");
}