Console.WriteLine("Digite o nome do corretor:");
string nome = Console.ReadLine();

Console.WriteLine("Digite o valor da venda:");

double vendas = float.Parse(Console.ReadLine());

if (vendas > 50000)
{
    double comissao = vendas * 0.12;
    Console.WriteLine("A comissão será de 12% = R$" + comissao);
}
else if (vendas >= 3000 && vendas <= 50000)
{
    double comissao = vendas * 0.095;
    Console.WriteLine("A comissão será de 9.5% = R$" + comissao);
}
else
{
    double comissao = vendas * 0.07;
    Console.WriteLine("A comissão será de 7% = R$" + comissao);
}

