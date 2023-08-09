bool valido;
int quantidadeAtual;
int quantidadeMaxima;
int quantidadeMinima;

do
{
    Console.WriteLine("Por favor, insira a quantidade atual do estoque. Exemplo: 40");
    valido = int.TryParse(Console.ReadLine(), out quantidadeAtual);
}
while (!valido);

do
{
    Console.WriteLine("Por favor, insira a quantidade máxima do estoque. Exemplo: 40");
    valido = int.TryParse(Console.ReadLine(), out quantidadeMaxima);
}
while (!valido);

do
{
    Console.WriteLine("Por favor, insira a quantidade atual do estoque. Exemplo: 40");
    valido = int.TryParse(Console.ReadLine(), out quantidadeMinima);
}
while (!valido);

double quantidadeMedia = (quantidadeMaxima + quantidadeMinima) / 2;

if(quantidadeAtual >= quantidadeMedia)
    Console.WriteLine("Não efetuar compra!");
else
    Console.WriteLine("Efetuar compra!");
