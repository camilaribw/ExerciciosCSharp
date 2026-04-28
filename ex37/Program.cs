Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua idade:");
int idade = int.Parse(Console.ReadLine()); 

int tempo = idade * 365; 

Console.WriteLine(nome + ", você já viveu cerca de " + tempo + " dias.");
