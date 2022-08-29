Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int k = 2;
while (k <= num)
{
    Console.Write($"{k}  ");
    k=k+2;
}