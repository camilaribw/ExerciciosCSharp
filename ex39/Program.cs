Console.Write("Digite o valor da compra: ");
int valorCompra = int.Parse(Console.ReadLine());

Console.Write("Digite o valor pago pelo cliente: ");
int valorPago = int.Parse(Console.ReadLine());

int troco = valorPago - valorCompra;

int notas100 = troco / 100; 
int resto = troco % 100;   

int notas10 = resto / 10;
int notas1 = resto % 10;

Console.WriteLine(" caixa ");
Console.WriteLine("valor da Compra: R$ " + valorCompra);
Console.WriteLine("valor do Troco:  R$ " + troco);
Console.WriteLine("Quantidade de notas para o troco:");
Console.WriteLine(notas100 + " nota(s) de R$ 100");
Console.WriteLine(notas10 + " nota(s) de R$ 10");
Console.WriteLine(notas1 + " nota(s) de R$ 1");
