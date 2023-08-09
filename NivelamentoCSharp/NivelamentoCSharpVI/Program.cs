
bool valido;
int valoresLidos = 0;
List<int> valoresInseridos = new();

do
{
    Console.WriteLine("Insira a quantidade de valores a serem lidos:");
    valido = int.TryParse(Console.ReadLine(), out valoresLidos);
}
while (!valido || valoresLidos < 0);


Console.WriteLine($"Insira {valoresLidos} números inteiros: ");

    for( int i = 0; i < valoresLidos; i++)
    {
        Console.WriteLine($"Insira {i+1} valor:");
        int valorInserido = int.Parse(Console.ReadLine());
        valoresInseridos.Add(valorInserido);
    }

    int valoresIn = valoresInseridos.Count(x => x >= 10 && x <= 20);
    int valoresOut = valoresInseridos.Count(x => x < 10 || x > 20);

Console.WriteLine($"{valoresIn} in");
Console.WriteLine($"{valoresOut} out");







