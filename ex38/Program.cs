Console.Write("Digite A: ");
float A = float.Parse(Console.ReadLine());

Console.Write("Digite B: ");
float B = float.Parse(Console.ReadLine());

Console.Write("Digite C: ");
float C = float.Parse(Console.ReadLine());

float soma = A + B;

if (soma > C)
{
    Console.WriteLine("A soma é maior que C");
}  else if (soma < C)
{
    Console.WriteLine("A soma é menor que C");
} else
    Console.WriteLine("A soma é igual a C");
