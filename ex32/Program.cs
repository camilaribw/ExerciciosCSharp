Console.WriteLine("Digite um número: ");
int n = int.Parse(Console.ReadLine());

if (n <= 10)
{
    Console.WriteLine("F1");
}

if (n > 10)
{
    if (n <= 100)
    {
        Console.WriteLine("F2");
    }
}

if (n > 100)
{
    Console.WriteLine("F3");
}

Console.WriteLine("Segundo teste");

if (n <= 10)
{
    Console.WriteLine("F1");
}
else if (n <= 100)
{
    Console.WriteLine("F2");
}
else
{
    Console.WriteLine("F3");
}