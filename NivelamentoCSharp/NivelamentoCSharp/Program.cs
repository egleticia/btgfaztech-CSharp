
bool valido;
double valorBase;
double valorImposto;

do
{
    Console.WriteLine("Insira um valor base. Exemplo: R$ 1500.00");
    valido = double.TryParse(Console.ReadLine(), out valorBase);
}
while (!valido);


if (valorBase <= 1200.00)
    valorImposto = 0;

else if (valorBase >= 1201.00 && valorBase <= 2500.00)
    valorImposto = valorBase * 0.1;

else if (valorBase >= 2501.00 && valorBase <= 5000.00)
    valorImposto = valorBase * 0.15;

else
    valorImposto = valorBase * 0.20;

Console.WriteLine($"O valor devido a pagar de imposto é R$ {valorImposto}");



