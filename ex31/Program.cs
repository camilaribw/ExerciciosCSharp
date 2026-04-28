// See https://aka.ms/new-console-template for more information
string valor;
float valorA, valorB;
Console.WriteLine("Valor de A");
valorA = float.Parse(Console.ReadLine());
Console.WriteLine("Valor de B");
valorB = float.Parse(Console.ReadLine());
if (valorA > valorB)
{
    Console.WriteLine("O A é maior que B");
}
else
{
    Console.WriteLine("O B é maior que A");
}