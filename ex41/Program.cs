Console.Write("Digite o valor do salário mínimo: ");
double salarioMinimo = double.Parse(Console.ReadLine());

Console.Write("Digite a quantidade de carros vendidos: ");
int carrosVendidos = int.Parse(Console.ReadLine());

Console.Write("Digite o valor total das vendas: ");
double valorVendas = double.Parse(Console.ReadLine());

double salarioFixo = salarioMinimo * 2;
double comissaoCarros = carrosVendidos * 50;
double comissaoVendas = valorVendas * 0.05;


double salarioTotal = salarioFixo + comissaoCarros + comissaoVendas;

Console.WriteLine("\n--- FOLHA DE PAGAMENTO ---");
Console.WriteLine("Salário total: R$ " + salarioTotal.ToString("F2"));

