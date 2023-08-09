

bool valido;
double horasTrabalhadas;
double salarioHora;
double salarioTotal = 0.00;
do
{
    Console.WriteLine("Por favor, insira a quantidade de horas trabalhadas no mês. Exemplo: 40.00");
    valido = double.TryParse(Console.ReadLine(), out horasTrabalhadas);
}
while (!valido);

do
{
    Console.WriteLine("Por favor, insira o salário por hora do funcionário. Exemplo: 120.00");
    valido = double.TryParse(Console.ReadLine(), out salarioHora);
}
while (!valido);

if (horasTrabalhadas > 160)
    salarioTotal = 160 * salarioHora + (horasTrabalhadas - 160) * (salarioHora * 1.5);


if (horasTrabalhadas <= 160)
    salarioTotal = horasTrabalhadas * salarioHora;


Console.WriteLine($"O salário total do funcionário neste mês é de R$ {salarioTotal} ");
