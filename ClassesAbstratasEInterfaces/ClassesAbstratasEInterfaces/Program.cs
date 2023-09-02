
using ClassesAbstratasEInterfaces;
using System;


Varejo varejo = new()
{
    CNPJ = "00.776.574/0001-56",
    Nome = "Americanas"
};

varejo.ImprimirInformacoes();
varejo.RealizarVenda();

Empreiteira empreiteira = new()
{
    CNPJ = "71.476.527/0001-35",
    Nome = "Tenda"
};

empreiteira.ImprimirInformacoes();
empreiteira.RealizarVenda();