Console.WriteLine("Введите число");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA > 100)
{
    while (numA > 1000)
    {
        numA = numA / 10;
    }
    int d = numA % 10;
    
        Console.WriteLine($"третья цифра слева это {d}");

    
}
else
{
    Console.WriteLine("В данном числе меньше трех цифр");
}
