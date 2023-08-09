using System.Linq;


int[] vetorAleatorio = new int[100];
Random aleatorio = new Random();

for (int i = 0; i < vetorAleatorio.Length; i++)
    vetorAleatorio[i] = aleatorio.Next();

int maiorValor = vetorAleatorio.Max();
int menorValor = vetorAleatorio.Min();

int posicaoMaior = Array.IndexOf(vetorAleatorio, maiorValor);
int posicaoMenor = Array.IndexOf(vetorAleatorio, menorValor);

Console.WriteLine($"Vetor: {String.Join(",", vetorAleatorio)}");
Console.WriteLine($"O maior valor de {maiorValor} na posição {posicaoMaior}");
Console.WriteLine($"O maior valor de {menorValor} na posição {posicaoMenor}");



