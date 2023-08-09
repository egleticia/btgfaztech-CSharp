
bool valido;
int tipoCombustivel;
int somaAlcool = 0;
int somaGasolina = 0;
int somaDiesel = 0;

do
{
    do
    {
        Console.WriteLine("Por favor, insira um número correspondente ao tipo de combustível:");
        Console.WriteLine("1. Álcool");
        Console.WriteLine("2. Gasolina");
        Console.WriteLine("3. Diesel");
        Console.WriteLine("4. Fim");

        valido = int.TryParse(Console.ReadLine(), out tipoCombustivel);
    }
    while (!valido || tipoCombustivel > 4 || tipoCombustivel < 1);


    if (tipoCombustivel == 1)
        somaAlcool += 1;

    else if (tipoCombustivel == 2)
        somaGasolina += 1;

    else if (tipoCombustivel == 3)
        somaDiesel += 1;
}
while (tipoCombustivel != 4);

Console.WriteLine("MUITO OBRIGADO!");
Console.WriteLine($"Alcool: {somaAlcool}");
Console.WriteLine($"Gasolina: {somaGasolina}");
Console.WriteLine($"Diesel: {somaDiesel}");







