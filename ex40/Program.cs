Console.Write("Digite seu nome: ");
string nome = Console.ReadLine();

Console.Write("Digite o número de parafusos: ");
int parafusos = int.Parse(Console.ReadLine());
Console.Write("Digite o preço dos parafusos: ");
double parafusosprec = double.Parse(Console.ReadLine());
double parafusoprec2 = (parafusosprec * 0.7) * parafusos;

Console.Write("Digite o número de porcas: ");
int porcas = int.Parse(Console.ReadLine());
Console.Write("Digite o preço das porcas: ");
double porcasprec = double.Parse(Console.ReadLine());
double porcasprec2 = (porcasprec * 0.9) * porcas;

Console.Write("Digite o número de arruelas: ");
int arruelas = int.Parse(Console.ReadLine());
Console.Write("Digite o preço das arruelas: ");
double arruelasprec = double.Parse(Console.ReadLine());
double arruelasprec2 = (arruelasprec * 0.8) * arruelas;

if (parafusos > 0)
{
    Console.WriteLine(nome + ", ao comprar " + parafusos + " parafusos, você tem 30% de desconto.");
}
if (porcas > 0)
{
    Console.WriteLine(nome + ", ao comprar " + porcas + " porcas, você tem 10% de desconto.");
}
if (arruelas > 0)
{
    Console.WriteLine(nome + ", ao comprar " + arruelas + " arruelas, você tem 20% de desconto.");
}
